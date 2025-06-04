using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerralheriaApp {
    public partial class FormCadastroCargo : Form {

        private List<Cargo> cargos = new List<Cargo>();

        public FormCadastroCargo(List<Cargo> cargos) {
            InitializeComponent();
            this.cargos = cargos;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            string nome = txtNome.Text.Trim();
            string descricao = txtDescricao.Text.Trim();

            if (string.IsNullOrEmpty(nome)) {
                MessageBox.Show("Por favor, insira o nome do cargo.");
                return;
            }

            Cargo novoCargo = new Cargo {
                Nome = nome,
                Descricao = descricao
            };

            cargos.Add(novoCargo);
            lstCargos.Items.Add(novoCargo);

            txtNome.Clear();
            txtDescricao.Clear();
            txtNome.Focus();
        }

        private void FormCadastroCargo_Load(object sender, EventArgs e) {

        }
    }
}
