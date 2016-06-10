using System.Collections.Generic;

namespace TMF.FollowME.DataAccess.Contracts
{
    public interface IRoteiroDal 
    {
        List<TMF.FollowME.Domain.DTO.Roteiro.Roteiro> ListaRoteitos();

        TMF.FollowME.Domain.DTO.Roteiro.Roteiro ObterRoteiro(int idRoteiro);
    }
}
