using System;
using System.Collections.Generic;
using System.Data;

namespace Infrastructure.Database.Extensions
{
    public static class Extensions
    {
        public static List<T> Map<T>(this IDataReader reader, Func<IDataReader, T> mapper)
        {
            var lista = new List<T>();
            while (reader.Read())
            {
                lista.Add(mapper(reader));
            }

            return lista;
        }
    }
}
