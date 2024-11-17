using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldMacDonald.Animals
{
    internal class Cow : Animal
    {
        public Cow(string Name = "cow", string Sound = "moo") : base(Name, Sound)
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
