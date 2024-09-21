
using NRGSystemsPtAppWebSite.Models;
using System.Text.Json;

namespace NRGSystemsPtAppWebSite.Services
{
    public class AppDownloadService : IAppDownloadService
    {

        readonly HttpClient _functionClient;
        readonly HttpClient _localClient;
        readonly JsonSerializerOptions _serializerOptions = new();
        public AppDownloadService()
        {
            _functionClient = new HttpClient
            {
                BaseAddress = new Uri("https://exercisefunction.azurewebsites.net/")
            };
            _localClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7074/")
            };
        }

        public async Task<object> GetApp(string operatingSystem)
        {
            try
            {
                //return await _localClient.GetFromJsonAsync<object>(
                return await _functionClient.GetFromJsonAsync<object>(
                    $"api/GetApp?operatingSystem={operatingSystem}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Using Azure Functions
        /// </summary>
        /// <returns> All Enabled Personal Trainers </returns>
        public async Task<List<PtModel>> GetAllPTsListAsync()
        {
            var pts = new List<PtModel>();
            var retPts = new List<PtModel>();
            try
            {
                pts = await _functionClient.GetFromJsonAsync<List<PtModel>>("api/GetAllPts");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var pt in pts)
            {
                if (pt.Enabled != 0)
                {
                    retPts.Add(pt);
                }
            }
            return retPts;
        }
    }
}
