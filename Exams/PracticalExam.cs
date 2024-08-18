using C__Exam.Answers;
using C__Exam.Questions;
using C__Exam.Subjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam()
        {
            this.ExamID = 1;
            this.Exam_Name = "Practical Exam";
        }

        public override void InitializeQuestions()
        {
            QuestionArr = new Question[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                
               
                QuestionArr[i] = new TrueOrFalseQuestion(); // Binding
                QuestionArr[i].StartCreatingQuestion(i + 1);
                Console.Clear();
            }
           
            
        }


        
    }
}
