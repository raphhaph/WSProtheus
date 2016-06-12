using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;
using TMF.Protheus_HRP.Domain.RequestResponse.Demonstrativo;

namespace TMF.Protheus_HRP.Application.Contracts
{
    public interface IDemonstrativoApp
    {
        BuscarDemonstrativoResponse BuscarDemonstrativo(BuscarDemonstrativoRequest request);
    }
}
