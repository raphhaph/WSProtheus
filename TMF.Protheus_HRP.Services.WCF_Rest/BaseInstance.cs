using System;
using System.Configuration;
using System.Text;

namespace TMF.Protheus_HRP.Services.WCF_Rest
{
    public class BaseInstanceProvider
    {
        protected string Usuario;
        protected string Senha;


        public BaseInstanceProvider()
        {
            CarregarParametros();
        }

        private void CarregarParametros()
        {

            Usuario = ConfigurationManager.AppSettings["Login"];
            Senha = ConfigurationManager.AppSettings["Senha"];

        }

        public string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes = Convert.FromBase64String(encodedData);
            return ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
        }

    }
}