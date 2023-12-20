using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {

        public FinalExam(int _Time, int _NoOfQuestions) : base(_Time, _NoOfQuestions)
        {
            Questions = new Question[NoOfQuestions];

        }

        public override void ShowExam()
        {
            int X;
            int totalGrade = 0;
            bool flag;

            for (int i = 0; i < NoOfQuestions; i++)
            {
                Console.WriteLine($"\nQuestion no({i + 1}): {Questions[i].Body}    Mark({Questions[i].Mark})\n");
                for (int j = 0; j < Questions[i].Answers.Length; j++)
                {
                    Console.WriteLine($"{j + 1}: {Questions[i].Answers[j].AnswerText}");
                }
                do
                {
                    Console.Write("\nEnter Your Answer: ");
                    flag = int.TryParse(Console.ReadLine(), out X);
                    if (X == 1 || X == 2 || X == 3)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                    if (flag == false)
                    {
                        Console.WriteLine("Please Enter Valid Answer");
                    }
                }
                while (!flag);

                if (X == Questions[i].Answer.AnswerId)
                {
                    totalGrade += Questions[i].Mark;
                }
            }
            
            Console.Clear();
            for (int i = 0; i < NoOfQuestions; i++)
            {
                Console.WriteLine($"Question number({i + 1}): {Questions[i].Body}");

                for (int j = 0; j < Questions[i].Answers.Length; j++)
                {
                    if (Questions[i].Answers[j].AnswerId == Questions[i].Answer.AnswerId)
                    {
                        Console.WriteLine($"The correct answer to this question is: {Questions[i].Answers[j].AnswerText}");
                    }
                }
            }

            Console.WriteLine($"\nYour Grade: {totalGrade}");
        }

        public override void SetQuestion()
        {
            for (int i = 0; i < NoOfQuestions; i++)
            {
                Console.Clear();

                int type;
                bool flag;
                do
                {
                    Console.WriteLine("Enter the type of exam (1 - MCQ, 2 - True or False)");
                    flag = int.TryParse(Console.ReadLine(), out type);
                    if (type == 1 || type == 2)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                    if (flag == false)
                    {
                        Console.WriteLine("Please Enter Valid Exam no");
                    }
                }
                while (!flag);

                Console.Clear();
                if (type == 1)
                {


                    Console.WriteLine("---------- MCQ -----------");
                    MCQ mCQ = new MCQ();
                    Questions[i] = mCQ;



                }
                else if (type == 2)
                {
                    Console.WriteLine("---------- True or false -----------");
                    TrueOrFalse trueOrFalse = new TrueOrFalse();
                    Questions[i] = trueOrFalse;

                }
                Questions[i].SetAnswer();
            }



        }
    }
}





