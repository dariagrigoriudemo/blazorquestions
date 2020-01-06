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
        private static bool use_local = true;
        private static bool use_test_function = true;

        public static void Initialize(HttpClient Http)
        {
            if (!isInitialized)
            {

                if (use_local)
                {
                    // local
                    Http.BaseAddress = new Uri("http://localhost:7071");
                }
                else
                {
                    // remote prod
                    // Http.BaseAddress = new Uri("https://www.theQuestions.com/api");
                    // remote test deployment
                    Http.BaseAddress = new Uri("https://Questionsapi.azure-api.net/");
                }
                isInitialized = true;
            }
        }
    }
}
