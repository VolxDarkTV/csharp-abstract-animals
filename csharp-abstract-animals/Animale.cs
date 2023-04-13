using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal abstract class Animale
    {
        public string Name { get; set; }

        public abstract void Verso();
        public abstract void Mangia();
        public void Dormi()
        {
            Console.WriteLine("zzzzz");
        }

        protected Animale(string nome) 
        {
            Name = nome;
        }
    }

   
}
