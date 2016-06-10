using System.ServiceModel;
using TMF.FollowME.Domain.RequestResponse.Equipe;
using TMF.FollowME.Domain.RequestResponse.FaultContracts;

namespace TMF.FollowME.Services.Contratcs
{
    [ServiceContract]
    public interface IEquipe
    {
        [OperationContract]
        [FaultContract(typeof(ServiceError))]
        BuscarEquipeResponse BuscarEquipeDoProcesso(BuscarEquipeDoProcessoRequest request);
        [OperationContract]
        [FaultContract(typeof(ServiceError))]
        BuscarEquipeResponse BuscarAreaPorUsuario(BuscarEquipeRequest request);
        [OperationContract]
        [FaultContract(typeof(ServiceError))]
        BuscarEquipeResponse ListarArea(ListarEquipeRequest request);
    }
}
