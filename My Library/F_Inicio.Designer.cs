
namespace My_Library
{
    partial class F_Inicio
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
            this.lb_displayUser = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_addBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_addAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_addPublisher = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_newStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_searchStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_newEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_searchEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_configs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_displayUser
            // 
            this.lb_displayUser.AutoSize = true;
            this.lb_displayUser.Location = new System.Drawing.Point(12, 535);
            this.lb_displayUser.Name = "lb_displayUser";
            this.lb_displayUser.Size = new System.Drawing.Size(73, 15);
            this.lb_displayUser.TabIndex = 0;
            this.lb_displayUser.Text = "BEM VINDO ";
            this.lb_displayUser.ForeColor = Globals.genericFontColor;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acervoToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.mi_configs,
            this.mi_about,
            this.mi_logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ForeColor = Globals.genericFontColor;
            this.menuStrip1.BackColor = Globals.genericBackgroundColor;
            // 
            // acervoToolStripMenuItem
            // 
            this.acervoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_addBook,
            this.mi_addAuthor,
            this.mi_addPublisher});
            this.acervoToolStripMenuItem.Name = "acervoToolStripMenuItem";
            this.acervoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.acervoToolStripMenuItem.Text = "A&cervo";
            this.acervoToolStripMenuItem.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_addBook
            // 
            this.mi_addBook.Name = "mi_addBook";
            this.mi_addBook.Size = new System.Drawing.Size(165, 22);
            this.mi_addBook.Text = "Adicionar livro";
            this.mi_addBook.Click += new System.EventHandler(this.mi_addBook_Click);
            this.mi_addBook.ForeColor = Globals.genericFontColor;
            this.mi_addBook.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_addAuthor
            // 
            this.mi_addAuthor.Name = "mi_addAuthor";
            this.mi_addAuthor.Size = new System.Drawing.Size(165, 22);
            this.mi_addAuthor.Text = "Adicionar autor";
            this.mi_addAuthor.Click += new System.EventHandler(this.mi_addAuthor_Click);
            this.mi_addAuthor.ForeColor = Globals.genericFontColor;
            this.mi_addAuthor.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_addPublisher
            // 
            this.mi_addPublisher.Name = "mi_addPublisher";
            this.mi_addPublisher.Size = new System.Drawing.Size(165, 22);
            this.mi_addPublisher.Text = "Adicionar editora";
            this.mi_addPublisher.Click += new System.EventHandler(this.mi_addPublisher_Click);
            this.mi_addPublisher.ForeColor = Globals.genericFontColor;
            this.mi_addPublisher.BackColor = Globals.genericBackgroundColor;
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_newStudent,
            this.mi_searchStudent});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "&Alunos";
            this.alunosToolStripMenuItem.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_newStudent
            // 
            this.mi_newStudent.Name = "mi_newStudent";
            this.mi_newStudent.Size = new System.Drawing.Size(180, 22);
            this.mi_newStudent.Text = "Novo";
            this.mi_newStudent.Click += new System.EventHandler(this.mi_newStudent_Click);
            this.mi_newStudent.ForeColor = Globals.genericFontColor;
            this.mi_newStudent.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_searchStudent
            // 
            this.mi_searchStudent.Name = "mi_searchStudent";
            this.mi_searchStudent.Size = new System.Drawing.Size(180, 22);
            this.mi_searchStudent.Text = "Consulta";
            this.mi_searchStudent.Click += new System.EventHandler(this.mi_searchStudent_Click);
            this.mi_searchStudent.ForeColor = Globals.genericFontColor;
            this.mi_searchStudent.BackColor = Globals.genericBackgroundColor;
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_newEmployee,
            this.mi_searchEmployee});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "&Funcionários";
            this.funcionáriosToolStripMenuItem.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_newEmployee
            // 
            this.mi_newEmployee.Name = "mi_newEmployee";
            this.mi_newEmployee.Size = new System.Drawing.Size(180, 22);
            this.mi_newEmployee.Text = "Novo";
            this.mi_newEmployee.Click += new System.EventHandler(this.mi_newEmployee_Click);
            this.mi_newEmployee.ForeColor = Globals.genericFontColor;
            this.mi_newEmployee.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_searchEmployee
            // 
            this.mi_searchEmployee.Name = "mi_searchEmployee";
            this.mi_searchEmployee.Size = new System.Drawing.Size(180, 22);
            this.mi_searchEmployee.Text = "Consulta";
            this.mi_searchEmployee.Click += new System.EventHandler(this.mi_searchEmployee_Click);
            this.mi_searchEmployee.ForeColor = Globals.genericFontColor;
            this.mi_searchEmployee.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_about
            // 
            this.mi_about.Name = "mi_about";
            this.mi_about.Size = new System.Drawing.Size(49, 20);
            this.mi_about.Text = "&Sobre";
            this.mi_about.Click += new System.EventHandler(this.mi_about_Click);
            this.mi_about.ForeColor = Globals.genericFontColor;
            this.mi_about.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_logout
            // 
            this.mi_logout.Name = "mi_logout";
            this.mi_logout.Size = new System.Drawing.Size(57, 20);
            this.mi_logout.Text = "&Logout";
            this.mi_logout.Click += new System.EventHandler(this.mi_logout_Click);
            this.mi_logout.ForeColor = Globals.genericFontColor;
            this.mi_logout.BackColor = Globals.genericBackgroundColor;
            // 
            // mi_configs
            // 
            this.mi_configs.Name = "mi_configs";
            this.mi_configs.Size = new System.Drawing.Size(91, 20);
            this.mi_configs.Text = "&Configuração";
            this.mi_configs.Click += new System.EventHandler(this.mi_configs_Click);
            this.mi_configs.ForeColor = Globals.genericFontColor;
            this.mi_configs.BackColor = Globals.genericBackgroundColor;
            // 
            // F_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 559);
            this.Controls.Add(this.lb_displayUser);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INÍCIO";
            this.Load += new System.EventHandler(this.F_Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.BackColor = Globals.genericBackgroundColor;

        }

        #endregion

        public System.Windows.Forms.Label lb_displayUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acervoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_addBook;
        private System.Windows.Forms.ToolStripMenuItem mi_addAuthor;
        private System.Windows.Forms.ToolStripMenuItem mi_addPublisher;
        private System.Windows.Forms.ToolStripMenuItem mi_newStudent;
        private System.Windows.Forms.ToolStripMenuItem mi_searchStudent;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_newEmployee;
        private System.Windows.Forms.ToolStripMenuItem mi_searchEmployee;
        private System.Windows.Forms.ToolStripMenuItem mi_about;
        private System.Windows.Forms.ToolStripMenuItem mi_logout;
        private System.Windows.Forms.ToolStripMenuItem mi_configs;
    }
}