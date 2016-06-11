using System;
using System.Collections.Generic;
using TMF.Protheus_HRP.Domain.DTO;



namespace TMF.Protheus_HRP.DataAccess.Contracts
{
    public interface IDemonstrativoDal
    {
        Demonstrativo BuscarDemonstrativo(string matricula, string pFilial, string pEmpresa,
            string tipoDemonstrativoProtheus, string periodoDe, string periodoAte);
    }
}
