namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n------------------\n");

            //Istanza CANE
            Cane cane = new Cane("selli");

            Console.WriteLine(cane.Name);
            cane.Dormi();
            cane.Verso();
            cane.Mangia();

            Console.WriteLine("\n------------------\n");

            //Istanza PASSEROTTO
            Passerotto passero = new Passerotto("Picchiarello");

            Console.WriteLine(passero.Name);
            passero.Dormi();
            passero.Verso();
            passero.Mangia();

            Console.WriteLine("\n------------------\n");

            //Istanza AQUILA
            Aquila aquila = new Aquila("Aprilia");

            Console.WriteLine(aquila.Name);
            aquila.Dormi();
            aquila.Verso();
            aquila.Mangia();

            Console.WriteLine("\n------------------\n");

            //Istanza DELFINO
            Delfino delfino = new Delfino("Flipper");

            Console.WriteLine(delfino.Name);
            delfino.Dormi();
            delfino.Verso();
            delfino.Mangia();

            Console.WriteLine("\n------------------\n");

        }
    }
}