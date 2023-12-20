using Exam02;
using System.Diagnostics;
using System;

namespace Exam02
{
    internal class Program
    {

        static void Main(string[] args)
        {



            Subject sub1 = new Subject(10, "C#");

            sub1.CreateExam();
            Console.Clear();


            bool isValidInput = false;
            char UserInput;
            while (!isValidInput)
            {
                Console.WriteLine("Do You Want To Start The Exam (y / n):");

                bool userInput = char.TryParse(Console.ReadLine(), out UserInput);

                if (UserInput == 'y')
                {
                    Console.Clear();
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    sub1.Exam.ShowExam();
                    sw.Stop();
                    TimeSpan elapsedTime = sw.Elapsed;
                    Console.WriteLine("Elapsed time: " + elapsedTime);

                    isValidInput = true;
                }
                else if (UserInput == 'n')
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input.\n");
                }
            }







        }

    }
}
