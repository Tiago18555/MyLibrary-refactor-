using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Library
{
    public partial class F_Inicio : Form
    {
        public F_Inicio(User _user)
        {
            InitializeComponent();
            lb_displayUser.Text = "Bem vindo " + _user.name + ".";
        }

        private void F_Inicio_Load(object sender, EventArgs e)
        {
        }

        #region MENU_STRIP

        private void mi_addAuthor_Click(object sender, EventArgs e) =>        
            new F_AddAuthor().ShowDialog(); 
        private void mi_addBook_Click(object sender, EventArgs e) =>        
            new F_AddBook().ShowDialog();
        private void mi_addPublisher_Click(object sender, EventArgs e) =>       
            new F_AddPublisher().ShowDialog();
        private void mi_newStudent_Click(object sender, EventArgs e) =>
            new F_AddStudent().ShowDialog();
        private void mi_searchStudent_Click(object sender, EventArgs e) =>
            new F_SearchStudent().ShowDialog();
        private void mi_viewLoans_Click(object sender, EventArgs e) =>
            new F_ViewLoans().ShowDialog();
        private void mi_newEmployee_Click(object sender, EventArgs e) =>
            new F_AddEmployee().ShowDialog();
        private void mi_searchEmployee_Click(object sender, EventArgs e) =>
            new F_SearchEmployee().ShowDialog();
        private void mi_about_Click(object sender, EventArgs e) =>
            new F_About().ShowDialog();
        private void mi_configs_Click(object sender, EventArgs e) => 
            new F_Configs().ShowDialog();
        private void mi_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            new F_Login(Globals.autoCompleteUserName).ShowDialog();
            Globals.logado = false;
        }

        #endregion

    }
}
