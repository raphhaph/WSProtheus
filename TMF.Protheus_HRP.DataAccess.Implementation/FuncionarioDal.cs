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
    public class FuncionarioDal : DataContext, IFuncionarioDal
    {

        public FuncionarioDal(string connectionName)
            : base(connectionName)
        { }

        public Funcionario BuscarFuncionario(string matricula, string pFilial,string pEmpresa)
        {
            var linkedServerForQuery = ConfigurationManager.AppSettings["LinkedServerForQuery"];
            var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@FILIAL", SqlDbType.VarChar){Value = pFilial},
            };
            var str = new StringBuilder();
            str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;   ");
            str.AppendFormat(" SELECT * FROM {0}dbo.SRA{1}0 WHERE RA_MAT = @pMat AND RA_FILIAL = @pCodFilial AND D_E_L_E_T_ <> '*' ", linkedServerForQuery, pEmpresa);
            str.Append(" UNION ");
            str.AppendFormat(" SELECT * FROM {0}dbo.SRA{1}0 WHERE RA_MAT = @pMat AND D_E_L_E_T_ <> '*' ", linkedServerForQuery, pEmpresa);
            
            using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
            {
                var retorno = reader.Map(dr => new Funcionario
                {
                    Nome = dr["RA_NOME"].ToString(),
                    CPF = dr["RA_CIC"].ToString(),
                });
                reader.Close();
                return retorno.FirstOrDefault();
            }
        }
    }
}
