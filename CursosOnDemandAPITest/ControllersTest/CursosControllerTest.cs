using CursosOnDemandAPI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CursosOnDemandAPITest
{
    public class CursosControllerTest
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;
        public string _uri = "/api/Cursos";

        public CursosControllerTest()
        {
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task GetCursos()
        {
            var response = await _client.GetAsync(_uri);
            Xunit.Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}
