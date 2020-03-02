using System;

namespace Anlimals
{
    abstract class Anlimal
    {
        protected string name;
        protected string lastName;
        public string LastName 
        { get => $"Mr. {lastName}"; 
        set => lastName = value; }
        public abstract void MakeSound();
        public string GetFullName()
        {
            return $"{this.name} {this.lastName}";
        }


    }

}