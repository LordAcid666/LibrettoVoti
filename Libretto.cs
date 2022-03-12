using System.Collections;
using System.Collections.Generic;

namespace LibrettoVoti
{
    public class Libretto
    {
        private List<Voto> voti;

        public Libretto()
        {
            this.voti = new List<Voto>();
        }

        public void add(Voto v)
        {
            this.voti.Add(v);
        }

        //per trovare i voti da stampare
        public Libretto filtraPunti(int punti)
        {
            Libretto result = new Libretto();
            foreach (Voto v in this.voti)
            {
                if (v.getPunti() == punti)
                    result.add(v);
            }
            return result;
        }

        // override toString
        public override string ToString()
        {
            return this.voti.ToString();
        }
    }
}