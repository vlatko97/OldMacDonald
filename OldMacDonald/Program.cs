using OldMacDonald.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionOnePolymorphism();
        }

        private static void QuestionOnePolymorphism()
        {
            Console.WriteLine("Question One Polymorphism:");
            Console.WriteLine();
            Animal Cat = new Cat();
            Cat.Sing();
            Animal Cow = new Cow();
            Cow.Sing();
            Animal Dog = new Dog();
            Dog.Sing();
            Animal Frog = new Frog();
            Frog.Sing();
            Animal Pig = new Pig();
            Pig.Sing();
        }
    }
}

