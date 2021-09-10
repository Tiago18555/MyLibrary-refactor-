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
    public partial class F_AddAuthor : Form
    {
        private DataTable dt;
        public F_AddAuthor()
        {
            InitializeComponent();
        }
        private void F_AddAuthor_Load(object sender, EventArgs e)
        {
            string query = "SELECT nm_autor FROM tb_autor";
            this.dt = Database.dql(query);
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = tb_name.TextLength <= 3 ? false : true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = String.Format(@"
                INSERT INTO 
                    tb_autor (nm_autor) 
                VALUES ('{0}')", 
                    tb_name.Text
            );
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].Field<string>("nm_autor").ToString() == tb_name.Text)
                {
                    MessageBox.Show("Autor já cadastrado");
                    tb_name.Clear();
                    return;
                }
            }
            Database.dml(query, "Cadastrado com sucesso", "Erro no cadastro");
            dt.Rows.Add(tb_name.Text);
        }

		private void btn_sair_Click(object sender, EventArgs e) => this.Close();
	}
}
