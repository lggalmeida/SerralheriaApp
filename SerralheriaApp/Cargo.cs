namespace SerralheriaApp {
    public class Cargo {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public override string ToString() {
            return $"{Nome} - {Descricao}";
        }
    }
}
