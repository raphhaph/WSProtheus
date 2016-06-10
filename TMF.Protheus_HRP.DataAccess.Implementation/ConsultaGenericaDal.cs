using System;
using System.Collections.Generic;
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
    public class ConsultaGenericaDal : DataContext, IConsultaGenericaDal
    {

        public ConsultaGenericaDal(string connectionName)
            : base(connectionName)
        {
        }
    }
}
