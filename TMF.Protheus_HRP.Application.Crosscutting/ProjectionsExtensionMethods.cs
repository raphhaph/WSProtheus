using System.Collections.Generic;
using System.Linq;
using TMF.Protheus_HRP.Domain.DTO.Base;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Application.Crosscutting
{
    public static class ProjectionsExtensionMethods
    {
        public static TProjection ProjectedAs<TProjection>(this object item) where TProjection : new()
        {
            return Adapter.Adapt<TProjection>(item);
        }
        public static List<TProjection> ProjectedAsCollection<TProjection>(this IEnumerable<object> items) where TProjection : new()
        {
            return items.Select(Adapter.Adapt<TProjection>).ToList();
        }
        public static TProjection ProjectedAsSingle<TProjection>(this IEnumerable<object> items) where TProjection : new()
        {
            return Adapter.Adapt<TProjection>(items);
        }

    }
}
