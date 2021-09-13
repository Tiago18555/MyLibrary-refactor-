
namespace My_Library
{
    partial class F_AddStudent
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_email = new System.Windows.Forms.TextBox();
			this.tb_rm = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_sair = new System.Windows.Forms.Button();
			this.btn_limpar = new System.Windows.Forms.Button();
			this.btn_cadastrar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "CPF:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "E-mail:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(56, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "RM:";
			// 
			// mtb_cpf
			// 
			this.mtb_cpf.Location = new System.Drawing.Point(132, 72);
			this.mtb_cpf.Mask = "999.999.999-99";
			this.mtb_cpf.Name = "mtb_cpf";
			this.mtb_cpf.Size = new System.Drawing.Size(230, 23);
			this.mtb_cpf.TabIndex = 2;
			this.mtb_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtb_cpf_MaskInputRejected);
			this.mtb_cpf.TextChanged += new System.EventHandler(this.mtb_cpf_TextChanged);
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(132, 34);
			this.tb_name.MaxLength = 50;
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(230, 23);
			this.tb_name.TabIndex = 1;
			this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
			// 
			// tb_email
			// 
			this.tb_email.Location = new System.Drawing.Point(132, 108);
			this.tb_email.MaxLength = 50;
			this.tb_email.Name = "tb_email";
			this.tb_email.Size = new System.Drawing.Size(230, 23);
			this.tb_email.TabIndex = 3;
			this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
			// 
			// tb_rm
			// 
			this.tb_rm.Location = new System.Drawing.Point(132, 146);
			this.tb_rm.MaxLength = 10;
			this.tb_rm.Name = "tb_rm";
			this.tb_rm.Size = new System.Drawing.Size(230, 23);
			this.tb_rm.TabIndex = 4;
			this.tb_rm.TextChanged += new System.EventHandler(this.tb_rm_TextChanged);
			this.tb_rm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_rm_KeyPress);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_sair);
			this.panel1.Controls.Add(this.btn_limpar);
			this.panel1.Controls.Add(this.btn_cadastrar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 213);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(436, 47);
			this.panel1.TabIndex = 8;
			// 
			// btn_sair
			// 
			this.btn_sair.Location = new System.Drawing.Point(12, 12);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(100, 23);
			this.btn_sair.TabIndex = 2;
			this.btn_sair.TabStop = false;
			this.btn_sair.Text = "Sair";
			this.btn_sair.UseVisualStyleBackColor = true;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// btn_limpar
			// 
			this.btn_limpar.Location = new System.Drawing.Point(168, 12);
			this.btn_limpar.Name = "btn_limpar";
			this.btn_limpar.Size = new System.Drawing.Size(100, 23);
			this.btn_limpar.TabIndex = 1;
			this.btn_limpar.TabStop = false;
			this.btn_limpar.Text = "Limpar";
			this.btn_limpar.UseVisualStyleBackColor = true;
			this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
			// 
			// btn_cadastrar
			// 
			this.btn_cadastrar.Enabled = false;
			this.btn_cadastrar.Location = new System.Drawing.Point(324, 12);
			this.btn_cadastrar.Name = "btn_cadastrar";
			this.btn_cadastrar.Size = new System.Drawing.Size(100, 23);
			this.btn_cadastrar.TabIndex = 0;
			this.btn_cadastrar.TabStop = false;
			this.btn_cadastrar.Text = "Cadastrar";
			this.btn_cadastrar.UseVisualStyleBackColor = true;
			this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
			// 
			// F_AddStudent
			// 
			this.AcceptButton = this.btn_cadastrar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_sair;
			this.ClientSize = new System.Drawing.Size(436, 260);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tb_rm);
			this.Controls.Add(this.tb_email);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.mtb_cpf);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "F_AddStudent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar aluno";
			this.Load += new System.EventHandler(this.F_AddStudent_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox mtb_cpf;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_email;
		private System.Windows.Forms.TextBox tb_rm;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Button btn_limpar;
		private System.Windows.Forms.Button btn_cadastrar;
	}
}