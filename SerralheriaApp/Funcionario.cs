using SerralheriaApp;
using System.Collections.Generic;
using System.Linq;

public class Funcionario : Pessoa {
    public List<Cargo> Cargos { get; set; } = new List<Cargo>();
    public Administrador Responsavel { get; set; }

    public override string ToString()
    {
        string nomesCargos = string.Join(", ", Cargos.Select(c => c.Nome));
        return $"{Nome} ({Cpf}) - Cargos: {nomesCargos}";
    }

}
