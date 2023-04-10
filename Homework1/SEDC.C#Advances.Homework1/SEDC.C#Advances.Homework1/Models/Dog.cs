using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.C_Advances.Homework1.Models
{
    public class Dog : Pet
    {

        public string FavouriteFood { get; set; }

        public override void Info()
        {
            Console.WriteLine($"This is a Dog type: {Type} named {Name} and is {Age} years old!");
        }
    }
}
