using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Domain.RequestResponse.CabFunc;
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
        
         public ListarCabFuncionarioResponse ListarCabFuncionario(BuscarCabFuncionarioRequest request)
        {

            if (!DecodeFrom64(request.Usuario).Equals(_usuario) ||
                   !DecodeFrom64(request.Senha).Equals(_senha))
                return new ListarCabFuncionarioResponse
                {
                    
                    BusinessErrors = new List<string>(){"Falha de autenticação: usuário ou senha inválido."},
                       

                };

            return _iCabFuncApp.ListarCabFuncionario(request);
        }

        
    }
}
