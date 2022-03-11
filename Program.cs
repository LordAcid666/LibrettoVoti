using System;

namespace LibrettoVoti
{
    class Program
    {
        static void Main(string[] args)
        {
            Libretto lib = new Libretto();
            lib.add(new Voto("Analisi 1", 30));
        }
    }
}