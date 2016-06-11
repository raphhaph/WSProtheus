﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Infrastructure.Database.DataAccess;
using Infrastructure.Database.Extensions;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.DTO;
using System.Text;

namespace TMF.Protheus_HRP.DataAccess.Implementation
{
    public class ConsultaGenericaDal : DataContext, IConsultaGenericaDal
    {

        public ConsultaGenericaDal(string connectionName)
            : base(connectionName)
        {
        }

        public List<DadoGenerico> ListarBancos(string pEmpresa, string pFilial)
        {
            var linkedServerForQuery = System.Configuration.ConfigurationManager.AppSettings["LinkedServerForQuery"];
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
            var linkedServerForQuery = System.Configuration.ConfigurationManager.AppSettings["LinkedServerForQuery"];
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
            var linkedServerForQuery = System.Configuration.ConfigurationManager.AppSettings["LinkedServerForQuery"];
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
                    Codigo = dr["A6_COD"].ToString(),
                    Descricao = dr["A6_NOME"].ToString()
                });
                reader.Close();
                return retorno;
            }
        }
    }
}
