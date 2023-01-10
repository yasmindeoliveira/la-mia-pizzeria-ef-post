namespace LaMiaPizzeriaEfPost.Models
{
    public class Pizza
    {
        public string nome { get; set; }
        public string foto { get; set; }
        public string descrizione { get; set; }
        public double prezzo { get; set; }

        public Pizza(string nome, string foto, string descrizione, double prezzo)
        {
            this.nome = nome;
            this.foto = foto;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }
    }
}
