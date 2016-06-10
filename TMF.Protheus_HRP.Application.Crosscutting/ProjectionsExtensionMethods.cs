using System.Collections.Generic;
using TMF.Protheus_HRP.Domain.DTO.Base;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Application.Crosscutting
{
    public static class ProjectionsExtensionMethods
    {
        public static TProjection ProjectedAs<TProjection>(this RequestResponseBase item) where TProjection : new()
        {
            return Adapter.Adapt<TProjection>(item);
        }
        public static List<TProjection> ProjectedAsCollection<TProjection>(this IEnumerable<RequestResponseBase> items) where TProjection : new()
        {
            var lista = new List<TProjection>();
            foreach (var item in items)
            {
                var obj = Adapter.Adapt<TProjection>(item);
                lista.Add(obj);
            }
            return lista;
        }
        public static List<TProjection> ProjectedAsCollection<TProjection>(this IEnumerable<TProjection> items) where TProjection : new()
        {
            var lista = new List<TProjection>();
            foreach (var item in items)
            {
                var obj = Adapter.Adapt<TProjection>(item);
                lista.Add(obj);
            }
            return lista;
        }
        public static TProjection ProjectedAs<TProjection>(this Entity item) where TProjection : new()
        {
            return Adapter.Adapt<TProjection>(item); ;
        }
        public static List<TProjection> ProjectedAsCollection<TProjection>(this IEnumerable<Entity> items) where TProjection : new()
        {
            var lista = new List<TProjection>();
            foreach (var item in items)
            {
                var obj = Adapter.Adapt<TProjection>(item);
                lista.Add(obj);
            }
            return lista;
        }
        public static TProjection ProjectedAsSingle<TProjection>(this IEnumerable<Entity> items) where TProjection : new()
        {
            return Adapter.Adapt<TProjection>(items);
        }

    }
}
