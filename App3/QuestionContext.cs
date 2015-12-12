using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace App3
{
    public class QuestionContext
    {
        public DbSet<Question> Questions { get; set; }

    }
}
