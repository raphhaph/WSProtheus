using System;
using TMF.FollowME.Application.Contracts;
using TMF.FollowME.Domain.RequestResponse.Equipe;
using TMF.FollowME.Services.Contratcs;
using TMF.FollowME.Services.Seedwork.ErrorHandlers;
using TMF.FollowME.Services.Seedwork.InstanceProviders;

namespace TMF.FollowME.Services.WCF
{
    [ServiceErrorHandler]
    [NinjectInstanceProviderServiceBehavior]
    public class Equipe : IEquipe
    {
        private readonly IEquipeApp _iEquipeApp;
        private readonly IEquipeFacadeApp _iEquipeFacadeApp;
        public Equipe(IEquipeApp iEquipeApp, IEquipeFacadeApp iEquipeFacadeApp)
        {
            if (iEquipeApp == null)
                throw new ArgumentException("_iAreaApp");
            if (iEquipeFacadeApp == null)
                throw new ArgumentException("_iAreaFacadeApp");
           
            _iEquipeApp = iEquipeApp;
            _iEquipeFacadeApp = iEquipeFacadeApp;
        }
        public BuscarEquipeResponse BuscarEquipeDoProcesso(BuscarEquipeDoProcessoRequest request)
        {
            return _iEquipeFacadeApp.BuscarEquipeDoProcesso(request);
        }
        public BuscarEquipeResponse BuscarAreaPorUsuario(BuscarEquipeRequest request)
        {
            return new BuscarEquipeResponse(); //_iEquipeApp.BuscarEquipePorUsuario(request);
        }
        public BuscarEquipeResponse ListarArea(ListarEquipeRequest request)
        {
            return _iEquipeApp.ListarEquipe(request);
        }
    }
}
