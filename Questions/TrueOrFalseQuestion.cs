using C__Exam.Answers;
using C__Exam.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__Exam.Questions
{
    internal class TrueOrFalseQuestion : Question
    {



        public TrueOrFalseQuestion()

        {

            this.QuestionHeader = "TrueOrFalse Question";
            this.QuestionID = 2;


        }





        public override void InitializeQuestionAnswers(Answer[] an)
        {


            this.AnswerList = an;

        }

        public override void StartCreatingQuestion(int qNumber)
        {
            Console.WriteLine("\n" + QuestionHeader);

            QuestionBody = Validator.StringInputValidation($"Enter Your Question Body for question {qNumber}!");
            Answer[] an = { new Answer(1, "True"), new Answer(2, "False") };
            QuestionMarks = Validator.IntegerInputValidation("Enter the Mark of The Question!", 1);
            FinalTotalMarks += QuestionMarks;


            RightAnswer = Validator.IntegerInputValidation("Enter The Right Answer ID", 1, 2);

            
            InitializeQuestionAnswers(an);
        }
    }
}
