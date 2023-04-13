using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale, IVolante
    {
        public Aquila(string nome) : base(nome) 
        {       
        }
        public override void Mangia()
        {
            Console.WriteLine("AAAAAaaa clap gnam");
        }
        public override void Verso() 
        {
            Console.WriteLine("Ahaaa Ahaaa");
        }

        public void Vola()
        {
            Console.WriteLine("Fai volare!!!");
        }

    }
}
