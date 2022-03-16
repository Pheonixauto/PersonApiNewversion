using System.Net.Http.Headers;

namespace PersonApi.Services.HttpClientService
{
    public interface IClientService
    {
        Task<string> Test();
    }
}
