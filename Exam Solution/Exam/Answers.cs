using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }


        public Answers()
        {

        }


        public override string ToString()
        {
            return $"Answers: {AnswerId} : {AnswerText}";
        }

    }
}

