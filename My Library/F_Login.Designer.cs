
namespace My_Library
{
    partial class F_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btn_login = new System.Windows.Forms.Button();
			this.tb_cpf = new System.Windows.Forms.TextBox();
			this.tb_senha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_criar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.Enabled = false;
			this.btn_login.Location = new System.Drawing.Point(42, 223);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(109, 40);
			this.btn_login.TabIndex = 0;
			this.btn_login.Text = "LOGIN";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// tb_cpf
			// 
			this.tb_cpf.Location = new System.Drawing.Point(12, 61);
			this.tb_cpf.MaxLength = 20;
			this.tb_cpf.Name = "tb_cpf";
			this.tb_cpf.Size = new System.Drawing.Size(165, 23);
			this.tb_cpf.TabIndex = 1;
			this.tb_cpf.Text = "48585869879";
			this.tb_cpf.TextChanged += new System.EventHandler(this.tb_cpf_TextChanged);
			// 
			// tb_senha
			// 
			this.tb_senha.Location = new System.Drawing.Point(12, 121);
			this.tb_senha.MaxLength = 20;
			this.tb_senha.Name = "tb_senha";
			this.tb_senha.PasswordChar = '*';
			this.tb_senha.Size = new System.Drawing.Size(165, 23);
			this.tb_senha.TabIndex = 2;
			this.tb_senha.Text = "tiago18555";
			this.tb_senha.TextChanged += new System.EventHandler(this.tb_senha_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "CPF:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "SENHA:";
			// 
			// btn_criar
			// 
			this.btn_criar.Location = new System.Drawing.Point(44, 164);
			this.btn_criar.Name = "btn_criar";
			this.btn_criar.Size = new System.Drawing.Size(107, 43);
			this.btn_criar.TabIndex = 5;
			this.btn_criar.Text = "CRIAR";
			this.btn_criar.UseVisualStyleBackColor = true;
			this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
			// 
			// F_Login
			// 
			this.AcceptButton = this.btn_login;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(191, 292);
			this.Controls.Add(this.btn_criar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_senha);
			this.Controls.Add(this.tb_cpf);
			this.Controls.Add(this.btn_login);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "F_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN";
			this.Load += new System.EventHandler(this.F_Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_criar;
    }
}