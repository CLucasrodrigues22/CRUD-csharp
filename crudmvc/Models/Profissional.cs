using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crudmvc.Models
{
    [Table("Profissionais")]
    public class Profissional
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [Column("Rg")]
        [Display(Name = "RG")]
        public string? Rg { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        [Column("Salario")]
        [Display(Name = "Salário")]
        public string? Salario { get; set; }
    }
}
