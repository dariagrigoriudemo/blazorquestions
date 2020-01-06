using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuestionsClient {
    public class QuestionsFunctionsClient {
        public HttpClient Client { get; private set; }
        public QuestionsFunctionsClient() {

        }
    }
}
