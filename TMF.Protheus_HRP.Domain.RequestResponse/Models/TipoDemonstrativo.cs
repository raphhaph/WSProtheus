using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Models
{
    [DataContract]
    public enum TipoDemonstrativo
    {
        [EnumMember]
        PagamentoMensal = 1,
        [EnumMember]
        Adiantamento = 2,
        [EnumMember]
        PLR = 3,
        [EnumMember]
        PrimeiraParcelaDecimoTerceiro = 4,
        [EnumMember]
        DecimoTerceiro = 5,
        [EnumMember]
        AdiantamentoPLR = 6,
    }
}
