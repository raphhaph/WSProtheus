using System;
using TMF.Protheus_HRP.Domain.DTO;
namespace TMF.Protheus_HRP.DataAccess.Contracts
{
    public interface ICargoDal
    {
        String BuscarCargo(string matricula, string pFilial, string pEmpresa, string codigo);
    }
}
