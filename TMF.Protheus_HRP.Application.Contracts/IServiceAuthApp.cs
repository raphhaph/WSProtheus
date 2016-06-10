namespace TMF.Protheus_HRP.Application.Contracts
{
    public interface IServiceAuthApp
    {
        bool AuthenticateService(string usuario, string senha);
    }
}
