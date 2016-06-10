using TMF.FollowME.Domain.RequestResponse.Assunto;

namespace TMF.FollowME.Application.Contracts
{
    public interface IAssuntoFacadeApp
    {
        CriarAssuntoResponse CriarAssunto(CriarAssuntoRequest request);
    }
}
