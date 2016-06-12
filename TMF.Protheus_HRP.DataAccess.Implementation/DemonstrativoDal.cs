using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Infrastructure.Database.DataAccess;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.DTO;
using System.Text;
using System.Globalization;

namespace TMF.Protheus_HRP.DataAccess.Implementation
{
    public class DemonstrativoDal : DataContext, IDemonstrativoDal
    {

        public DemonstrativoDal(string connectionName)
            : base(connectionName)
        { }

        public Demonstrativo BuscarDemonstrativo(string matricula, string pFilial, string pEmpresa, string tipoDemonstrativoProtheus, string periodoDe, string periodoAte)
        {
            Demonstrativo retorno = null;
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
                new SqlParameter("@MAT", SqlDbType.VarChar){Value = matricula},
                new SqlParameter("@pPeriodoDe", SqlDbType.VarChar){Value = periodoDe},
                new SqlParameter("@pPeriodoAte", SqlDbType.VarChar){Value = periodoAte},
            };
            var sbQuery = new StringBuilder(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");
            sbQuery.Append(CriarQueryDemonstrativo(pEmpresa, tipoDemonstrativoProtheus, true));
            sbQuery.Append(" UNION ");
            sbQuery.Append(CriarQueryDemonstrativo(pEmpresa, tipoDemonstrativoProtheus, false));

            var baseIRPF = new[]
            {
                "0350", "0353", "0396", "0399", "0017", "0108", "0293", "0294", "0337", "0400", "0649", "0974", "0979",
                "0015", "0016", "0027", "0057", "0173", "0174", "0221", "0225"
            };
            var baseFGTS01 = new[] { "0013", "0014" };
            var baseFGTS02 = new[] { "0019", "0020" };
            var baseFGTS03 = new[] { "0018", "0109", "0214", "0339", "0400", "0722", "0117", "0118", "0119", "0120", "0132", "0135", "0292", "0297", "0339", "0650", "0712" };
            using (var reader = ExecuteReader(sbQuery.ToString(), CommandType.Text, parameters))
            {
                bool firstRow = true;
                Decimal vbase = 0;
                Decimal hbase = 0;
                Decimal vbase13 = 0;
                Decimal hbase13 = 0;
                while (reader.Read())
                {
                    if (firstRow)
                    {
                        var bancoAgencia = reader["RA_BCDEPSA"].ToString();
                        firstRow = false;
                        retorno = new Demonstrativo
                        {
                            Referencia = reader["RD_DATARQ"].ToString(),
                            UnidadeOrganizacional = reader["RA_CC"].ToString(),
                            Secao = reader["RA_DEPTO"].ToString(),
                            Matricula = reader["RA_MAT"].ToString(),
                            Nome = reader["RA_NOME"].ToString(),
                            CPF = reader["RA_CIC"].ToString(),
                            DataAdmissao = reader["RA_ADMISSA"].ToString(),
                            Cargo = reader["RA_CODFUNC"].ToString(),
                            Salario = reader["RA_SALARIO"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["RA_SALARIO"], CultureInfo.InstalledUICulture),
                            QuantidadeDependenteSalarioFamilia = reader["RA_DEPSF"].ToString(),
                            QuantidadeDependentesIR = reader["RA_DEPIR"].ToString(),
                            Banco = bancoAgencia.Substring(0, 3),
                            Agencia = bancoAgencia.Substring(3),
                            ContaCorrente = reader["RA_CTDEPSA"].ToString(),
                            DataPagamento = reader["RD_DATPGT"].ToString()
                        };
                    }
                    if (tipoDemonstrativoProtheus == "3")
                    {
                        switch (reader["RV_TIPOCOD"].ToString())
                        {
                            case "1":
                                retorno.Eventos.Add(new Evento
                                {
                                    CodigoRubrica = reader["RD_PD"].ToString(),
                                    DescricaoRubrica = reader["RV_DESC"].ToString(),
                                    Quantidade = Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                    Valor = Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture)
                                });

                                break;
                            case "2":
                                retorno.Eventos.Add(new Evento
                                {
                                    CodigoRubrica = reader["RD_PD"].ToString(),
                                    DescricaoRubrica = reader["RV_DESC"].ToString(),
                                    Quantidade = Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                    Desconto = Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture)
                                });
                                break;
                        }
                        if (baseIRPF.Contains(reader["RV_CODFOL"].ToString()))
                        {
                            retorno.Bases.Add(new Evento
                            {
                                CodigoRubrica = reader["RD_PD"].ToString(),
                                DescricaoRubrica = reader["RV_DESC"].ToString(),
                                Quantidade = Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                Desconto = Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture),
                            });
                        }
                        else if (baseFGTS01.Contains(reader["RV_CODFOL"].ToString()))
                        {
                            vbase += Convert.ToDecimal(reader["RD_VALOR"], CultureInfo.InvariantCulture);
                            hbase += Convert.ToDecimal(reader["RD_HORAS"], CultureInfo.InvariantCulture);
                        }
                        else if (baseFGTS02.Contains(reader["RV_CODFOL"].ToString()))
                        {
                            vbase13 += Convert.ToDecimal(reader["RD_VALOR"], CultureInfo.InvariantCulture);
                            hbase13 += Convert.ToDecimal(reader["RD_HORAS"], CultureInfo.InvariantCulture);
                        }
                        else if (baseFGTS03.Contains(reader["RV_CODFOL"].ToString()))
                        {
                            retorno.Recolhimentos.Add(new RecolhimentoFGTS
                            {
                                Codigo = reader["RD_PD"].ToString(),
                                Descricao = reader["RV_DESC"].ToString(),
                                Referencia = Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                Valor = Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture)
                            });
                        }
                        else if (reader["RV_CODFOL"].ToString() == "0313")
                        {
                            retorno.Cooperativas.Add(new Evento
                            {
                                CodigoRubrica = reader["RD_PD"].ToString(),
                                DescricaoRubrica = reader["RV_DESC"].ToString(),
                                Quantidade = Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                Valor = Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture),
                            });
                        }
                        else
                        {
                            //If Posicione("SP9",4,xFilial("SP9")+QRY->RD_PD,"P9_IDPON") $ "023A|024A"
                            //aAdd(aBanc,{QRY->RD_PD,QRY->RV_DESC,QRY->RD_HORAS,QRY->RD_VALOR}) //BASE BANCO DE HORAS
                            //EndIf
                            if (reader["RD_PD"].ToString() == "023A" || reader["RD_PD"].ToString() == "024A")
                                retorno.BancoDeHoras.Add(new Evento
                                {
                                    CodigoRubrica = reader["RD_PD"].ToString(),
                                    DescricaoRubrica = reader["RV_DESC"].ToString(),
                                    Quantidade = Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                    Valor = Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture),
                                });
                        }
                    }
                    else if (tipoDemonstrativoProtheus == "1")
                    {
                        if (reader["RV_TIPOCOD"].ToString() == "2")
                        {
                            retorno.Eventos.Add(new Evento
                            {
                                CodigoRubrica = reader["RD_PD"].ToString(),
                                DescricaoRubrica = reader["RV_DESC"].ToString(),
                                Quantidade = Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                Valor = Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture),
                            });
                        }
                    }
                    else if (tipoDemonstrativoProtheus == "10" || tipoDemonstrativoProtheus == "2" || tipoDemonstrativoProtheus == "5" )
                    {
                        if (reader["RV_TIPOCOD"].ToString() == "1")
                        {
                            retorno.Eventos.Add(new Evento
                            {
                                CodigoRubrica = reader["RD_PD"].ToString(),
                                DescricaoRubrica = reader["RV_DESC"].ToString(),
                                Quantidade = Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                Valor = Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture),
                            });
                        }
                        else if (reader["RV_TIPOCOD"].ToString() == "2")
                        {
                            retorno.Eventos.Add(new Evento
                            {
                                CodigoRubrica = reader["RD_PD"].ToString(),
                                DescricaoRubrica = reader["RV_DESC"].ToString(),
                                Quantidade =
                                    Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                Desconto =
                                    Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture),
                            });
                        }
                        else
                        {
                            retorno.Bases.Add(new Evento
                            {
                                CodigoRubrica = reader["RD_PD"].ToString(),
                                DescricaoRubrica = reader["RV_DESC"].ToString(),
                                Quantidade =
                                    Convert.ToDecimal(reader["RD_HORAS"].ToString(), CultureInfo.InvariantCulture),
                                Desconto =
                                    Convert.ToDecimal(reader["RD_VALOR"].ToString(), CultureInfo.InvariantCulture),
                            });
                        }
                    }
                }
                if (tipoDemonstrativoProtheus == "3")
                {
                    if (vbase != 0 || hbase != 0)
                    {
                        retorno.Bases.Add(new Evento
                        {
                            CodigoRubrica = "0721/0722",
                            DescricaoRubrica = "Base INSS",
                            Quantidade = hbase,
                            Valor = vbase,
                        });
                    }
                    if (vbase13 != 0 || hbase13 != 0)
                    {
                        retorno.Bases.Add(new Evento
                        {
                            CodigoRubrica = "0723/0724",
                            DescricaoRubrica = "Base INSS 13",
                            Quantidade = hbase13,
                            Valor = vbase13,
                        });
                    }
                }
                reader.Close();
                return retorno;
            }
        }

        private string CriarQueryDemonstrativo(string pEmpresa, string tipoDemonstrativoProtheus, bool incluirFilial)
        {
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var sbQuery = new StringBuilder();
            sbQuery.Append(" SELECT ");
            sbQuery.Append(" RA_FILIAL, ");
            sbQuery.Append(" RA_MAT, RV_TIPOCOD, RD_TIPO2,");
            sbQuery.Append(" RA_CC, ");
            sbQuery.Append(" RA_DEPTO, ");
            sbQuery.Append(" RA_NOME, ");
            sbQuery.Append(" RA_CIC, ");
            sbQuery.Append(" RA_ADMISSA, ");
            sbQuery.Append(" RA_CODFUNC, ");
            sbQuery.Append(" RA_SALARIO, ");
            sbQuery.Append(" RA_DEPSF, ");
            sbQuery.Append(" RA_DEPSF, ");
            sbQuery.Append(" RA_DEPIR, ");
            sbQuery.Append(" RA_BCDEPSA, ");
            sbQuery.Append(" RA_CTDEPSA, ");
            sbQuery.Append(" RD_FILIAL, ");
            sbQuery.Append(" RD_MAT, ");
            sbQuery.Append(" RD_DATPGT, ");
            sbQuery.Append(" RD_DATARQ, ");
            sbQuery.Append(" RD_PD, ");
            sbQuery.Append(" RD_HORAS, ");
            sbQuery.Append(" RD_VALOR, ");
            sbQuery.Append(" RV_COD, ");
            sbQuery.Append(" RV_DESC, ");
            sbQuery.Append(" RV_TIPOCOD, ");
            sbQuery.Append(" RV_CODFOL ");
            sbQuery.AppendFormat(" FROM  {0}dbo.SRD{1}0 SRD", linkedServerForQuery, pEmpresa);
            sbQuery.AppendFormat(" INNER JOIN   {0}dbo.SRA{1}0 SRA", linkedServerForQuery, pEmpresa);
            if (incluirFilial)
                sbQuery.Append(" ON RA_FILIAL = @FILIAL AND RA_MAT = RD_MAT AND SRA.D_E_L_E_T_ = '' ");
            else
                sbQuery.Append(" ON RA_MAT = RD_MAT AND SRA.D_E_L_E_T_ = '' ");

            sbQuery.AppendFormat(" INNER JOIN   {0}dbo.SRV{1}0 SRV", linkedServerForQuery, pEmpresa);

            if (incluirFilial)
                sbQuery.Append(" ON RV_FILIAL = @FILIAL AND RV_COD = RD_PD AND SRV.D_E_L_E_T_ = '' ");
            else
                sbQuery.Append(" ON RV_COD = RD_PD AND SRV.D_E_L_E_T_ = '' ");

            switch (tipoDemonstrativoProtheus)
            {
                case "2":
                    sbQuery.Append(" AND SRV.RV_CODFOL IN ('0019','0024','0027','0108','0109','0173','0172','0398','0400','0070','0071','0183','0123') ");
                    break;
                case "5":
                    sbQuery.Append(" AND SRV.RV_CODFOL IN ('0151','0152','0300','0411','0835','0836') ");
                    break;
                case "10":
                    sbQuery.Append(" AND SRV.RV_CODFOL IN ('0022','0108','0109','0173','0172','0398','0400') ");
                    break;
            }

            if (incluirFilial)
                sbQuery.Append(" WHERE SRD.RD_FILIAL = @FILIAL AND SRD.RD_MAT = @MAT ");
            else
                sbQuery.Append(" WHERE SRD.RD_MAT = @MAT ");
            sbQuery.Append(" AND SRD.RD_DATARQ BETWEEN @pPeriodoDe AND @pPeriodoAte ");
            sbQuery.Append(" AND SRD.D_E_L_E_T_ = '' ");

            if (tipoDemonstrativoProtheus == "1")
                sbQuery.Append(" AND SRD.RD_TIPO2 = 'A' ");
            return sbQuery.ToString();
        }
    }
}
