using C__Exam.Answers;
using C__Exam.Questions;
using C__Exam.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Exams
{

    internal class FinalExam : Exam
    {
        public FinalExam()
        {
            this.ExamID = 2;
            this.Exam_Name = "Final Exam";
        }

        public override void InitializeQuestions()
        {

            QuestionArr = new Question[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int Question_ID = Validator.IntegerInputValidation("Enter Your Question Number (1 for MCQ Question | 2 for TrueOrFalse Question) !", 1, 2);
                if (Question_ID == 1)
                {


                    QuestionArr[i] = new MCQQuestion();
                    QuestionArr[i].StartCreatingQuestion(i + 1);
                }

                else
                {
                    QuestionArr[i] = new TrueOrFalseQuestion();
                    QuestionArr[i].StartCreatingQuestion(i + 1);
                }


                Console.Clear();

            }




        }

    }
}

