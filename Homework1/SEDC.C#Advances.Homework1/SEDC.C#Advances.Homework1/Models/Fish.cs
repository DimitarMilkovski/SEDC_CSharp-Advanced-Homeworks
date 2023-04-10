using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.C_Advances.Homework1.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }


        public override void Info()
        {
            Console.WriteLine($"This is a Fish type: {Type} named {Name} and is {Age} years old!");
        }
    }
}
