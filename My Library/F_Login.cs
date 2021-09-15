using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashLib;

namespace My_Library
{
    public partial class F_Login : Form
    {
        private byte passwordMinimunSize { get; set; } = 5;
        public F_Login(string? acl)
        {
            InitializeComponent();
            tb_cpf.Text = acl == null ? "" : acl;
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            btn_login.Enabled = true; // DEPOIS APAGA ISSO
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var sha512 = HashFactory.Crypto.SHA3.CreateKeccak256();
            string tempHash = sha512.ComputeString(tb_senha.Text).ToString();

            string query = String.Format(@"
                SELECT 
                    nm_login, cd_cpf, ds_senha 
                FROM 
                    tb_login 
                WHERE 
                    cd_cpf = '{0}' AND ds_senha = '{1}'", 
                tb_cpf.Text, tempHash
            );

            DataTable dt = Database.dql(query);
            if (dt.Rows.Count == 1)
            {
                string nome = dt.Rows[0].Field<string>("nm_login");
                string cpf = dt.Rows[0].Field<string>("cd_cpf");
                string password = dt.Rows[0].Field<string>("ds_senha");

                Globals.logado = true;
                F_Inicio f_Inicio = new F_Inicio(new User(cpf, password, nome));
                f_Inicio.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
                refreshFields();
            }
        }

        private void tb_cpf_TextChanged(object sender, EventArgs e) =>
            activateLoginButton();
        

        private void tb_senha_TextChanged(object sender, EventArgs e) =>  
            activateLoginButton();
        

        private void activateLoginButton() =>      
            btn_login.Enabled = tb_cpf.TextLength > 10 && tb_senha.TextLength > passwordMinimunSize;
        

        private void refreshFields()
        {
            tb_cpf.Clear();
            tb_senha.Clear();
            tb_cpf.Focus();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            //PARA CRIAR O PRIMEIRO USER
            var sha512 = HashFactory.Crypto.SHA3.CreateKeccak256();
            string tempHash = sha512.ComputeString(tb_senha.Text).ToString();

            string query = String.Format(@"
                INSERT INTO
                    tb_login(nm_login, cd_cpf, ds_senha)
                VALUES
                    ('Tiago', '{0}', '{1}')",
                tb_cpf.Text, tempHash
            );
            Database.dml(query, "OK", "Erro: ");

            refreshFields();
        }
    }
}
