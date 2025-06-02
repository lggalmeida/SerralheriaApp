using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SerralheriaApp {
    public partial class FormLogin : Form {
        private List<Administrador> administradores;

        public FormLogin(List<Administrador> administradores) {
            InitializeComponent();
            this.administradores = administradores;
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            foreach (var adm in administradores) {
                if (adm.Autenticar(usuario, senha)) {
                    MessageBox.Show("Login realizado com sucesso!");

                    // Abre a tela principal e fecha a de login
                    var formPrincipal = new FormPrincipal();
                    formPrincipal.Show();
                    this.Hide(); // esconde a tela de login (poderia usar this.Close() também)
                    return;
                }
            }

            MessageBox.Show("Usuário ou senha inválidos.");
        }

    }
}
