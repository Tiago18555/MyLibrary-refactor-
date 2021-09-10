
namespace My_Library
{
    partial class F_AddPublisher
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
			this.btn_add = new System.Windows.Forms.Button();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
			this.btn_sair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Enabled = false;
			this.btn_add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_add.Location = new System.Drawing.Point(357, 63);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(48, 54);
			this.btn_add.TabIndex = 7;
			this.btn_add.Text = "+";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(92, 63);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(259, 23);
			this.tb_name.TabIndex = 6;
			this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nome: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(413, 38);
			this.label1.TabIndex = 4;
			this.label1.Text = "CADASTRAR EDITORA";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "CNPJ:";
			// 
			// mtb_cnpj
			// 
			this.mtb_cnpj.Location = new System.Drawing.Point(92, 94);
			this.mtb_cnpj.Mask = "99.999.999/9999-99";
			this.mtb_cnpj.Name = "mtb_cnpj";
			this.mtb_cnpj.Size = new System.Drawing.Size(259, 23);
			this.mtb_cnpj.TabIndex = 9;
			this.mtb_cnpj.TextChanged += new System.EventHandler(this.mtb_cnpj_TextChanged);
			// 
			// btn_sair
			// 
			this.btn_sair.Location = new System.Drawing.Point(330, 140);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(75, 23);
			this.btn_sair.TabIndex = 10;
			this.btn_sair.Text = "Sair";
			this.btn_sair.UseVisualStyleBackColor = true;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// F_AddPublisher
			// 
			this.AcceptButton = this.btn_add;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_sair;
			this.ClientSize = new System.Drawing.Size(433, 175);
			this.Controls.Add(this.btn_sair);
			this.Controls.Add(this.mtb_cnpj);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "F_AddPublisher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar editora";
			this.Load += new System.EventHandler(this.F_AddPublisher_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
		private System.Windows.Forms.Button btn_sair;
	}
}