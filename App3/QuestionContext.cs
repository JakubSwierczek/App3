using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace App3
{
    public class QuestionContext
    {
        private string fileName;
        public List<Question> Questions { get; set; }

        private String[] arrayStrings = new[]
        {"and", "0001", "nand", "1110", "nor", "1000", "not", "10", "or", "0111", "xor", "0110"};

        public QuestionContext()
        {
            Questions = new List<Question>();
            fileName = "Quizies.txt";
            GetQuestionsFromFile();
            
        }

        private void GetQuestionsFromFile()
        {
            var spiltedText = arrayStrings.ToList();
            for (var i = 0; i < spiltedText.Count; i += 2)
            {
                Questions.Add(new Question()
                {
                    LogicalGate = spiltedText[i],
                    RightAnswer = spiltedText[i + 1]
                });
            }

        }
    }
}
