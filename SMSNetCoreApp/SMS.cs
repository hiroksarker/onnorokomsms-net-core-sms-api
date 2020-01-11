using RestSharp;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SMSNetCoreApp
{
    //Install-Package RestSharp
    public class SMS
    {
        private static readonly HttpClient client = new HttpClient();
        public static void Main(string[] args)
        {
            //OneToOne (GET - Username & Password)
            One_To_One_Get_Request();

            //OneToMany (GET - Username & Password)
            One_To_Many_Get_Request();

            //Delovery Status (GET)
            Delivery_Status_Get_Request();

            //Get Balance (GET)
            Get_Balance_Get_Request();

            //Number SMS or OneToOne, OneToMany (Post - API Key)
            Number_Sms_Post_Request();

            //Personalized SMS or List SMS (Post - API Key)
            List_Sms_Post_Request();

            //Get Current Balance (Post - API Key)
            Get_Current_Balance_Post_Request();
        }

        //OneToOne (GET)
        public static void One_To_One_Get_Request()
        {
            try
            {
                string fullUrl = Constants.BASE_URL
                    + $"?op=OneToOne&type=TEXT"
                    + $"&mobile={Constants.MOBILE_NO_SINGLE}"
                    + $"&smsText={Constants.SMS_TEXT}"
                    + $"&username={Constants.USERNAME}"
                    + $"&password={Constants.PASSWORD}"
                    + $"&maskName="
                    + $"&campaignName=";

                //Client URL Request
                var client = new RestClient(fullUrl);
                //Request Type
                var request = new RestRequest(Method.GET);
                //Get Response
                IRestResponse response = client.Execute(request);
                Console.Write("OneToOne (GET): " + response.Content);
                Console.ReadKey();

            }
            catch (Exception)
            {
                throw;
            }
        }

        //OneToMany (GET)
        public static void One_To_Many_Get_Request()
        {
            try
            {
                string fullUrl = Constants.BASE_URL
                    + $"?op=OneToOne&apikey={Constants.API_KEY}"
                    + $"&type=TEXT"
                    + $"&mobile={Constants.MOBILE_NO_MULTIPLE}"
                    + $"&smsText={Constants.SMS_TEXT}"
                    + $"&username={Constants.USERNAME}"
                    + $"&password={Constants.PASSWORD}"
                    + $"&maskName="
                    + $"&campaignName=";

                //Client URL Request
                var client = new RestClient(fullUrl);
                //Request Type
                var request = new RestRequest(Method.GET);
                //Get Response
                IRestResponse response = client.Execute(request);
                Console.Write("OneToMany (GET): " + response.Content);
                Console.ReadKey();

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Delivery Status (GET)
        public static void Delivery_Status_Get_Request()
        {
            try
            {
                string fullUrl = Constants.BASE_URL
                    + $"?op=DeliveryStatus"
                    + $"&responseId={Constants.RESPONSE}"
                    + $"&username={Constants.USERNAME}"
                    + $"&password={Constants.PASSWORD}";

                //Client URL Request
                var client = new RestClient(fullUrl);
                //Request Type
                var request = new RestRequest(Method.GET);
                //Get Response
                IRestResponse response = client.Execute(request);
                Console.Write("Devlivery Status (GET): " + response.Content);
                Console.ReadKey();

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Balance (GET)
        public static void Get_Balance_Get_Request()
        {
            try
            {
                string fullUrl = Constants.BASE_URL
                    + $"?op=GetBalance"
                    + $"&username={Constants.USERNAME}"
                    + $"&password={Constants.PASSWORD}";

                //Client URL Request
                var client = new RestClient(fullUrl);
                //Request Type
                var request = new RestRequest(Method.GET);
                //Get Response
                IRestResponse response = client.Execute(request);
                Console.Write("Get Balance (GET): " + response.Content);
                Console.ReadKey();

            }
            catch (Exception)
            {
                throw;
            }
        }

        //NumberSms (POST)
        public static void Number_Sms_Post_Request()
        {
            try
            {
                string fullUrl = Constants.BASE_URL
                    + $"?op=NumberSms&apikey={Constants.API_KEY}"
                    + $"&type=TEXT"
                    //Mobile Number Mutiple Support (Comma Seperated)
                    + $"&mobile={Constants.MOBILE_NO_SINGLE}"
                    + $"&smsText={Constants.SMS_TEXT}"
                    + $"&maskName="
                    + $"&campaignName=";

                //Client URL Request
                var client = new RestClient(fullUrl);
                //Request Type
                var request = new RestRequest(Method.POST);
                //Get Response
                IRestResponse response = client.Execute(request);
                Console.Write("List SMS: " + response.Content);
                Console.ReadKey();

            }
            catch (Exception)
            {
                throw;
            }
        }

        //OneToMany (POST)
        public static void List_Sms_Post_Request()
        {
            try
            {
                string fullUrl = Constants.BASE_URL
                    + $"?op=NumberSms&apikey={Constants.API_KEY}"
                    + $"&type=TEXT"
                    + $"&smsListJson={Constants.SMS_LIST}"
                    + $"&maskName="
                    + $"&campaignName=";

                //Client URL Request
                var client = new RestClient(fullUrl);
                //Request Type
                var request = new RestRequest(Method.POST);
                //Get Response
                IRestResponse response = client.Execute(request);
                Console.Write("List SMS Response: " + response.Content);
                Console.ReadKey();

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Get Current Balance (POST)
        public static void Get_Current_Balance_Post_Request()
        {
            try
            {
                string fullUrl = Constants.BASE_URL
                    + $"?op=GetCurrentBalance&apikey={Constants.API_KEY}";

                //Client URL Request
                var client = new RestClient(fullUrl);
                //Request Type
                var request = new RestRequest(Method.POST);
                //Get Response
                IRestResponse response = client.Execute(request);
                Console.Write("Get Current Balance: " + response.Content);
                Console.ReadKey();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
