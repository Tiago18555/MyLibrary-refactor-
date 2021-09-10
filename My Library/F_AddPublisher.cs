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
    public partial class F_AddPublisher : Form
    {
        private Color foreColorOK = Color.Green;
        private Color foreColorErr = Color.Red;
        private byte minimumTextSize = 3;
        private DataTable dt;
        public F_AddPublisher() => InitializeComponent();

        private void F_AddPublisher_Load(object sender, EventArgs e)
        {
            string query = "SELECT nm_editora, cd_cnpj FROM tb_editora";
            this.dt = Database.dql(query);
        }
        private void tb_name_TextChanged(object sender, EventArgs e) => setActiveButton();

        //Controla a cor do Maskedtextbox baseado na validação do CNPJ, e serve de referência para ativação do botão ADD
        private void mtb_cnpj_TextChanged(object sender, EventArgs e)
        {
            mtb_cnpj.ForeColor = Globals.validaCNPJ(Globals.formatCNPJ(mtb_cnpj.Text)) ? foreColorOK : foreColorErr;
            setActiveButton();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].Field<string>("cd_cnpj").ToString() == Globals.formatCNPJ(mtb_cnpj.Text))
                {
                    if(MessageBox
                        .Show(
                            "O CNPJ fornecido já está cadastrado. \nDeseja alterar o nome da editora?", 
                            "Alterar nome?", 
                            MessageBoxButtons.OKCancel, 
                            MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        string update = String.Format(@"
                            UPDATE 
                                tb_editora 
                            SET 
                                nm_editora = '{0}'
                            WHERE
                                cd_cnpj = '{1}'", 
                            tb_name.Text, 
                            Globals.formatCNPJ(mtb_cnpj.Text)
                        );
                        Database.dml(update, "Alterações efetuadas", "Erro na operação");
                        dt.Rows[i].SetField("nm_editora", tb_name.Text);
                        return;
                    }
                }
            }
            string query = String.Format(@"
                INSERT INTO 
                    tb_editora (nm_editora, cd_cnpj) 
                VALUES ('{0}', '{1}')",
                tb_name.Text, Globals.formatCNPJ(mtb_cnpj.Text)
            );
            Database.dml(query, "Cadastrado com sucesso", "Erro no cadastro");
            dt.Rows.Add(tb_name.Text, Globals.formatCNPJ(mtb_cnpj.Text));
        }
		private void btn_sair_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// Controla o estado ativação do botão, baseado na cor do MaskedTextBox
        /// </summary>
        public void setActiveButton()
        {
            btn_add.Enabled = tb_name.TextLength >= minimumTextSize && mtb_cnpj.ForeColor == foreColorOK;// ? true : false;
        }
	}
}
