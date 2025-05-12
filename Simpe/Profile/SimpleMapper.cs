using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpe.Profile
{
    public static class SimpleMapper 
    {
        public static TDestination Map<TSource, TDestination>(TSource source) where TDestination : new()
        {
            TDestination destination = new TDestination();
            var sourceProps = typeof(TSource).GetProperties();
            var destProps = typeof(TDestination).GetProperties();

            foreach (var sourceProp in sourceProps)
            {
                var matchingDestProp = destProps.FirstOrDefault(p => p.Name == sourceProp.Name && p.PropertyType == sourceProp.PropertyType);
                if (matchingDestProp != null && matchingDestProp.CanWrite) 
                {
                    var value = sourceProp.GetValue(source);
                    matchingDestProp.SetValue(destination, value);
                }
            }
            return destination;

        }
    }
}
