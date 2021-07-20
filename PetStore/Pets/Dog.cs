using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dog //implicitly internal
    {
        //Access Modifiers:
        //private: only things in this class can use it-DEFAULT IN A CLASS
        //public: everything can access it
        //internal: anything in this project can access it
        //protected: anything that inherits from me can access it

        //Properties
        //1)access modifier 2)type 3)name {}
        public string Size { get; set; } //auto-property
        public short Weight { get; private set; }
        public string Name { get; set; }

        //constructor or constructor method
        public Dog(string name, short weight, string size)
        {
            Name = name;
            Weight = weight;
            Size = size;
        }
        //Method Signature: 1)access modifier, 2)return type, 3)name, 4)parameters
        //void means not returning anything
        public void Bark()
        {
            Console.WriteLine($"{Name} barks noisily.");
        }

        //parameters are camelCase
        public void Eat(string typeOfFood)
        {
            //if (string.Equals(typeOfFood, "healthy food", StringComparison.OrdinalIgnoreCase)) OR
            if (typeOfFood.ToLower() == "healthy food")
            {
                Weight -= 1;
            }

            Console.WriteLine($"{Name} just ate {typeOfFood}. {Name} weighs {Weight}");
        }
    }
}
