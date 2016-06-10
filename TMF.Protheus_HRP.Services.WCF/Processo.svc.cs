using System;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.Processo;
using TMF.Protheus_HRP.Services.Contratcs;
using TMF.Protheus_HRP.Services.Seedwork.ErrorHandlers;
using TMF.Protheus_HRP.Services.Seedwork.InstanceProviders;

namespace TMF.Protheus_HRP.Services.WCF
{
    [ServiceErrorHandler]
    [NinjectInstanceProviderServiceBehavior]
    public class Processo : IProcesso
    {
        private readonly IProcessoApp _iProcessoApp;
        private readonly IProcessoFacadeApp _iProcessoFacadeApp;

        public Processo(IProcessoApp iProcessoApp, IProcessoFacadeApp iProcessoFacadeApp)
        {
            if (iProcessoApp == null)
                throw new ArgumentException("_iProcessoApp");
            if (iProcessoFacadeApp == null)
                throw new ArgumentException("_iProcessoFacadeApp");

            _iProcessoApp = iProcessoApp;
            _iProcessoFacadeApp = iProcessoFacadeApp;
        }

        public CriarProcessoResponse CriarProcesso(CriarProcessoRequest request)
        {
            return _iProcessoFacadeApp.CriarProcesso(request);
        }

        public CancelarProcessoResponse CancelarProcesso(CancelarProcessoRequest request)
        {
            return _iProcessoFacadeApp.CancelarProcesso(request);
        }

        public ReabrirProcessoResponse ReabrirProcesso(ReabrirProcessoRequest request)
        {
            return _iProcessoFacadeApp.ReabrirProcesso(request);
        }

        //public MovimentarProcessoResponse MovimentarProcesso(MovimentarProcessoRequest request)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<ListarProcessoResponse> ListarProcessos(ListarProcessoRequest request)
        //{
        //    throw new NotImplementedException();
        //}

        //public ObterProcessoResponse ObterProcessoProcesso(ObterProcessoRequest request)
        //{
        //    return _iProcessoApp.ObterProcesso(request);
        //}

        //public AtualizarUsuarioProcessoResponse AtualizarUsuarioProcesso(AtualizarUsuarioProcessoRequest request)
        //{
        //    return _iProcessoFacadeApp.AtualizarUsuarioProcesso(request);
        //}
        //public EncerrarProcessoResponse EncerrarProcesso(EncerrarProcessoRequest request)
        //{
        //    return _iProcessoFacadeApp.EncerrarProcesso(request);
        //}
        public BuscarProcessoResponse BuscarProcessoPorArea(BuscarProcessoPorEquipeRequest request)
        {
            return _iProcessoApp.BuscarProcessoPorEquipe(request);
        }
        public BuscarProcessoResponse BuscarProcessoUsuarioCriacao(BuscarProcessoUsuarioCriacaoRequest request)
        {
            return _iProcessoApp.BuscarProcessoUsuarioCriacao(request);
        }


    }
}
