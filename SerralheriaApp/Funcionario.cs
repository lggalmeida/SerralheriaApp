using SerralheriaApp;
using System.Collections.Generic;
using System.Linq;

public class Funcionario : Pessoa {
    public Cargo Cargo { get; set; }

    public override string ToString() {
        return $"{Nome} ({Cpf}) - Cargo: {Cargo}";
    }
}
