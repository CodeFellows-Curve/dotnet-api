using curve_api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject1.AuthorizationTests
{
   public class AuthEndPointTests
    {
        private readonly TestServer _server;
        private readonly HttpClient _client;
        private IConfiguration _configuration;

        public AuthEndPointTests()
        {
            _configuration = new ConfigurationBuilder()
            .SetBasePath(Path.GetFullPath(@"../../.."))
            .AddUserSecrets(typeof(Startup).GetTypeInfo().Assembly)
            .Build();

            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>()
                .UseConfiguration(_configuration));
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task UnAuthorizedAccess()
        {
            var response = await _client.GetAsync("/api/Authorization/andrew.l.roska%40gmail.com");

            Assert.Equal(HttpStatusCode.Unauthorized, response.StatusCode);
        }

        [Fact]
        public async Task TestGetToken()
        {
            var auth0Client = new HttpClient();
            var bodyString = $@"{{""client_id"":""{_configuration["Auth0:ClientId"]}"", ""client_secret"":""{_configuration["Auth0:ClientSecret"]}"", ""audience"":""{_configuration["Auth0:Audience"]}"", ""grant_type"":""client_credentials""}}";
            var response = await auth0Client.PostAsync($"{_configuration["Auth0:Authority"]}oauth/token", new StringContent(bodyString, Encoding.UTF8, "application/json"));

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseString = await response.Content.ReadAsStringAsync();
            var responseJson = JObject.Parse(responseString);
            Assert.NotNull((string)responseJson["access_token"]);
            Assert.Equal("Bearer", (string)responseJson["token_type"]);
        }
    }
}
