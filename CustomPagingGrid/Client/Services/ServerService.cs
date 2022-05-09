using CustomPagingGrid.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace CustomPagingGrid.Client.Services
{
    public class ServerService
    {
        private readonly HttpClient _httpClient;

        public ServerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DataEnvelop> GetDataAsync(int pageSize = 10, int pageNumber = 1)
        {
            try
            {
                var dataUri = new Uri($"https://localhost:7054/api/Values/data?pageSize={pageSize}&pageNumber={pageNumber}");
                var response = await _httpClient.GetAsync(dataUri);
                if (response.IsSuccessStatusCode)
                {
                    var rawData = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<DataEnvelop>(rawData);
                    return data!;
                }
                return null!;
            }
            catch (Exception e)
            {
                return null!;
            }
        }
    }
}
