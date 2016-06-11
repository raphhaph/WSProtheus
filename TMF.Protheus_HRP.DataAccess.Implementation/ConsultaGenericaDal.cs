using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Infrastructure.Database.DataAccess;
using Infrastructure.Database.Extensions;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.DTO;

namespace TMF.Protheus_HRP.DataAccess.Implementation
{
    public class ConsultaGenericaDal : DataContext, IConsultaGenericaDal
    {

        public ConsultaGenericaDal(string connectionName)
            : base(connectionName)
        {
        }
        public List<DadoGenerico> ListarCentroCustoDepartamento(string pEmpresa, string pFilial)
        {
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");

            str.Append(" select CTT_CUSTO,                                  ");
            str.Append("        CTT_DESC01                                  ");
            str.AppendFormat(" {0}dbo.CTT{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append("  where CTT_FILIAL = @FILIAL                        ");
            str.Append("    and (CTT_BLOQ = '2' OR CTT_BLOQ = 'N')          ");
            str.Append("    and D_E_L_E_T_ = ' '                            ");
            str.Append("  union                                             ");
            str.Append(" select CTT_CUSTO,                                  ");
            str.Append("        CTT_DESC01                                  ");
            str.AppendFormat(" {0}dbo.CTT{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append("  where CTT_FILIAL = ' '                            ");
            str.Append("    and (CTT_BLOQ = '2' OR CTT_BLOQ = 'N')          ");
            str.Append("    and D_E_L_E_T_ = ' '                            ");
            str.Append("  order by CTT_CUSTO                                ");


            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                var retorno = reader.Map(dr => new DadoGenerico
                {
                    Codigo = dr["CTT_CUSTO"].ToString(),
                    Descricao = dr["CTT_DESC01"].ToString()
                });
                reader.Close();
                return retorno;
            }
        }
        public List<DadoGenerico> ListarCentroCusto(string pEmpresa, string pFilial, string pCentroCusto)
        {
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
                new SqlParameter("@CENTROCUSTO", SqlDbType.VarChar){Value = pCentroCusto},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");

            str.Append(" select CTT_CUSTO,                                 ");
            str.Append("        CTT_DESC01                                 ");
            str.AppendFormat(" {0}dbo.CTT{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append("  where CTT_FILIAL = @filial                       ");
            str.Append("    and CTT_BLOQ <> '2'                            ");
            str.Append("    and CTT_DESC01 like '%'+@CENTROCUSTO+'%'           ");
            str.Append("    and D_E_L_E_T_ = ' '                           ");
            str.Append("  union                                            ");
            str.Append(" select CTT_CUSTO,                                 ");
            str.Append("        CTT_DESC01                                 ");
            str.AppendFormat(" {0}dbo.CTT{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append("  where CTT_FILIAL = ' '                           ");
            str.Append("    and CTT_BLOQ <> '2'                            ");
            str.Append("    and CTT_DESC01 like '%'+@CENTROCUSTO+'%'           ");
            str.Append("    and D_E_L_E_T_ = ' '                           ");
            str.Append("  order by CTT_CUSTO                               ");


            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                var retorno = reader.Map(dr => new DadoGenerico
                {
                    Codigo = dr["CTT_CUSTO"].ToString(),
                    Descricao = dr["CTT_DESC01"].ToString()
                });
                reader.Close();
                return retorno;
            }
        }
        public List<DadoGenerico> ListarBancos(string pEmpresa, string pFilial)
        {
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");
            str.Append(" SELECT                                              ");
            str.Append("  A6_COD,                                            ");
            str.Append("  A6_NOME                                            ");
            str.Append(" FROM                                                ");
            str.AppendFormat(" {0}dbo.SA6{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append(" WHERE                                               ");
            str.Append("  A6_FILIAL = @FILIAL                                ");
            str.Append("  AND D_E_L_E_T_ = ' '                               ");
            str.Append(" GROUP BY A6_COD,A6_NOME                             ");
            str.Append(" UNION                                               ");
            str.Append(" SELECT                                              ");
            str.Append("  A6_COD,                                            ");
            str.Append("  A6_NOME                                            ");
            str.Append(" FROM                                                ");
            str.AppendFormat(" {0}dbo.SA6{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append(" WHERE                                               ");
            str.Append("  D_E_L_E_T_ = ' '                                   ");
            str.Append(" GROUP BY A6_COD,A6_NOME                             ");
            str.Append(" ORDER BY A6_COD,A6_NOME");


            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                var retorno = reader.Map(dr => new DadoGenerico
                {
                    Codigo = dr["A6_COD"].ToString(),
                    Descricao = dr["A6_NOME"].ToString()
                });
                reader.Close();
                return retorno;
            }
        }
        public List<AgenciaBanco> ListarAgenciasBanco(string pCodigoBanco, string pEmpresa, string pFilial)
        {
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@COD", SqlDbType.VarChar){Value    = pCodigoBanco},
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;  ");
            str.Append(" SELECT                                             ");
            str.Append("  A6_COD,                                           ");
            str.Append("  A6_NOME,                                          ");
            str.Append("  A6_AGENCIA                                        ");
            str.Append(" FROM                                               ");
            str.AppendFormat(" {0}dbo.SA6{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append(" WHERE                                              ");
            str.Append("  A6_FILIAL = @FILIAL                               ");
            str.Append("  AND A6_COD = @COD                                 ");
            str.Append("  AND D_E_L_E_T_ = ' '                              ");
            str.Append(" GROUP BY A6_COD,A6_NOME,A6_AGENCIA                 ");
            str.Append(" UNION                                              ");
            str.Append(" SELECT                                             ");
            str.Append("  A6_COD,                                           ");
            str.Append("  A6_NOME,                                          ");
            str.Append("  A6_AGENCIA                                        ");
            str.Append(" FROM                                               ");
            str.AppendFormat(" {0}dbo.SA6{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append(" WHERE                                              ");
            str.Append("  A6_COD = @COD                                     ");
            str.Append("  AND D_E_L_E_T_ = ' '                              ");
            str.Append(" GROUP BY A6_COD,A6_NOME,A6_AGENCIA                 ");
            str.Append(" ORDER BY A6_COD,A6_NOME,A6_AGENCIA");

            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                var retorno = reader.Map(dr => new AgenciaBanco
                {
                    CodigoBanco = dr["A6_COD"].ToString(),
                    Codigo = dr["A6_AGENCIA"].ToString(),
                    Descricao = dr["A6_NOME"].ToString()
                });
                reader.Close();
                return retorno;
            }
        }
        public List<DadoGenerico> BuscarDadosSX5(string pEmpresa, string pFilial, TiposSX5 tipo)
        {
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
                new SqlParameter("@TIPO", SqlDbType.VarChar){Value = (int)tipo},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");
            str.Append(" SELECT                                                ");
            str.Append("     X5_CHAVE,                                         ");
            str.Append("     X5_DESCRI                                         ");
            str.Append(" FROM                                                  ");
            str.AppendFormat(" {0}dbo.SX5{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append(" WHERE                                                 ");
            str.Append("     X5_FILIAL = @FILIAL                               ");
            str.Append("     AND X5_TABELA = @TIPO                             ");
            str.Append("     AND D_E_L_E_T_ = ' '                              ");
            str.Append(" UNION                                                 ");
            str.Append(" SELECT                                                ");
            str.Append("     X5_CHAVE,                                         ");
            str.Append("     X5_DESCRI                                         ");
            str.Append(" FROM                                                  ");
            str.AppendFormat(" {0}dbo.SX5{1}0 ", linkedServerForQuery, pEmpresa);
            str.Append(" WHERE                                                 ");
            str.Append("     X5_TABELA = @TIPO                                 ");
            str.Append("     AND D_E_L_E_T_ = ' '                              ");
            str.Append(" ORDER BY X5_CHAVE                                     ");



            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                var retorno = reader.Map(dr => new DadoGenerico
                {
                    Codigo = dr["X5_CHAVE"].ToString().Trim(),
                    Descricao = dr["X5_DESCRI"].ToString().Trim()
                });
                reader.Close();
                return retorno;
            }
        }
        public List<DadoGenerico> ListarCargos(string pEmpresa, string pFilial)
        {
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");

            str.Append(" select Q3_CARGO,                                       ");
            str.Append("        Q3_DESCSUM                                      ");
            str.AppendFormat(" {0}dbo.SQ3{1}0 SQ3", linkedServerForQuery, pEmpresa);
            str.Append("  where SQ3.Q3_FILIAL = @FILIAL                         ");
            str.Append("    and SQ3.D_E_L_E_T_ = ' '                            ");
            str.Append(" union                                                  ");
            str.Append(" select Q3_CARGO,                                       ");
            str.Append("        Q3_DESCSUM                                      ");
            str.AppendFormat(" {0}dbo.SQ3{1}0 SQ3", linkedServerForQuery, pEmpresa);
            str.Append("  where SQ3.Q3_FILIAL = ' '                             ");
            str.Append("    and SQ3.D_E_L_E_T_ = ' '                            ");
            str.Append("  order by Q3_CARGO                                     ");



            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                var retorno = reader.Map(dr => new DadoGenerico
                {
                    Codigo = dr["Q3_CARGO"].ToString(),
                    Descricao = dr["Q3_DESCSUM"].ToString()
                });
                reader.Close();
                return retorno;
            }
        }
    }
}
