using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Passerotto : Animale, IVolante
    {
        public Passerotto(string nome) : base(nome)
        {
        }

        public override void Mangia()
        {
            Console.WriteLine("t t t t");
        }

        public override void Verso()
        {
            Console.WriteLine("CipCip");
        }

        public void Vola()
        {
            Console.WriteLine("Voloooo!");
        }
    }
}
