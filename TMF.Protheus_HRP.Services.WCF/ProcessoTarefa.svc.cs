using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.ProcessoTarefa;
using TMF.Protheus_HRP.Services.Contratcs;
using TMF.Protheus_HRP.Services.Seedwork.ErrorHandlers;
using TMF.Protheus_HRP.Services.Seedwork.InstanceProviders;

namespace TMF.Protheus_HRP.Services.WCF
{
    [ServiceErrorHandler]
    [NinjectInstanceProviderServiceBehavior]
    public class ProcessoTarefa : IProcessoTarefa
    {
        private readonly IProcessoTarefaFacadeApp _iProcessoTarefaFacadeApp;

        public ProcessoTarefa(IProcessoTarefaFacadeApp iProcessoTarefaFacadeApp)
        {
            _iProcessoTarefaFacadeApp = iProcessoTarefaFacadeApp;
        }

        public BuscarProcessoTarefaResponse BuscarProcessoTarefa(BuscarProcessoTarefaRequest request)
        {
            return _iProcessoTarefaFacadeApp.BuscarProcessoTarefa(request);
        }
        public IniciarProcessoTarefaResponse IniciarProcessoTarefa(IniciarProcessoTarefaRequest request)
        {
            return _iProcessoTarefaFacadeApp.IniciarProcessoTarefa(request);
        }
        public AlterarResponsavelResponse AlterarResponsavel(AlterarResponsavelRequest request)
        {
            return _iProcessoTarefaFacadeApp.AlterarResponsavel(request);
        }
        public EncerrarProcessoTarefaResponse EncerrarProcessoTarefa(EncerrarProcessoTarefaRequest request)
        {
            return _iProcessoTarefaFacadeApp.EncerrarProcessoTarefa(request);
        }
    }
}
