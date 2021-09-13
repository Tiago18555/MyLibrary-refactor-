
namespace My_Library
{
    partial class F_SearchStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Loans = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rm = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_setCpf = new System.Windows.Forms.Button();
            this.btn_setEmail = new System.Windows.Forms.Button();
            this.btn_setName = new System.Windows.Forms.Button();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_loadLoans = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_tombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_loanValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_clearLoan = new System.Windows.Forms.Button();
            this.btn_newLoan = new System.Windows.Forms.Button();
            this.tb_deadLine = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_books = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_loan = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_returnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Loans
            // 
            this.dgv_Loans.AllowUserToAddRows = false;
            this.dgv_Loans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Loans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Loans.ColumnHeadersHeight = 50;
            this.dgv_Loans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Loans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.ibsn,
            this.tombo,
            this.start,
            this.end,
            this.delay,
            this.value});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Loans.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Loans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Loans.Location = new System.Drawing.Point(3, 22);
            this.dgv_Loans.Name = "dgv_Loans";
            this.dgv_Loans.ReadOnly = true;
            this.dgv_Loans.RowHeadersVisible = false;
            this.dgv_Loans.RowTemplate.Height = 25;
            this.dgv_Loans.RowTemplate.ReadOnly = true;
            this.dgv_Loans.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Loans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Loans.Size = new System.Drawing.Size(1014, 464);
            this.dgv_Loans.TabIndex = 0;
            this.dgv_Loans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Loans_CellContentClick);
            this.dgv_Loans.SelectionChanged += new System.EventHandler(this.dgv_Loans_SelectionChanged);
            // 
            // title
            // 
            this.title.HeaderText = "Título";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 250;
            // 
            // ibsn
            // 
            this.ibsn.HeaderText = "IBSN";
            this.ibsn.Name = "ibsn";
            this.ibsn.ReadOnly = true;
            // 
            // tombo
            // 
            this.tombo.HeaderText = "Tombo";
            this.tombo.Name = "tombo";
            this.tombo.ReadOnly = true;
            // 
            // start
            // 
            this.start.HeaderText = "Data do empréstimo";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            this.start.Width = 167;
            // 
            // end
            // 
            this.end.HeaderText = "Data Limite";
            this.end.Name = "end";
            this.end.ReadOnly = true;
            this.end.Width = 167;
            // 
            // delay
            // 
            this.delay.HeaderText = "Atraso";
            this.delay.Name = "delay";
            this.delay.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "Valor da multa";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Width = 126;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Loans);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(467, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 489);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico de emprestimos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "RM:";
            // 
            // tb_rm
            // 
            this.tb_rm.Location = new System.Drawing.Point(71, 31);
            this.tb_rm.Name = "tb_rm";
            this.tb_rm.Size = new System.Drawing.Size(332, 23);
            this.tb_rm.TabIndex = 1;
            this.tb_rm.TextChanged += new System.EventHandler(this.tb_rm_TextChanged);
            this.tb_rm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_rm_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_setCpf);
            this.groupBox2.Controls.Add(this.btn_setEmail);
            this.groupBox2.Controls.Add(this.btn_setName);
            this.groupBox2.Controls.Add(this.mtb_cpf);
            this.groupBox2.Controls.Add(this.tb_email);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFO";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(224, 146);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(199, 32);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.TabStop = false;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(20, 146);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(197, 32);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.TabStop = false;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_setCpf
            // 
            this.btn_setCpf.Enabled = false;
            this.btn_setCpf.Location = new System.Drawing.Point(349, 107);
            this.btn_setCpf.Name = "btn_setCpf";
            this.btn_setCpf.Size = new System.Drawing.Size(75, 23);
            this.btn_setCpf.TabIndex = 8;
            this.btn_setCpf.TabStop = false;
            this.btn_setCpf.Text = "Alterar";
            this.btn_setCpf.UseVisualStyleBackColor = true;
            this.btn_setCpf.Click += new System.EventHandler(this.btn_setCpf_Click);
            // 
            // btn_setEmail
            // 
            this.btn_setEmail.Enabled = false;
            this.btn_setEmail.Location = new System.Drawing.Point(349, 69);
            this.btn_setEmail.Name = "btn_setEmail";
            this.btn_setEmail.Size = new System.Drawing.Size(75, 23);
            this.btn_setEmail.TabIndex = 7;
            this.btn_setEmail.TabStop = false;
            this.btn_setEmail.Text = "Alterar";
            this.btn_setEmail.UseVisualStyleBackColor = true;
            this.btn_setEmail.Click += new System.EventHandler(this.btn_setEmail_Click);
            // 
            // btn_setName
            // 
            this.btn_setName.Enabled = false;
            this.btn_setName.Location = new System.Drawing.Point(348, 34);
            this.btn_setName.Name = "btn_setName";
            this.btn_setName.Size = new System.Drawing.Size(75, 23);
            this.btn_setName.TabIndex = 6;
            this.btn_setName.TabStop = false;
            this.btn_setName.Text = "Alterar";
            this.btn_setName.UseVisualStyleBackColor = true;
            this.btn_setName.Click += new System.EventHandler(this.btn_setName_Click);
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(89, 108);
            this.mtb_cpf.Mask = "999.999.999-99";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(253, 23);
            this.mtb_cpf.TabIndex = 4;
            this.mtb_cpf.TextChanged += new System.EventHandler(this.mtb_cpf_TextChanged);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(89, 70);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(253, 23);
            this.tb_email.TabIndex = 3;
            this.tb_email.TextChanged += new System.EventHandler(this.tb_email_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(89, 34);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(253, 23);
            this.tb_name.TabIndex = 2;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // btn_loadLoans
            // 
            this.btn_loadLoans.Location = new System.Drawing.Point(292, 0);
            this.btn_loadLoans.Name = "btn_loadLoans";
            this.btn_loadLoans.Size = new System.Drawing.Size(118, 43);
            this.btn_loadLoans.TabIndex = 9;
            this.btn_loadLoans.TabStop = false;
            this.btn_loadLoans.Text = "Ver empréstimos";
            this.btn_loadLoans.UseVisualStyleBackColor = true;
            this.btn_loadLoans.Click += new System.EventHandler(this.btn_loadLoans_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::My_Library.Properties.Resources.lupa;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Enabled = false;
            this.btn_search.Location = new System.Drawing.Point(409, 24);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(38, 35);
            this.btn_search.TabIndex = 5;
            this.btn_search.TabStop = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_tombo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tb_loanValue);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btn_clearLoan);
            this.groupBox3.Controls.Add(this.btn_newLoan);
            this.groupBox3.Controls.Add(this.tb_deadLine);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_books);
            this.groupBox3.Location = new System.Drawing.Point(13, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 274);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Novo empréstimo";
            // 
            // cb_tombo
            // 
            this.cb_tombo.FormattingEnabled = true;
            this.cb_tombo.Location = new System.Drawing.Point(20, 117);
            this.cb_tombo.Name = "cb_tombo";
            this.cb_tombo.Size = new System.Drawing.Size(404, 23);
            this.cb_tombo.TabIndex = 6;
            this.cb_tombo.TextChanged += new System.EventHandler(this.cb_tombo_TextChanged);
            this.cb_tombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_tombo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tombo:";
            // 
            // tb_loanValue
            // 
            this.tb_loanValue.Location = new System.Drawing.Point(224, 166);
            this.tb_loanValue.Name = "tb_loanValue";
            this.tb_loanValue.ReadOnly = true;
            this.tb_loanValue.Size = new System.Drawing.Size(199, 23);
            this.tb_loanValue.TabIndex = 6;
            this.tb_loanValue.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Valor da multa diária";
            // 
            // btn_clearLoan
            // 
            this.btn_clearLoan.Location = new System.Drawing.Point(19, 205);
            this.btn_clearLoan.Name = "btn_clearLoan";
            this.btn_clearLoan.Size = new System.Drawing.Size(200, 39);
            this.btn_clearLoan.TabIndex = 4;
            this.btn_clearLoan.TabStop = false;
            this.btn_clearLoan.Text = "Cancelar";
            this.btn_clearLoan.UseVisualStyleBackColor = true;
            this.btn_clearLoan.Click += new System.EventHandler(this.btn_clearLoan_Click);
            // 
            // btn_newLoan
            // 
            this.btn_newLoan.Enabled = false;
            this.btn_newLoan.Location = new System.Drawing.Point(223, 205);
            this.btn_newLoan.Name = "btn_newLoan";
            this.btn_newLoan.Size = new System.Drawing.Size(200, 39);
            this.btn_newLoan.TabIndex = 4;
            this.btn_newLoan.TabStop = false;
            this.btn_newLoan.Text = "Confirmar";
            this.btn_newLoan.UseVisualStyleBackColor = true;
            this.btn_newLoan.Click += new System.EventHandler(this.btn_newLoan_Click);
            // 
            // tb_deadLine
            // 
            this.tb_deadLine.Location = new System.Drawing.Point(20, 166);
            this.tb_deadLine.Name = "tb_deadLine";
            this.tb_deadLine.ReadOnly = true;
            this.tb_deadLine.Size = new System.Drawing.Size(197, 23);
            this.tb_deadLine.TabIndex = 3;
            this.tb_deadLine.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data limite:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Livro:";
            // 
            // cb_books
            // 
            this.cb_books.FormattingEnabled = true;
            this.cb_books.Location = new System.Drawing.Point(20, 68);
            this.cb_books.Name = "cb_books";
            this.cb_books.Size = new System.Drawing.Size(403, 23);
            this.cb_books.TabIndex = 5;
            this.cb_books.SelectedIndexChanged += new System.EventHandler(this.cb_books_SelectedIndexChanged);
            this.cb_books.TextChanged += new System.EventHandler(this.cb_books_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_loan);
            this.panel1.Controls.Add(this.btn_loadLoans);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_returnBook);
            this.panel1.Location = new System.Drawing.Point(470, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 43);
            this.panel1.TabIndex = 7;
            // 
            // btn_loan
            // 
            this.btn_loan.Enabled = false;
            this.btn_loan.Location = new System.Drawing.Point(133, 0);
            this.btn_loan.Name = "btn_loan";
            this.btn_loan.Size = new System.Drawing.Size(128, 43);
            this.btn_loan.TabIndex = 2;
            this.btn_loan.TabStop = false;
            this.btn_loan.Text = "Novo empréstimo";
            this.btn_loan.UseVisualStyleBackColor = true;
            this.btn_loan.Click += new System.EventHandler(this.btn_loan_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(0, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(102, 43);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.TabStop = false;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_returnBook
            // 
            this.btn_returnBook.Enabled = false;
            this.btn_returnBook.Location = new System.Drawing.Point(912, 0);
            this.btn_returnBook.Name = "btn_returnBook";
            this.btn_returnBook.Size = new System.Drawing.Size(102, 43);
            this.btn_returnBook.TabIndex = 0;
            this.btn_returnBook.Text = "Devolver";
            this.btn_returnBook.UseVisualStyleBackColor = true;
            this.btn_returnBook.Click += new System.EventHandler(this.btn_returnBook_Click);
            // 
            // F_SearchStudent
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_sair;
            this.ClientSize = new System.Drawing.Size(1497, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_rm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_SearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta & empréstimo alunos";
            this.Load += new System.EventHandler(this.F_SearchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.DataGridView dgv_Loans;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_rm;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_loadLoans;
		private System.Windows.Forms.Button btn_setCpf;
		private System.Windows.Forms.Button btn_setEmail;
		private System.Windows.Forms.Button btn_setName;
		private System.Windows.Forms.MaskedTextBox mtb_cpf;
		private System.Windows.Forms.TextBox tb_email;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox tb_deadLine;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cb_books;
		private System.Windows.Forms.Button btn_newLoan;
		private System.Windows.Forms.ComboBox cb_tombo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_loanValue;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_clearLoan;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Button btn_returnBook;
		private System.Windows.Forms.DataGridViewTextBoxColumn title;
		private System.Windows.Forms.DataGridViewTextBoxColumn ibsn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tombo;
		private System.Windows.Forms.DataGridViewTextBoxColumn start;
		private System.Windows.Forms.DataGridViewTextBoxColumn end;
		private System.Windows.Forms.DataGridViewTextBoxColumn delay;
		private System.Windows.Forms.DataGridViewTextBoxColumn value;
		private System.Windows.Forms.Button btn_loan;
		private System.Windows.Forms.Button btn_edit;
	}
}