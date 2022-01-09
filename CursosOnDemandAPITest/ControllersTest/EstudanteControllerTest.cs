using AutoMapper;
using CursosOnDemandAPI;
using CursosOnDemandAPI.Controllers;
using CursosOnDemandAPI.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace CursosOnDemandAPITest
{
    public class EstudanteControllerTest
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;
        public string _uri = "/api/Estudante";

        public EstudanteControllerTest()
        {
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task GetEstudantes()
        {
            var response = await _client.GetAsync(_uri);
            Xunit.Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}
