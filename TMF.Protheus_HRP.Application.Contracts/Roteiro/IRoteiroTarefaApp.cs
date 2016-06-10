using System.Collections.Generic;
using TMF.FollowME.Domain.RequestResponse.Roteiro;

namespace TMF.FollowME.Application.Contracts.Roteiro
{
    public interface IRoteiroTarefaApp
    {
        List<ListarRoteiroTarefaResponse> ListarRoteiroTarefas(BuscarRoteiroTarefaRequest request);

        ObterRoteiroTarefaResponse ObterRoteiroTarefa(ObterRoteiroTarefaRequest request);
    }
}
