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
    public partial class F_AddStudent : Form
    {
		private byte minimumNameLength { get; set; } = 3;
		private byte minimumRMLength { get; set; } = 5;
		private Color foreColorOK { get; set; } = Color.Green;
		private Color foreColorErr { get; set; } = Color.Red;
		public F_AddStudent() =>InitializeComponent();
		private void tb_name_TextChanged(object sender, EventArgs e) => setRegisterButtonEnabled();
		private void tb_email_TextChanged(object sender, EventArgs e) => setRegisterButtonEnabled();
		private void tb_rm_TextChanged(object sender, EventArgs e) => setRegisterButtonEnabled();
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
			string select = String.Format(@"
				SELECT cd_cpf 
				FROM tb_usuario 
				WHERE cd_cpf = '{0}'
				", Globals.formatCPF(mtb_cpf.Text)
			);
			DataTable dt = Database.dql(select);
			if(dt.Rows.Count == 0)
			{
				string insert = String.Format(@"
					INSERT INTO 
						tb_usuario(cd_cpf, ds_email, nm_usuario, ic_desativado, ds_tipo, cd_usuario)
					VALUES
						('{0}', '{1}', '{2}', 1, 1, '{3}')",
					Globals.formatCPF(mtb_cpf.Text), 
					tb_email.Text, 
					tb_name.Text,
					tb_rm.Text
				);
				Database.dml(insert, "Aluno cadastrado com sucesso", "Erro no cadastro");
			}
			else { MessageBox.Show("Erro: \nCPF já cadastrado"); }
			clearAll();
		}
		public void clearAll()
		{
			mtb_cpf.Clear();
			tb_email.Clear();
			tb_name.Clear();
			tb_rm.Clear();
			tb_name.Focus();			
		}
		public void setRegisterButtonEnabled()
		{
			btn_cadastrar.Enabled =
				Globals.validaEmail(tb_email.Text) &&
				tb_name.TextLength >= minimumNameLength &&
				tb_rm.TextLength >= minimumRMLength &&
				mtb_cpf.ForeColor == foreColorOK;
		}
		private void tb_rm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Globals.keyIsNumber(e))
			{
				e.Handled = true;
				MessageBox.Show("Digite apenas números");
			}
		}

		private void F_AddStudent_Load(object sender, EventArgs e)
		{

		}

		private void mtb_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}
	}
}
