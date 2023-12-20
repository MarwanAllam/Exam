using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQ : Question
    {


        public MCQ()
        {

            Console.Write("Enter Your Question: ");
            Body = Console.ReadLine();

            int X;
            bool flag;
            do
            {
                Console.Write("Enter The Grade of the Question: ");
                flag = int.TryParse(Console.ReadLine(), out X);

                if (flag == false)
                {
                    Console.WriteLine("Please Enter Valid Number");
                }
                Mark = X;
            }
            while (!flag);

            Answers = new Answers[3];
            Answer = new Answers();
            Console.WriteLine();
        }

        public override void SetAnswer()
        {
            for (int i = 0; i < Answers.Length; i++)
            {

                Console.Write($"Answer no{i + 1}:  ");
                Answers[i] = new Answers()
                {

                    AnswerId = i + 1,
                    AnswerText = Console.ReadLine()

                };


            }


            int Type;
            bool flag;
            do
            {
                Console.Write("correct Answer: ");
                flag = int.TryParse(Console.ReadLine(), out Type);
                if (Type == 1 || Type == 2 || Type == 3)
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
            Answer.AnswerId = Type;

        }



    }


}

