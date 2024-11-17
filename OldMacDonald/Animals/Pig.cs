using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Animals
{
    internal class Pig : Animal
    {
        public Pig(string Name = "pig", string Sound = "oink") : base(Name, Sound)
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
