using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Animals
{
    internal class Cat : Animal
    {
        public Cat(string Name = "cat", string Sound = "meow") : base(Name, Sound)
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
