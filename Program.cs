using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            string num;
            int temp;

            prompt();

            Console.WriteLine("Please choose a type of animal you want. 1. Dog, 2. Cat. Then hit 'Enter'.");
            type = Console.ReadLine();
            if (int.TryParse(type, out temp)) ;


            Console.ReadLine();
        }

    }
    private 
    interface cage
    {
        string maxCapacity { get; set; }
        bool isAvailable { get; set; }
        bool isDirty { get; set; }
    }
    class catHome : cage
    {
        public string maxCapacity { get; set; }
        public bool isAvailable { get; set; }
        public bool isDirty { get; set; }
    }
    abstract class animal
    {
        string birthDate = string.Empty;
        string gender = string.Empty;
        bool isSleep = false;
        bool isFull = false;
        private void eat()
        {
            isFull = true;
            Console.WriteLine("I am full");
        }
        private void sleep()
        {
            isSleep = true;
            Console.WriteLine("I am sleeping");
        }
        private void play()
        {
            isFull = false;
            Console.WriteLine("I am playing and I got hungry.");
        }
        private void cry()
        {
        }
    }
    class cat : animal
    {
        private void cry()
        {
            Console.WriteLine("Meow~");
        }
    }
    class dog : animal
    {
        private void cry()
        {
            Console.WriteLine("bow wow!");
        }
    }
}
