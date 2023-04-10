using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.C_Advances.Homework1.Models
{
    public class Cat : Pet
    {

        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public override void Info()
        {
            Console.WriteLine($"This is a Cat type: {Type} named {Name} and is {Age} years old!");
        }
    }
}
