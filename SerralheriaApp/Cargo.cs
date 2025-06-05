using System.Collections.Generic;

namespace SerralheriaApp {
    public class Cargo {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();


        public override string ToString() {
            return $"{Nome} - {Descricao}";
        }
    }
}
