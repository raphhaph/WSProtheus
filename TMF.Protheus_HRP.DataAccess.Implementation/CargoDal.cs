using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Infrastructure.Database.DataAccess;
using Infrastructure.Database.Extensions;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.DTO;
using System.Text;

namespace TMF.Protheus_HRP.DataAccess.Implementation
{
    public class CargoDal : DataContext, ICargoDal
    {

        public CargoDal(string connectionName)
            : base(connectionName)
        { }


        public string BuscarCargo(string matricula, string pFilial, string pEmpresa, string codigo)
        {
            string retorno = "";
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
                new SqlParameter("@COD", SqlDbType.VarChar){Value = codigo},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");
            str.AppendFormat(" SELECT RJ_FUNCAO FROM {0}dbo.SRJ{1}0 WHERE RJ_FUNCAO = @COD AND RJ_FILIAL = @FILIAL ", linkedServerForQuery, pEmpresa);
            str.Append(" UNION ");
            str.AppendFormat(" SELECT RJ_FUNCAO FROM {0}dbo.SRJ{1}0 WHERE RJ_FUNCAO = @COD ", linkedServerForQuery, pEmpresa);
            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                if (reader.Read())
                    retorno = reader["RJ_FUNCAO"].ToString();
                reader.Close();
                return retorno;
            }
        }
    }
}
