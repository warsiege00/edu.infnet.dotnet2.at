using System;
using System.Collections.Generic;

public class Departamento
{
    // Atributos
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Local { get; set; }
    public virtual ICollection<Funcionario>? Funcionarios { get; set; }
    public Departamento(){}

}