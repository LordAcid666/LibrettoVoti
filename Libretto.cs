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
    }
}