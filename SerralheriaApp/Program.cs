using SerralheriaApp;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

static class Program {
    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var admins = new List<Administrador>
        {
            new Administrador
            {
                Nome = "Admin Padrão",
                Cpf = "000.000.000-00",
                Usuario = "admin",
                Senha = "1234"
            }
        };

        Application.Run(new FormLogin(admins));

    }
}
