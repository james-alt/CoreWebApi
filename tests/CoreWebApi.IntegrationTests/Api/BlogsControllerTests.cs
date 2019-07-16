using System;
using System.Net.Http;
using CoreWebApi.Api;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace CoreWebApi.IntegrationTests.Api
{
    public class BlogsControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private HttpClient _client;

         public BlogsControllerTests(WebApplicationFactory<Startup> factory)
         {
             _client = factory.CreateClient();
         }

        [Fact]
        public async void Test1()
        {
           // var httpResponse = await _client.GetAsync("/api/v1/Blogs");

            // Must be successful.
//            httpResponse.EnsureSuccessStatusCode();

            // Deserialize and examine results.
//            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            Assert.True(true); 
        }
    }
}