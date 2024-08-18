using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Answers
{
    internal class Answer
    {
        public int ID { get; set; }
        public string AnswerText { get; set; }

        public Answer(int ID, string AnswerText)
        {
            this.ID = ID;
            this.AnswerText = AnswerText;
        }
    }
}
