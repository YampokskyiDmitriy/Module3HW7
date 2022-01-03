using System;
using System.Threading.Tasks;

namespace Module3HW7.Services.Abstractions
{
    public interface IJsonService
    {
        public Task<object> DeserializationAsync(string jsonObj, Type type);
    }
}
