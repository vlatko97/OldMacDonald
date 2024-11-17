using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald
{
    internal class Animal
    {
        protected string Name;
        protected string Sound;
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
        public virtual void Sing()
        {
            Console.WriteLine("Old MacDonald had a farm, E I E I O,\n" +
                           "And on his farm, he had a {0}, E I E I O.\n" +
                           "With a {1} {1} here and a {1} {1} there,\n" +
                           "Here a {1}, there a {1}, everywhere a {1} {1}.\n" +
                           "Old MacDonald had a farm, E I E I O.\n", this.Name, this.Sound);
        }
    }
}
