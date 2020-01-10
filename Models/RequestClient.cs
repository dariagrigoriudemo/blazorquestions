using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuestionsClient.Models
{
    public static class RequestClient
    {
        private static bool isInitialized = false;
        private static bool use_local = false;

        public static void Initialize(HttpClient Http)
        {
            if (!isInitialized)
            {

                if (use_local)
                {
                    // Local
                    Http.BaseAddress = new Uri("http://localhost:7071");
                }
                else
                {
                    // Azure prod
                    Http.BaseAddress = new Uri("https://questionfunctions.azurewebsites.net");
                }
                isInitialized = true;
            }
        }
    }
}
