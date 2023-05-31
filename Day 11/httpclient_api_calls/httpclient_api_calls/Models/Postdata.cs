namespace httpclient_api_calls.Models
{
    public class Postdata
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        List<Postdata> data = new List<Postdata>(); // this is where data will come


        public List<Postdata> GetPostDataFromAPI()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpClient client = new HttpClient();

            //we have to set the dataformat for calling environment - jSON
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var call = client.GetAsync(url).Result;

            if (call.IsSuccessStatusCode)
            {
                var result = call.Content.ReadAsAsync<List<Postdata>>();

                result.Wait();

                data = result.Result;

            }
            else
            {
                throw new Exception("Could Not get data, please contact Admin !!");
            }


            return data;
        }


    }
}
