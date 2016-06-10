using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using TMF.Protheus_HRP.Application.Contracts;
using TMF.Protheus_HRP.Services.Seedwork.InstanceProviders;

namespace TMF.Protheus_HRP.Services.Seedwork.Security
{
    public class ServiceCredentialsValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            var _iApp = Container.GetInstance<IServiceAuthApp>();
            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password))
                throw new SecurityTokenValidationException("Invalid Credentials");

            if (!_iApp.AuthenticateService(userName, password))
                throw new SecurityTokenValidationException("Invalid Credentials");

        }
    }
}
