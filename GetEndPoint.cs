using Newtonsoft.Json;
using RestSharp;
using static TestAPIProject.Model;

namespace TestAPIProject
{
    public class GetEndPoint
    {
        [Test]
       public void GetRequest()
        {
            IRestClient client = new RestClient("https://api.coindesk.com/v1");
            RestRequest request = new RestRequest("/bpi/currentprice.json",Method.Get);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Content);

            var CoinDesk = JsonConvert.DeserializeObject<CoinResponse>(response.Content);
           Assert.IsNotNull(CoinDesk.Bpi);
            Assert.IsNotNull(CoinDesk.Bpi.USD);
            Assert.IsNotNull(CoinDesk.Bpi.GBP);
            Assert.IsNotNull(CoinDesk.Bpi.EUR);
            

            //Assert.AreEqual("British Poung Sterling", BPI.GBP.description);
           if(CoinDesk.Bpi.GBP.Description== "British Pound Sterling")
           {
                Console.WriteLine("GBP description is Bristish Pound Sterling.");
           }

           else { Console.WriteLine("GBP description is not matching."); }
            


        }
    }
}