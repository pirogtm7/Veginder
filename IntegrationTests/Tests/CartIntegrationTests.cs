using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.Tests
{
    [TestFixture]
    public class CartIntegrationTests
    {
        private HttpClient _client;
        private WebAppFactory _factory;
        private const string RequestUri = "api/carts/";

        [SetUp]
        public void Setup()
        {
            _factory = new WebAppFactory();
            _client = _factory.CreateClient();
        }


    }
}
