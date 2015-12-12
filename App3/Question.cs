using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public Answer RightAnswer { get; set; }

        public enum Answer
        {
            A,
            B,
            C,
            D
        };
    }
}
