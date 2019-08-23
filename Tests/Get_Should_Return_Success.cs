using NUnit.Framework;
using System.Net.Http;

namespace Tests
{
    public class IntegrationTests
    {
        [SetUp]
        public void Setup()
        {
           
        }
        //this test uses httpClient
        [Test]
        public void Get_Should_Return_Success()
        {
            var httpclient = new HttpClient();
            httpclient.BaseAddress = new System.Uri("https://localhost:44374/api/");
            var responseTask = httpclient.GetAsync("users");
            responseTask.Wait();
            var result = responseTask.Result;
                       
            Assert.IsTrue(result.IsSuccessStatusCode);
        }
    }
}