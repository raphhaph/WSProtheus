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
    public class SalarioDal : DataContext, ISalarioDal
    {

        public SalarioDal(string connectionName)
            : base(connectionName)
        { }


        public Decimal BuscarSalario(string matricula, string pFilial, string pEmpresa, string codigo, string periodo)
        {
            Decimal retorno = 0;
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
                new SqlParameter("@COD", SqlDbType.VarChar){Value = codigo},
                new SqlParameter("@MAT", SqlDbType.VarChar){Value = matricula},
                new SqlParameter("@DATA", SqlDbType.VarChar){Value = periodo},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");
            str.AppendFormat(" SELECT R3_VALOR FROM {0}dbo.SR3{1}0 SR3 WHERE SR3.D_E_L_E_T_ = '' AND SR3.D_E_L_E_T_ = '' AND SR3.R3_MAT = @MAT AND SR3.R3_FILIAL = @FILIAL  AND SR3.R3_DATA = @DATA ", linkedServerForQuery, pEmpresa);
            str.Append(" UNION ");
            str.AppendFormat(" SELECT R3_VALOR FROM {0}dbo.SR3{1}0 SR3 WHERE SR3.D_E_L_E_T_ = '' AND SR3.D_E_L_E_T_ = '' AND SR3.R3_MAT = @MAT AND SR3.R3_DATA = @DATA ", linkedServerForQuery, pEmpresa);
            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                if (reader.Read())
                    retorno = reader["R3_VALOR"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["R3_VALOR"]);

                reader.Close();
                return retorno;
            }
        }
    }
}
