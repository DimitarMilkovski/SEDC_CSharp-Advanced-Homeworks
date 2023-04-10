using SEDC.C_Advances.Homework1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.C_Advances.Homework1
{
    public class PetStore<T> where T : Pet
    {
        public PetStore()
        {
            
        }
        private List<T> _list { get; set; } = new List<T>();

        public void PrintPets ()
        {
            foreach (T item in _list)
            {
               item.Info();
            }
        }

        public void BuyPet(string name)
        {
            T pet = _list.FirstOrDefault(x => x.Name == name);
            if (pet != null)
            {
                _list.Remove(pet);
                Console.WriteLine($"Pet was removed from the Pet list");
            }
            else
            {
                Console.WriteLine("Pet was not found, there is no pet by that name!");
            }
        }

        public void Insert (T pet)
        {
            _list.Add(pet);
            Console.WriteLine("A pet was added to the petshop list");
        }

       
    }
}
