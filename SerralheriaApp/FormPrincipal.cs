using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SerralheriaApp {
    public partial class FormPrincipal : Form {
        private List<Cargo> cargos = new List<Cargo>();
        public List<Funcionario> funcionarios = new List<Funcionario>();


        public FormPrincipal() {
            InitializeComponent();
        }

        private void btnCargos_Click(object sender, EventArgs e) {
            var formCargo = new FormCadastroCargo(cargos);
            formCargo.ShowDialog(); // Espera a janela fechar
        }

        private void btnFuncionarios_Click(object sender, EventArgs e) {
            if (cargos.Count == 0) {
                MessageBox.Show("Cadastre pelo menos um cargo antes de cadastrar funcionários.");
                return;
            }

            var formFuncionario = new FormCadastroFuncionario(cargos, funcionarios);
            formFuncionario.ShowDialog();
            AtualizarListaFuncionarios(); // Atualiza a lista ao retornar

        }
        private void AtualizarListaFuncionarios() {
            lstFuncionarios.Items.Clear();
            foreach (var func in funcionarios) {
                lstFuncionarios.Items.Add(func);
            }
        }
    }
}
