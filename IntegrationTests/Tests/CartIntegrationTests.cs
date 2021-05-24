using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Veginder.Models;
using FluentAssertions;


namespace IntegrationTests.Tests
{
    [TestFixture]
    public class CartIntegrationTests
    {
        private HttpClient _client;
        private WebAppFactory _factory;
        private const string RequestUri = "Cart/Cart";

        [SetUp]
        public void Setup()
        {
            _factory = new WebAppFactory();
            _client = _factory.CreateClient();
        }

        [Test]
        public async Task CartsController_GetAll_ReturnsCarts()
        {
            var httpResponse = await _client.GetAsync(RequestUri);

            httpResponse.EnsureSuccessStatusCode();
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var carts = JsonConvert.DeserializeObject<IEnumerable<CartModel>>(stringResponse);

            carts.Count().Should().Be(0);
        }
    }
}
