
using DealerApp.Model;
using DealerApp.Service.Interface;
using Newtonsoft.Json;


namespace DealerApp.Service.Services
{
    internal class CustomerSupoortService : ICustomerSupoortService
    {
        private readonly HttpClient _httpClient;

        public CustomerSupoortService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<CustomerSupportDTO> CustomerServices()
        {
            try
            {
                string jwtToken = await SecureStorage.GetAsync("JWTToken");
                // Set up HttpClient (base URL, headers, etc.) for your API calls
                if (!string.IsNullOrEmpty(jwtToken))
                {
                    _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwtToken);
                }
                HttpResponseMessage response = await _httpClient.GetAsync("http://10.0.2.2:5137/api/CustomerSupportAPI");

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Check if the response is an array or a single object
                    if (responseBody.StartsWith("["))
                    {
                        var customerDtos = JsonConvert.DeserializeObject<List<CustomerSupportDTO>>(responseBody);

                        // For simplicity, assuming you want to return the first item in the list
                        return customerDtos.Count > 0 ? customerDtos[0] : null;
                    }
                    else
                    {
                        var customerDto = JsonConvert.DeserializeObject<CustomerSupportDTO>(responseBody);
                        return customerDto;
                    }
                }
                else
                {
                    throw new Exception($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception: {ex.Message}");
            }
        }
    }
}
