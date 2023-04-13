using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino : Animale, INuotante
    {
        public Delfino (string name) : base (name) 
        {
        }

        public override void Mangia()
        {
            Console.WriteLine("glu gnam");
        }

        public override void Verso()
        {
            Console.WriteLine("ih ih iiii ih ih iiii ih");
        }

        public string FaiNuotare()
        {
            return "Nuotooo!";
        }
    }
}
