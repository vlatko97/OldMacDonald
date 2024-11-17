using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Animals
{
    internal class Dog : Animal
    {
        public Dog(string Name = "dog", string Sound = "woof") : base(Name, Sound)
        {
            this.Name = Name;
            this.Sound = Sound;
        }
        public override void Sing()
        {
            base.Sing();
        }
    }
}
