using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SCIMClientLibrary
{
    interface IIIQClient
    {
         RestRequest Request(string path, Method method);
         IRestResponse Response(RestRequest request);
         HttpStatusCode Login();
    }
}
