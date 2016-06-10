using TMF.FollowME.Domain.RequestResponse.Roteiro;

namespace TMF.FollowME.Application.Contracts.Roteiro
{
    public interface IRoteiroClienteApp
    {
        ObterRoteiroClienteParaProcessoResponse ObterRoteiroClienteParaProcesso(ObterRoteiroClienteParaProcessoRequest request);
    }
}
