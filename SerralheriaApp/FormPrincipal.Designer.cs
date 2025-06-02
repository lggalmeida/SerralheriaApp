namespace SerralheriaApp {
    partial class FormPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCargos = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.lstFuncionarios = new System.Windows.Forms.ListBox();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargos
            // 
            this.btnCargos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.Location = new System.Drawing.Point(12, 12);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(176, 78);
            this.btnCargos.TabIndex = 0;
            this.btnCargos.Text = "Cadastrar Cargos";
            this.btnCargos.UseVisualStyleBackColor = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.Location = new System.Drawing.Point(194, 12);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(176, 78);
            this.btnFuncionarios.TabIndex = 1;
            this.btnFuncionarios.Text = "Cadastrar Funcionário";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // lstFuncionarios
            // 
            this.lstFuncionarios.FormattingEnabled = true;
            this.lstFuncionarios.Location = new System.Drawing.Point(12, 139);
            this.lstFuncionarios.Name = "lstFuncionarios";
            this.lstFuncionarios.Size = new System.Drawing.Size(670, 342);
            this.lstFuncionarios.TabIndex = 2;
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarios.Location = new System.Drawing.Point(12, 118);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(110, 18);
            this.lblFuncionarios.TabIndex = 3;
            this.lblFuncionarios.Text = "Funcionários";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(694, 499);
            this.Controls.Add(this.lblFuncionarios);
            this.Controls.Add(this.lstFuncionarios);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnCargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargos;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.ListBox lstFuncionarios;
        private System.Windows.Forms.Label lblFuncionarios;
    }
}