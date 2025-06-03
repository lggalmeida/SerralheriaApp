using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SerralheriaApp {

    public partial class FormCadastroFuncionario : Form {
        
        private List<Cargo> cargosDisponiveis;
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public FormCadastroFuncionario(List<Cargo> cargos, List<Funcionario> funcionariosRef) {
            InitializeComponent();
            cargosDisponiveis = cargos;
            funcionarios = funcionariosRef; // Referência compartilhada
        }

        private void FormCadastroFuncionario_Load(object sender, EventArgs e) {
            cmbCargo.DataSource = cargosDisponiveis;
            cmbCargo.DisplayMember = "Nome";
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            string nome = txtNome.Text.Trim();
            string cpf = txtCPF.Text.Trim();
            Cargo cargoSelecionado = (Cargo)cmbCargo.SelectedItem;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || cargoSelecionado == null) {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            Funcionario funcionario = new Funcionario {
                Nome = nome,
                Cpf = cpf,
                Cargo = cargoSelecionado
            };

            funcionarios.Add(funcionario);

            txtNome.Clear();
            txtCPF.Clear();
            txtNome.Focus();


        }
    }
}
