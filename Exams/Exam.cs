using C__Exam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Exams
{
    internal abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int ExamID { get; set; }
        public string Exam_Name { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] QuestionArr { get; set; }

        public abstract void InitializeQuestions();

        






    }
}
