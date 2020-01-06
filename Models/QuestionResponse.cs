using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionsClient.Models
{
    public class QuestionResponse
    {
        public string AnswerText { get; set; }

        public Guid Ref { get; } = Guid.NewGuid();
    }
}
