using TMF.FollowME.Domain.RequestResponse.Equipe;

namespace TMF.FollowME.Application.Contracts
{
    public interface IEquipeFacadeApp
    {
        BuscarEquipeResponse BuscarEquipeDoProcesso(BuscarEquipeDoProcessoRequest request);
    }
}
