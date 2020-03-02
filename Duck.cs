using System;

namespace Anlimals
{
    class Duck : Anlimal
    {
        public Duck(string lastName)
        {
            this.name = "Duck";
            this.lastName = lastName;
        }


        public override void MakeSound()
        {
            Console.WriteLine($"{this.name} goes Quack!");
        }
    }

}