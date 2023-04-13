using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Cane : Animale, INuotante
    {
        public Cane(string nome) : base(nome)
        {
        }


        public override void Mangia()
        {
            Console.WriteLine("Trtrtr Gnam");
        }
        public override void Verso()
        {
            Console.WriteLine("Bau");
        }

        public string FaiNuotare()
        {
            return "Nuotooo!";
        }
    }
}
