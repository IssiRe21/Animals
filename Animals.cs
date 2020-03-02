using System;

namespace Anlimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck("With shoes");
            duck.MakeSound();
            Console.WriteLine(duck.GetFullName());
            Console.WriteLine(duck.LastName);
            duck.LastName = "Smith";
            Console.WriteLine(duck.GetFullName());
            Anlimal dog = new Dog("Doggencio");
            Anlimal duck2 = new Duck("McDonald");

            Anlimal[] pets = new Anlimal [2];
            pets [0] = dog;
            pets [1] = duck;
        }
    }
}
