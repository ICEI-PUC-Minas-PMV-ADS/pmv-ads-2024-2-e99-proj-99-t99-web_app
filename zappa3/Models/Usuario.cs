using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace zappa3.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }
        public string Numero { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Email")]
        public string Email { get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateOnly DataNascimento { get; set; }
        public string Avatar { get; set; }
        [Display(Name = "Despensa Virtual")]
        public string DespensaVirtual { get; set; }
        [Display(Name = "Histórico Despensa Virtual")]
        public string HistoricoDespensaVirtual { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a senha")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }

    }
}
