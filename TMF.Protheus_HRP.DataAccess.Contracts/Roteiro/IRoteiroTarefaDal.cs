using System.Collections.Generic;
using TMF.FollowME.Domain.DTO.Roteiro;

namespace TMF.FollowME.DataAccess.Contracts.Roteiro
{
    public interface IRoteiroTarefaDal
    {
        List<RoteiroTarefa> ListarRoteiroTarefa(int idRoteiro);

        RoteiroTarefa ObterRoteiroTarefa(int idRoteiroTarefa);
    }
}
