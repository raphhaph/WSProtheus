using System.ServiceModel;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.Demonstrativo;
using TMF.Protheus_HRP.Services.Seedwork.ErrorHandlers;
using TMF.Protheus_HRP.Services.Seedwork.InstanceProviders;

namespace TMF.Protheus_HRP.Services.WCF_Rest
{

    [ServiceErrorHandler]
    [NinjectInstanceProviderServiceBehavior]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Demonstrativo : BaseInstanceProvider, IDemonstrativo
    {
        private readonly IDemonstrativoApp _iDemonstrativoApp;
        public Demonstrativo(IDemonstrativoApp iApp)
        {
            _iDemonstrativoApp = iApp;
        }
        public BuscarDemonstrativoResponse BuscarDemonstrativo(BuscarDemonstrativoRequest request)
        {
            return _iDemonstrativoApp.BuscarDemonstrativo(request);
        }
    }
}
