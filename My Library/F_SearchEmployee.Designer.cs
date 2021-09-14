
namespace My_Library
{
    partial class F_SearchEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_showLoan = new System.Windows.Forms.Button();
            this.btn_loadLoans = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_returnBook = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_boundary = new System.Windows.Forms.TextBox();
            this.cb_tombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clearLoan = new System.Windows.Forms.Button();
            this.btn_newLoan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_books = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
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
            this.tb_registration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Loans = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_professor = new System.Windows.Forms.RadioButton();
            this.rb_employee = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loans)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_showLoan);
            this.panel1.Controls.Add(this.btn_loadLoans);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_returnBook);
            this.panel1.Location = new System.Drawing.Point(484, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 43);
            this.panel1.TabIndex = 14;
            // 
            // btn_showLoan
            // 
            this.btn_showLoan.Enabled = false;
            this.btn_showLoan.Location = new System.Drawing.Point(133, 0);
            this.btn_showLoan.Name = "btn_showLoan";
            this.btn_showLoan.Size = new System.Drawing.Size(128, 43);
            this.btn_showLoan.TabIndex = 2;
            this.btn_showLoan.TabStop = false;
            this.btn_showLoan.Text = "Novo empréstimo";
            this.btn_showLoan.UseVisualStyleBackColor = true;
            this.btn_showLoan.Click += new System.EventHandler(this.btn_showLoan_Click);
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
            this.btn_returnBook.Location = new System.Drawing.Point(518, 0);
            this.btn_returnBook.Name = "btn_returnBook";
            this.btn_returnBook.Size = new System.Drawing.Size(102, 43);
            this.btn_returnBook.TabIndex = 0;
            this.btn_returnBook.Text = "Devolver";
            this.btn_returnBook.UseVisualStyleBackColor = true;
            this.btn_returnBook.Click += new System.EventHandler(this.btn_returnBook_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_boundary);
            this.groupBox3.Controls.Add(this.cb_tombo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_clearLoan);
            this.groupBox3.Controls.Add(this.btn_newLoan);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_books);
            this.groupBox3.Location = new System.Drawing.Point(27, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 205);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Novo empréstimo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Limite:";
            // 
            // tb_boundary
            // 
            this.tb_boundary.Location = new System.Drawing.Point(78, 122);
            this.tb_boundary.Name = "tb_boundary";
            this.tb_boundary.ReadOnly = true;
            this.tb_boundary.Size = new System.Drawing.Size(100, 23);
            this.tb_boundary.TabIndex = 8;
            // 
            // cb_tombo
            // 
            this.cb_tombo.FormattingEnabled = true;
            this.cb_tombo.Location = new System.Drawing.Point(21, 92);
            this.cb_tombo.Name = "cb_tombo";
            this.cb_tombo.Size = new System.Drawing.Size(404, 23);
            this.cb_tombo.TabIndex = 6;
            this.cb_tombo.TextChanged += new System.EventHandler(this.cb_tombo_TextChanged);
            this.cb_tombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_tombo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tombo:";
            // 
            // btn_clearLoan
            // 
            this.btn_clearLoan.Location = new System.Drawing.Point(20, 157);
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
            this.btn_newLoan.Location = new System.Drawing.Point(223, 157);
            this.btn_newLoan.Name = "btn_newLoan";
            this.btn_newLoan.Size = new System.Drawing.Size(200, 39);
            this.btn_newLoan.TabIndex = 4;
            this.btn_newLoan.TabStop = false;
            this.btn_newLoan.Text = "Confirmar";
            this.btn_newLoan.UseVisualStyleBackColor = true;
            this.btn_newLoan.Click += new System.EventHandler(this.btn_newLoan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Livro:";
            // 
            // cb_books
            // 
            this.cb_books.FormattingEnabled = true;
            this.cb_books.Location = new System.Drawing.Point(21, 43);
            this.cb_books.Name = "cb_books";
            this.cb_books.Size = new System.Drawing.Size(403, 23);
            this.cb_books.TabIndex = 5;
            this.cb_books.SelectedIndexChanged += new System.EventHandler(this.cb_books_SelectedIndexChanged);
            this.cb_books.TextChanged += new System.EventHandler(this.cb_books_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::My_Library.Properties.Resources.lupa;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.Enabled = false;
            this.btn_search.Location = new System.Drawing.Point(423, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(38, 35);
            this.btn_search.TabIndex = 12;
            this.btn_search.TabStop = false;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(27, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 193);
            this.groupBox2.TabIndex = 11;
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
            // tb_registration
            // 
            this.tb_registration.Location = new System.Drawing.Point(116, 65);
            this.tb_registration.Name = "tb_registration";
            this.tb_registration.Size = new System.Drawing.Size(301, 23);
            this.tb_registration.TabIndex = 8;
            this.tb_registration.TextChanged += new System.EventHandler(this.tb_registration_TextChanged);
            this.tb_registration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_registration_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Matricula:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Loans);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(481, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 489);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livros em posse";
            // 
            // dgv_Loans
            // 
            this.dgv_Loans.AllowUserToAddRows = false;
            this.dgv_Loans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.start});
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
            this.dgv_Loans.Size = new System.Drawing.Size(620, 464);
            this.dgv_Loans.TabIndex = 0;
            this.dgv_Loans.SelectionChanged += new System.EventHandler(this.dgv_Loans_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_professor);
            this.groupBox4.Controls.Add(this.rb_employee);
            this.groupBox4.Location = new System.Drawing.Point(27, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 38);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // rb_professor
            // 
            this.rb_professor.AutoSize = true;
            this.rb_professor.Location = new System.Drawing.Point(296, 13);
            this.rb_professor.Name = "rb_professor";
            this.rb_professor.Size = new System.Drawing.Size(74, 19);
            this.rb_professor.TabIndex = 1;
            this.rb_professor.TabStop = true;
            this.rb_professor.Text = "Professor";
            this.rb_professor.UseVisualStyleBackColor = true;
            // 
            // rb_employee
            // 
            this.rb_employee.AutoSize = true;
            this.rb_employee.Location = new System.Drawing.Point(89, 13);
            this.rb_employee.Name = "rb_employee";
            this.rb_employee.Size = new System.Drawing.Size(88, 19);
            this.rb_employee.TabIndex = 0;
            this.rb_employee.TabStop = true;
            this.rb_employee.Text = "Funcionário";
            this.rb_employee.UseVisualStyleBackColor = true;
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
            this.ibsn.Width = 130;
            // 
            // tombo
            // 
            this.tombo.HeaderText = "Tombo";
            this.tombo.Name = "tombo";
            this.tombo.ReadOnly = true;
            this.tombo.Width = 70;
            // 
            // start
            // 
            this.start.HeaderText = "Data do empréstimo";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            this.start.Width = 167;
            // 
            // F_SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 605);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_registration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_SearchEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta & empréstimo de funcionários";
            this.Load += new System.EventHandler(this.F_SearchEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Loans)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_showLoan;
        private System.Windows.Forms.Button btn_loadLoans;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_returnBook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_tombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_clearLoan;
        private System.Windows.Forms.Button btn_newLoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_books;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_setCpf;
        private System.Windows.Forms.Button btn_setEmail;
        private System.Windows.Forms.Button btn_setName;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Loans;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rb_professor;
		private System.Windows.Forms.RadioButton rb_employee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_boundary;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
    }
}