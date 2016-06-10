using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.Fluxo;
using TMF.Protheus_HRP.Services.Contratcs;
using TMF.Protheus_HRP.Services.Seedwork.ErrorHandlers;
using TMF.Protheus_HRP.Services.Seedwork.InstanceProviders;

namespace TMF.Protheus_HRP.Services.WCF
{
    [ServiceErrorHandler]
    [NinjectInstanceProviderServiceBehavior]
    public class Fluxo : IFluxo
    {
        private readonly IFluxoFacadeApp _iFluxoFacadeApp;
        
        public Fluxo(IFluxoFacadeApp iFluxoFacadeApp)
        {
            _iFluxoFacadeApp = iFluxoFacadeApp;
        }

        public ListarFluxoResponse BuscarFluxoPorCliente(BuscarFluxoPorClienteRequest request)
        {
            return _iFluxoFacadeApp.BuscarFluxoPorCliente(request);
        }
        public ListarFluxoResponse BuscarFluxoPorEmpresa(BuscarFluxoPorEmpresaRequest request)
        {
            return _iFluxoFacadeApp.BuscarFluxoPorEmpresa(request);
        }
        public ListarFluxoResponse BuscarFluxoPorFilial(BuscarFluxoPorFilialRequest request)
        {
            return _iFluxoFacadeApp.BuscarFluxoPorFilial(request);
        }
        public ListarFluxoResponse ListarFluxo()
        {
            return _iFluxoFacadeApp.ListarFluxo();
        }
    }
}
