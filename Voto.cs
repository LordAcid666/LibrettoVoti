namespace LibrettoVoti
{
    public class Voto
    {
        private string nome;
        private int punti;
        
        public Voto(string nome, int punti)
        {
            this.nome = nome;
            this.punti = punti;
        }
        
        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getPunti()
        {
            return punti;
        }

        public void setPunti(int punti)
        {
            this.punti = punti;
        }

        public override string ToString()
        {
            //return $"Nome: {nome}, Punti: {punti}";
            return "Voto [nome:" + nome + ", punti: " + punti + "]";
        }
    }
}