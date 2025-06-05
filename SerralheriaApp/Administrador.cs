using SerralheriaApp;
using System.Collections.Generic;

public class Administrador : Pessoa, IAutenticavel {
    public string Usuario { get; set; }
    public string Senha { get; set; }
    public List<Funcionario> FuncionariosAdministrados { get; set; } = new List<Funcionario>();

    public bool Autenticar(string usuario, string senha) {
        return this.Usuario == usuario && this.Senha == senha;
    }

    public override string ToString() {
        return $"Administrador: {Nome}";
    }
}
