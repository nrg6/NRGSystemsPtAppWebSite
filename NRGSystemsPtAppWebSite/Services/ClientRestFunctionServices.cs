using NRGSystemsPtAppWebSite.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace NRGSystemsPtAppWebSite.Services
{
    public class ClientRestFunctionServices : IClientRestFunctionServices
    {
        readonly HttpClient _functionClient;
        readonly HttpClient _localClient;
        readonly JsonSerializerOptions _serializerOptions = new();

        public ClientRestFunctionServices()
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

        /// <summary>
        /// enter the details and if a match is found in the database it is returned
        /// error message returned if no match is found
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<Clients> Login(string userName, string password)
        {
            Clients? client = new();
            try
            {
                client = await _functionClient.GetFromJsonAsync<Clients>(
                    $"api/Login?clientsId={password}&clientsUsername={userName}");
            }
            catch (Exception ex) { Console.WriteLine($"No match found - {ex.Message}"); }

            return client;
        }

        public async Task<bool> CreateAClient(Clients client)
        {
            var newClient = new Clients();
            try
            {
                await _functionClient.GetFromJsonAsync<bool>(
                    $"api/CreateAClient?" +
                    $"ID={client.ID}&" +
                    $"FirstName={client.FirstName}&" +
                    $"LastName={client.LastName}&" +
                    $"UserName={client.UserName}&" +
                    $"Password={client.Password}&" +
                    $"Email={client.Email}&" +
                    $"Phone={client.Phone}&" +
                    $"DoB={client.DoB}&" +
                    $"Sex={client.Sex}&" +
                    $"Height={client.Height}&" +
                    $"Weight={client.Weight}&" +
                    $"Enabled={client.Enabled}&" +
                    $"ProgramRevisionNo={client.ProgramRevisionNo}&" +
                    $"ReportRevisionNo={client.ReportRevisionNo}&" +
                    $"MessageRevisionNo={client.MessageRevisionNo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return false;
            }
            return true;
        }

        public async Task<List<Clients>> GetAllClients()
        {
            //var clients = new List<Clients>();
            try
            {
                //clients = await _functionClient.GetFromJsonAsync<List<Clients>>("api/GetAllClients");
                return await _functionClient.GetFromJsonAsync<List<Clients>>("api/GetAllClients");
                //return await _localClient.GetFromJsonAsync<List<Clients>>("api/GetAllClients");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }
            //return clients;
            return new List<Clients>();
        }

        public async Task<Clients> GetAClient(int clientsId)
        {
            var clients = new Clients();
            try
            {
                //clients = await _functionClient.GetFromJsonAsync<Clients>(
                //clients = await _localClient.GetFromJsonAsync<Clients>(
                return await _functionClient.GetFromJsonAsync<Clients>(
                    $"api/GetAClient?clientsId={clientsId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return clients;
            //return new Clients();
        }

        public async Task<string> DeleteAClient(int clientsId)
        {
            try
            {
                await _functionClient.GetFromJsonAsync<string>(
                    $"api/DeleteClient?clientsId={clientsId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return ex.Message;
            }

            return "OK";
        }

        public async Task<string> EditAClient(Clients client)
        {
            //var newClient = new Clients();
            try
            {
                await _functionClient.GetFromJsonAsync<bool>(
                    $"api/EditAClient?ID={client.ID}&" +
                    $"FirstName={client.FirstName}&" +
                    $"LastName={client.LastName}&" +
                    $"UserName={client.UserName}&" +
                    $"Password={client.Password}&" +
                    $"Email={client.Email}&" +
                    $"Phone={client.Phone}&" +
                    $"DoB={client.DoB}&" +
                    $"Sex={client.Sex}&" +
                    $"Height={client.Height}&" +
                    $"Weight={client.Weight}&" +
                    $"Enabled={client.Enabled}&" +
                    $"ProgramRevisionNo={client.ProgramRevisionNo}&" +
                    $"ReportRevisionNo={client.ReportRevisionNo}&" +
                    $"MessageRevisionNo={client.MessageRevisionNo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
                return ex.Message;
            }

            return "OK";
        }
    }
}
