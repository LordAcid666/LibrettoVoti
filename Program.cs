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
            lib.add(new Voto("Informatica", 25));
            lib.add(new Voto("Algebra 1", 25));

            Console.WriteLine(lib);
            Console.WriteLine("Voti pari a 25: ");

            Libretto lib25 = lib.filtraPunti(25);
            Console.WriteLine(lib25);

        }//end_main
    }
}