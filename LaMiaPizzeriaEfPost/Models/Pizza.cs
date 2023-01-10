using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaMiaPizzeriaEfPost.Models
{
    public class Pizza
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string nome { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string foto { get; set; }

        [Column(TypeName = "text")]
        public string descrizione { get; set; }
        public double prezzo { get; set; }

        public Pizza()
        {

        }
        public Pizza(string nome, string foto, string descrizione, double prezzo)
        {
            this.nome = nome;
            this.foto = foto;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
        }
    }
}
