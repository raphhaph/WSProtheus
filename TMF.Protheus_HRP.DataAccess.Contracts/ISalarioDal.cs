using System;
using TMF.Protheus_HRP.Domain.DTO;
namespace TMF.Protheus_HRP.DataAccess.Contracts
{
    public interface ISalarioDal
    {
        Decimal BuscarSalario(string matricula, string pFilial, string pEmpresa, string codigo, string periodo);
    }
}
