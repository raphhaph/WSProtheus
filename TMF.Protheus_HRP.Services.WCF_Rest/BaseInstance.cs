using System;
using System.Configuration;
using System.Text;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Services.Seedwork.InstanceProviders;

namespace TMF.Protheus_HRP.Services.WCF_Rest
{
    public class BaseInstanceProvider
    {
        public IServiceAuthApp  _iApp;
        public ICabFuncApp      _iCabFuncApp;
        public string           _usuario;
        public string           _senha;


        public BaseInstanceProvider()
        {
            
            _iCabFuncApp    = Container.GetInstance<ICabFuncApp>();
            CarregarParametros();
        }

        private void CarregarParametros()
        {

          _usuario  = ConfigurationManager.AppSettings["Login"];
          _senha    = ConfigurationManager.AppSettings["Senha"];
        
        }

        public string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes = Convert.FromBase64String(encodedData);
            return ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);

        }

    }
}