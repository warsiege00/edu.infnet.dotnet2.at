using System;
using System.ComponentModel.DataAnnotations;

public class Funcionario
{
    // Atributos
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres.")]
    public string Nome { get; set; }

    public string Endereco { get; set; }

    public string Telefone { get; set; }

    public string Email { get; set; }

    
    [Display(Name = "Data de Nascimento")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    public int DepartamentoId { get; set; }
    public virtual Departamento Departamento { get; set; }
    public Funcionario(){}

}