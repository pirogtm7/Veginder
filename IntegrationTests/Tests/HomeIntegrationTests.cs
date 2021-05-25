using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Veginder.Models;

namespace IntegrationTests.Tests
{
	public class HomeIntegrationTests
	{
        private HttpClient _client;
        private WebAppFactory _factory;
        private const string RequestUri = "api/Home/";

        [SetUp]
        public void Setup()
        {
            _factory = new WebAppFactory();
            _client = _factory.CreateClient();
        }

        [Test]
        public async Task HomeController_GetShopsAndCategories_ReturnsTheExactAmount()
        {
            // Arrange
            var httpResponse = await _client.GetAsync(RequestUri);

            // Act
            httpResponse.EnsureSuccessStatusCode();
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var shopsAndCategories = JsonConvert.DeserializeObject<HomePageModel>(stringResponse);

            //Assert
            shopsAndCategories.Shops.Count.Should().Be(4);
            shopsAndCategories.Categories.Count.Should().Be(8);
        }
    }
}
