using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;
using TMF.Protheus_HRP.Domain.RequestResponse.FaultContracts;

namespace TMF.Protheus_HRP.Services.Contratcs
{
     [ServiceContract]
   public interface ICabFunc
    {
        
         [OperationContract]
         [WebInvoke(Method = "POST",
             BodyStyle = WebMessageBodyStyle.Bare,
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "/CabFuncionario")]
        [FaultContract(typeof(ServiceError))]
        ListarCabFuncionarioResponse ListarCabFuncionario(BuscarCabFuncionarioRequest request);


    }
}
