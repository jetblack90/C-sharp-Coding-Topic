using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34._Method_Overriding
{
    internal class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a generic sound.");
        }
    }
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The cat meows.");
        }
    }
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks.");
        }
    }
}
