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
    public partial class F_AddEmployee : Form
    {
        //ic_desativado=1=ativado     ds_tipo=1aluno,2professor,3func
        private byte minimumNameLength { get; set; } = 3;
        private byte minimumRMLength { get; set; } = 5;
        private Color foreColorOK { get; set; } = Color.Green;
        private Color foreColorErr { get; set; } = Color.Red;
        public F_AddEmployee() => InitializeComponent();
        private void tb_name_TextChanged(object sender, EventArgs e) => setRegisterButtonEnabled();
        private void tb_email_TextChanged(object sender, EventArgs e) => setRegisterButtonEnabled();
        private void tb_registration_TextChanged(object sender, EventArgs e) => setRegisterButtonEnabled();
        private void mtb_cpf_TextChanged(object sender, EventArgs e)
        {
            if (mtb_cpf.Text.Length == 14)
            {
                mtb_cpf.ForeColor =
                    Globals.validaCPF(Globals.formatCPF(mtb_cpf.Text))
                    ? foreColorOK : foreColorErr;
            }
            else { mtb_cpf.ForeColor = foreColorErr; }

            setRegisterButtonEnabled();
        }
        private void btn_sair_Click(object sender, EventArgs e) => Close();
        private void btn_limpar_Click(object sender, EventArgs e) => clearAll();

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            byte isProfessor = chbox_professor.Checked ? (byte)2 : (byte)3;
            string Message = chbox_professor.Checked ? "Professor" : "Funcionário";
            string select = String.Format(@"
			    SELECT cd_cpf 
			    FROM tb_usuario 
			    WHERE cd_cpf = '{0}'
			    ", Globals.formatCPF(mtb_cpf.Text)
            );
            DataTable dt = Database.dql(select);
            if (dt.Rows.Count == 0)
            {
                string insert = String.Format(@"
					INSERT INTO 
						tb_usuario(cd_cpf, ds_email, nm_usuario, ic_desativado, ds_tipo)
					VALUES
						('{0}', '{1}', '{2}', 1, {3})",
                    Globals.formatCPF(mtb_cpf.Text),
                    tb_email.Text,
                    tb_name.Text,
                    isProfessor
                );
                Database.dml(insert, Message + " Cadastrado com sucesso", "Erro no cadastro");
            }
            else { MessageBox.Show("Erro: \nCPF já cadastrado"); }
            clearAll();
        }


        private void tb_registration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Globals.keyIsNumber(e))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números");
            }
        }
        public void clearAll()
        {
            mtb_cpf.Clear();
            tb_email.Clear();
            tb_name.Clear();
            tb_registration.Clear();
            chbox_professor.Checked = false;
            tb_name.Focus();
        }
        public void setRegisterButtonEnabled()
        {
            btn_cadastrar.Enabled =
                Globals.validaEmail(tb_email.Text) &&
                tb_name.TextLength >= minimumNameLength &&
                tb_registration.TextLength >= minimumRMLength &&
                mtb_cpf.ForeColor == foreColorOK;
        }
    }
}
