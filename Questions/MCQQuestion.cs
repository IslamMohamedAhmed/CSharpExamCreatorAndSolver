using C__Exam.Answers;
using C__Exam.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Questions
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion()

        {
            this.QuestionHeader = "MCQ Question";
            this.QuestionID = 1;
        }

        public override void InitializeQuestionAnswers(Answer[] an)
        {


            this.AnswerList = an;

        }

        public override void StartCreatingQuestion(int number)
        {
            Console.WriteLine("\n" + QuestionHeader);
            QuestionBody = Validator.StringInputValidation($"Enter Your Question Body for question {number}!");
            Answer[] an = new Answer[4];
            for (int j = 0; j < 4; j++)
            {
                string Answer_Text = Validator.StringInputValidation($"Enter Answer Number {j + 1}");
                an[j] = new Answer(j + 1, Answer_Text);

            }
            QuestionMarks = Validator.IntegerInputValidation("Enter the Mark of The Question!", 1);
            FinalTotalMarks += QuestionMarks;
             RightAnswer = Validator.IntegerInputValidation("Enter The Right Answer ID", 1, 4);
            InitializeQuestionAnswers(an);
        }
    }
}
