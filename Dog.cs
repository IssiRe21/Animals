using System;

namespace Anlimals
{
    class Dog : Anlimal
    {
        public Dog(string lastName)
        {
            this.name = "Dog";
            this.lastName = lastName;
        }


        public override void MakeSound()
        {
            Console.WriteLine($"{this.name} goes Guau!");
        }
    }

}