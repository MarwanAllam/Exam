using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class PracticalExam : Exam
    {

        public PracticalExam(int _Time, int _NoOfQuestions) : base(_Time, _NoOfQuestions)
        {
            Questions = new Question[NoOfQuestions];

        }

        public override void SetQuestion()
        {
            for (int i = 0; i < NoOfQuestions; i++)
            {

                Console.Clear();
                Console.WriteLine("---------- MCQ -----------");
                MCQ mCQ = new MCQ();
                Questions[i] = mCQ;

                Questions[i].SetAnswer();
            }

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
            
            for (int i = 0; i < NoOfQuestions; i++)
            {
                for (int j = 0; j < Questions[i].Answers.Length; j++)
                {
                    if (Questions[i].Answers[j].AnswerId == Questions[i].Answer.AnswerId)
                    {

                        Console.WriteLine($"\nThe correct answer to question number({j + 1}): {Questions[i].Answers[j].AnswerText}");
                    }
                }
            }
            Console.WriteLine($"\nYour Grade: {totalGrade}");
        }
    }

}



