using System;

namespace LibrettoVoti
{
    class Program
    {
        static void Main(string[] args)
        {
            Libretto lib = new Libretto();
            lib.add(new Voto("Analisi 1", 30));
            lib.add(new Voto("Fisica 1", 18));
            Console.WriteLine(lib);
        }
    }
}