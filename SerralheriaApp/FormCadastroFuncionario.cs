using System;
using System.Collections.Generic;
using System.Linq;
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

        private void FormCadastroFuncionario_Load(object sender, EventArgs e)
        {
            clbCargos.DataSource = null;
            clbCargos.DataSource = cargosDisponiveis;
            clbCargos.DisplayMember = "Nome";
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cpf = txtCPF.Text.Trim();
            var cargosSelecionados = clbCargos.CheckedItems.Cast<Cargo>().ToList();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || cargosSelecionados.Count == 0)
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            Funcionario funcionario = new Funcionario
            {
                Nome = nome,
                Cpf = cpf,
                Cargos = cargosSelecionados
            };

            foreach (var cargo in cargosSelecionados)
            {
                cargo.Funcionarios.Add(funcionario);
            }

            funcionarios.Add(funcionario);

            txtNome.Clear();
            txtCPF.Clear();
            txtNome.Focus();
            for (int i = 0; i < clbCargos.Items.Count; i++)
            {
                clbCargos.SetItemChecked(i, false);
            }
        }
    }
}
