using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Animals
{
    internal class Frog : Animal
    {
        public Frog(string Name = "frog", string Sound = "croak") : base(Name, Sound)
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
