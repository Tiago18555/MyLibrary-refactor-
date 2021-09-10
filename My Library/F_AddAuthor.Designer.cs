
namespace My_Library
{
    partial class F_AddAuthor
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
			this.tb_name = new System.Windows.Forms.TextBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_sair = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(18, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(373, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "CADASTRAR AUTOR";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome: ";
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(82, 79);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(259, 23);
			this.tb_name.TabIndex = 2;
			this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
			// 
			// btn_add
			// 
			this.btn_add.Enabled = false;
			this.btn_add.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_add.Location = new System.Drawing.Point(347, 72);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(33, 33);
			this.btn_add.TabIndex = 3;
			this.btn_add.Text = "+";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_sair
			// 
			this.btn_sair.Location = new System.Drawing.Point(304, 131);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(75, 23);
			this.btn_sair.TabIndex = 4;
			this.btn_sair.Text = "Sair";
			this.btn_sair.UseVisualStyleBackColor = true;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// F_AddAuthor
			// 
			this.AcceptButton = this.btn_add;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_sair;
			this.ClientSize = new System.Drawing.Size(403, 166);
			this.Controls.Add(this.btn_sair);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "F_AddAuthor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar autor";
			this.Load += new System.EventHandler(this.F_AddAuthor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_sair;
	}
}