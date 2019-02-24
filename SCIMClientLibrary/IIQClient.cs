using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;

namespace SCIMClientLibrary
{
    public class IIQClient : IIIQClient
    {
        private readonly JsonDeserializer deserializer;
        private readonly string baseUrl;
        private readonly string username;
        private readonly string password;

        public IIQClient(string username, string password)
        {
            this.baseUrl = new Uri(new Uri(Data.BASE_URL), "scim/v2/").ToString();
            this.username = username;
            this.password = password;
            deserializer = new JsonDeserializer();
        }

        public RestRequest Request(string path, Method method)
        {
            var request = new RestRequest {Method = method, Resource = path, RequestFormat = DataFormat.Json };
            request.AddHeader("Authorization", "Basic "+ Convert.ToBase64String(Encoding.UTF8.GetBytes(
                string.Format("{0}:{1}", username, password))));
            return request;
        }

        public IRestResponse Response(RestRequest request)
        {
            var client = new RestClient(baseUrl);
            var response = client.Execute(request);
            return response;
        }

        //ToDo it seems it doesn't work by using ServiceProviderConfig endpoint 
        public HttpStatusCode Login()
        {
            HttpStatusCode httpStatus = HttpStatusCode.BadRequest;
            var path = string.Format("ResourceTypes");
            var request = Request(path, Method.GET);
            request.AddHeader("ContentType", "application/json");
            var response = Response(request);
            if (response.ErrorException == null)
            {
                httpStatus = response.StatusCode;
            }
            else
            {
                httpStatus = response.StatusCode;
            }
            return httpStatus;
        }

        public void GetUsers(string path)
        {
            var request = Request(path, Method.GET);
            request.AddHeader("ContentType", "application/json");
            var response = Response(request);

            var des = deserializer.Deserialize<IdentityContainer>(response);

        }
    }
}
