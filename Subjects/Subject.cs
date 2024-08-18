using C__Exam.Answers;
using C__Exam.Exams;
using C__Exam.Questions;
using C__Exam.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam.Subjects
{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }

        public int ExamNumber { get; set; }

        public Exam[] ex { get; set; } = { new PracticalExam(), new FinalExam() };

        public Exam SubjectExam { get; set; }

        public Subject() { }
        public Subject(int SubjectID, string SubjectName)
        {
            this.SubjectID = SubjectID;
            this.SubjectName = SubjectName;

        }

        public void StartProcess()
        {
            SubjectID = Validator.IntegerInputValidation("Enter Your Subject ID!");

            SubjectName = Validator.StringInputValidation("Enter Your Subject Name!");



            

            Console.Clear();
            Console.WriteLine(SubjectID + " - " + SubjectName);

            InitializeExam();


        }
        public  void InitializeExam()
        {


             ExamNumber = Validator.IntegerInputValidation("Enter Your Exam Number (1 for Practical | 2 for Final) !", 1, 2);

            SubjectExam = ex[ExamNumber - 1];

            SubjectExam.TimeOfExam = Validator.IntegerInputValidation("Enter Your Exam Duration (From 30 minutes to 180 minutes) !", 30, 180);

            SubjectExam.NumberOfQuestions = Validator.IntegerInputValidation("Enter Your No. of Questions!", 1);
            Console.Clear();
            Console.WriteLine(SubjectID + " - " + SubjectName + " - " + SubjectExam.Exam_Name);
            SubjectExam.InitializeQuestions();
            StartSolvingExam();




        }

        public void StartSolvingExam()
        {
            int Decision = Validator.IntegerInputValidation("Would You like to Start The exam? ( 1 for yes | 2 for no ) !", 1, 2);
            Stopwatch sw = new Stopwatch();
            switch (Decision)
            {
                case 1:
                    sw.Start();
                    Console.WriteLine(SubjectID + " - " + SubjectName + " - " + SubjectExam.Exam_Name);
                    
                    for (int i = 0; i < SubjectExam.QuestionArr.Length; i++)
                    {
                        int limit;
                        if (SubjectExam.QuestionArr[i].QuestionID == 1)
                        {
                            limit = 4;
                        }
                        else
                        {
                            limit = 2;
                        }
                        Console.WriteLine($"Question {i + 1}: {SubjectExam.QuestionArr[i].QuestionBody} ({SubjectExam.QuestionArr[i].QuestionHeader})");
                        Answer[] an = SubjectExam.QuestionArr[i].AnswerList;
                        for (int j = 0; j < an.Length; j++)
                        {
                            Console.WriteLine($"{an[j].ID}. {an[j].AnswerText}");
                        }
                        int User_Answer_ID = Validator.IntegerInputValidation("Enter your answer ID for the Question!", 1, limit);
                        SubjectExam.QuestionArr[i].UserAnswer = User_Answer_ID;
                        if (SubjectExam.QuestionArr[i].RightAnswer == SubjectExam.QuestionArr[i].UserAnswer)
                        {
                            Question.TotalMarks += SubjectExam.QuestionArr[i].QuestionMarks;
                        }
                    }
                    sw.Stop();
                    Console.Clear();
                    Console.WriteLine(SubjectID + " - " + SubjectName + " - " + SubjectExam.Exam_Name);
                    if (SubjectExam.ExamID == 1)
                    {

                        Console.WriteLine("Right Answers of your Practical Exam!");
                        for (int i = 0; i < SubjectExam.QuestionArr.Length; i++)
                        {
                            Console.WriteLine("Question " + (i + 1) + ". " + SubjectExam.QuestionArr[i].AnswerList[SubjectExam.QuestionArr[i].RightAnswer - 1].AnswerText);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Status of your Final Exam!");
                        for (int i = 0; i < SubjectExam.QuestionArr.Length; i++)
                        {
                            Console.WriteLine($"Question {i + 1}: {SubjectExam.QuestionArr[i].QuestionBody} ({SubjectExam.QuestionArr[i].QuestionHeader})");
                            Console.WriteLine($"Right Answer => {SubjectExam.QuestionArr[i].AnswerList[SubjectExam.QuestionArr[i].RightAnswer - 1].AnswerText}");
                            Console.WriteLine($"Your Answer => {SubjectExam.QuestionArr[i].AnswerList[SubjectExam.QuestionArr[i].UserAnswer - 1].AnswerText}");

                        }


                    }
                    Console.WriteLine($"Your Grade is {Question.TotalMarks}/{Question.FinalTotalMarks}");
                    Console.WriteLine($"Your Time taken to finish the exam {sw.ToString()}");
                    Console.WriteLine("End of Exam Status!");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("End of Process!");
                    break;
            }

        }



    }

}
