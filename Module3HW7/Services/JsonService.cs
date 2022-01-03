using System;
using System.Threading.Tasks;
using Module3HW7.Services.Abstractions;
using Newtonsoft.Json;

namespace Module3HW7.Services
{
    public class JsonService : IJsonService
    {
        public async Task<object> DeserializationAsync(string jsonObj, Type type)
        {
            return await Task.Run(() =>
                {
                    return JsonConvert.DeserializeObject(jsonObj, type);
                });
        }
    }
}
