using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Column("id")]
        [Display(Name ="Codigo")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public int Tel { get; set; }
    }
}
