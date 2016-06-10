using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;

namespace TMF.Protheus_HRP.Application.Contracts
{
   public interface ICabFuncApp
   {
       ListarCabFuncionarioResponse ListarCabFuncionario(BuscarCabFuncionarioRequest request);

   }
}
