using System.ServiceModel;
using System.ServiceModel.Web;
using TMF.Protheus_HRP.Domain.RequestResponse.Demonstrativo;
using TMF.Protheus_HRP.Domain.RequestResponse.FaultContracts;

namespace TMF.Protheus_HRP.Application.Contracts
{
    [ServiceContract]
    public interface IDemonstrativo
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/BuscarDemonstrativo")]
        [FaultContract(typeof(ServiceError))]
        BuscarDemonstrativoResponse BuscarDemonstrativo(BuscarDemonstrativoRequest request);
    }
}
