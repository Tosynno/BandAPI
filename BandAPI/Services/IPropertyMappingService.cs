using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Services
{
    public interface IPropertyMappingService
    {
        Dictionary<string, PropertyMapingValue> GetPropertyMapping<TSource, TDestination>();

        bool ValidMappingExists<TSource, TDestination>(string fields);
    }
}
