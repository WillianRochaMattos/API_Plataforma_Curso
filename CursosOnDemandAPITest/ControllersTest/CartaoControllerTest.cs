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
    public class CartaoControllerTest
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;
        private string _uri = "/api/Cartao";

        public CartaoControllerTest()
        {
            _server = new TestServer(new WebHostBuilder()
               .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task GetCartao()
        {
            var response = await _client.GetAsync(_uri);
            Xunit.Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
        }
    }
}
