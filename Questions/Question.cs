using C__Exam.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace C__Exam.Questions
{
    internal abstract class Question
    {
        public string QuestionHeader { get; set; }

        public string QuestionBody { get; set; }

        public int QuestionMarks { get; set; }

        public int QuestionID { get; set; }

        public Answer[] AnswerList { get; set; }
        public int RightAnswer { get; set; }
        public int UserAnswer { get; set; }

        public static int TotalMarks { get; set; } = 0;

        public static int FinalTotalMarks { get; set; } = 0;


        public Question() { }



        public abstract void InitializeQuestionAnswers(Answer[] an);

        public abstract void StartCreatingQuestion(int number);






    }
}
