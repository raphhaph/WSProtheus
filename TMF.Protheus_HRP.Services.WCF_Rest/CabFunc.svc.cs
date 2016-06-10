using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;
using TMF.Protheus_HRP.Resources;
using TMF.Protheus_HRP.Services.Contratcs;
using TMF.Protheus_HRP.Services.Seedwork.ErrorHandlers;
using TMF.Protheus_HRP.Services.Seedwork.InstanceProviders;

namespace TMF.Protheus_HRP.Services.WCF_Rest
{

    [ServiceErrorHandler]
    [NinjectInstanceProviderServiceBehavior]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class CabFunc : BaseInstanceProvider, ICabFunc
    {
        private readonly ICabFuncApp _iCabFuncApp;
        public CabFunc(ICabFuncApp iApp)
        {
            _iCabFuncApp = iApp;
        }

        public ListarCabFuncionarioResponse ListarCabFuncionario(BuscarCabFuncionarioRequest request)
        {

            if (!DecodeFrom64(request.Usuario).Equals(Usuario) || !DecodeFrom64(request.Senha).Equals(Senha))
                return new ListarCabFuncionarioResponse
                {
                    BusinessErrors = new List<string>() { Messages.ErroAutenticacao },
                };

            return _iCabFuncApp.ListarCabFuncionario(request);
        }


    }
}
