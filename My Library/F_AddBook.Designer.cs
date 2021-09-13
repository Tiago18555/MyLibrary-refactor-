
namespace My_Library
{
    partial class F_AddBook
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
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_title = new System.Windows.Forms.TextBox();
			this.tb_ibsn = new System.Windows.Forms.TextBox();
			this.cb_author = new System.Windows.Forms.ComboBox();
			this.cb_publisher = new System.Windows.Forms.ComboBox();
			this.nm_qtd = new System.Windows.Forms.NumericUpDown();
			this.chboxPeriodico = new System.Windows.Forms.CheckBox();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_sair = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tb_description = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.nm_qtd)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(76, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastrar livro";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Título:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "IBSN:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Editora:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "Autor:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 15);
			this.label6.TabIndex = 1;
			this.label6.Text = "Descrição:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(30, 275);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 15);
			this.label7.TabIndex = 1;
			this.label7.Text = "Quantidade:";
			// 
			// tb_title
			// 
			this.tb_title.Location = new System.Drawing.Point(109, 87);
			this.tb_title.MaxLength = 75;
			this.tb_title.Name = "tb_title";
			this.tb_title.Size = new System.Drawing.Size(250, 23);
			this.tb_title.TabIndex = 1;
			this.tb_title.TextChanged += new System.EventHandler(this.tb_title_TextChanged);
			// 
			// tb_ibsn
			// 
			this.tb_ibsn.Location = new System.Drawing.Point(109, 117);
			this.tb_ibsn.MaxLength = 15;
			this.tb_ibsn.Name = "tb_ibsn";
			this.tb_ibsn.Size = new System.Drawing.Size(250, 23);
			this.tb_ibsn.TabIndex = 2;
			this.tb_ibsn.TextChanged += new System.EventHandler(this.tb_ibsn_TextChanged);
			this.tb_ibsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ibsn_KeyPress);
			// 
			// cb_author
			// 
			this.cb_author.FormattingEnabled = true;
			this.cb_author.Location = new System.Drawing.Point(109, 147);
			this.cb_author.Name = "cb_author";
			this.cb_author.Size = new System.Drawing.Size(250, 23);
			this.cb_author.TabIndex = 3;
			this.cb_author.SelectedIndexChanged += new System.EventHandler(this.cb_author_SelectedIndexChanged);
			this.cb_author.TextChanged += new System.EventHandler(this.cb_author_TextChanged);
			// 
			// cb_publisher
			// 
			this.cb_publisher.FormattingEnabled = true;
			this.cb_publisher.Location = new System.Drawing.Point(109, 177);
			this.cb_publisher.Name = "cb_publisher";
			this.cb_publisher.Size = new System.Drawing.Size(250, 23);
			this.cb_publisher.TabIndex = 4;
			this.cb_publisher.SelectedIndexChanged += new System.EventHandler(this.cb_publisher_SelectedIndexChanged);
			this.cb_publisher.TextChanged += new System.EventHandler(this.cb_publisher_TextChanged);
			// 
			// nm_qtd
			// 
			this.nm_qtd.Location = new System.Drawing.Point(110, 273);
			this.nm_qtd.Name = "nm_qtd";
			this.nm_qtd.Size = new System.Drawing.Size(56, 23);
			this.nm_qtd.TabIndex = 6;
			this.nm_qtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nm_qtd.ValueChanged += new System.EventHandler(this.nm_qtd_ValueChanged);
			// 
			// chboxPeriodico
			// 
			this.chboxPeriodico.AutoSize = true;
			this.chboxPeriodico.Location = new System.Drawing.Point(278, 277);
			this.chboxPeriodico.Name = "chboxPeriodico";
			this.chboxPeriodico.Size = new System.Drawing.Size(81, 19);
			this.chboxPeriodico.TabIndex = 7;
			this.chboxPeriodico.Text = "Periódico?";
			this.chboxPeriodico.UseVisualStyleBackColor = true;
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(170, 9);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(75, 23);
			this.btn_clear.TabIndex = 9;
			this.btn_clear.TabStop = false;
			this.btn_clear.Text = "Limpar";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(330, 9);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 23);
			this.btn_add.TabIndex = 10;
			this.btn_add.TabStop = false;
			this.btn_add.Text = "Cadastrar";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_sair
			// 
			this.btn_sair.Location = new System.Drawing.Point(12, 9);
			this.btn_sair.Name = "btn_sair";
			this.btn_sair.Size = new System.Drawing.Size(75, 23);
			this.btn_sair.TabIndex = 8;
			this.btn_sair.TabStop = false;
			this.btn_sair.Text = "Sair";
			this.btn_sair.UseVisualStyleBackColor = true;
			this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_add);
			this.panel1.Controls.Add(this.btn_clear);
			this.panel1.Controls.Add(this.btn_sair);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 353);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(417, 40);
			this.panel1.TabIndex = 14;
			// 
			// tb_description
			// 
			this.tb_description.Location = new System.Drawing.Point(109, 210);
			this.tb_description.MaxLength = 250;
			this.tb_description.Name = "tb_description";
			this.tb_description.Size = new System.Drawing.Size(250, 57);
			this.tb_description.TabIndex = 5;
			this.tb_description.Text = "";
			this.tb_description.TextChanged += new System.EventHandler(this.tb_description_TextChanged);
			// 
			// F_AddBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 393);
			this.Controls.Add(this.tb_description);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.chboxPeriodico);
			this.Controls.Add(this.nm_qtd);
			this.Controls.Add(this.cb_publisher);
			this.Controls.Add(this.cb_author);
			this.Controls.Add(this.tb_ibsn);
			this.Controls.Add(this.tb_title);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "F_AddBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar livro ou periódico";
			this.Load += new System.EventHandler(this.F_AddBook_Load);
			((System.ComponentModel.ISupportInitialize)(this.nm_qtd)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_title;
		private System.Windows.Forms.TextBox tb_ibsn;
		private System.Windows.Forms.ComboBox cb_author;
		private System.Windows.Forms.ComboBox cb_publisher;
		private System.Windows.Forms.NumericUpDown nm_qtd;
		private System.Windows.Forms.CheckBox chboxPeriodico;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox tb_description;
	}
}