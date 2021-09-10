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
	public partial class F_SearchStudent : Form
	{
		private Student _student;
		public F_SearchStudent()
		{
			InitializeComponent();
		}

		private void F_SearchStudent_Load(object sender, EventArgs e)
		{
			setEditControlsEnabled(false);
			setNewLoanControlsEnabled(false);
		}

		#region: EDIT AND SEARCH CONTROLS

		private void btn_edit_Click(object sender, EventArgs e) => setEditControlsEnabled(true);
		private void btn_Clear_Click(object sender, EventArgs e) => clearEditControls();
		private void btn_setName_Click(object sender, EventArgs e)
		{

		}
		private void btn_setEmail_Click(object sender, EventArgs e)
		{

		}
		private void btn_setCpf_Click(object sender, EventArgs e)
		{

		}
		private void btn_search_Click(object sender, EventArgs e)
		{
			string select = String.Format(@"
				SELECT
					cd_cpf, ds_email, nm_usuario
				FROM
					tb_usuario
				WHERE
					cd_usuario = {0} AND ic_desativado = 1 AND ds_tipo = 1 
				", tb_rm.Text
			);
			DataTable dt = Database.dql(select);
			if (dt.Rows.Count != 0)
			{
				tb_name.Text = dt.Rows[0].Field<string>("nm_usuario");
				tb_email.Text = dt.Rows[0].Field<string>("ds_email");
				mtb_cpf.Text = dt.Rows[0].Field<string>("cd_cpf");
				this._student = new Student(
					tb_rm.Text,
					Globals.formatCPF(mtb_cpf.Text),
					tb_email.Text,
					tb_name.Text
				);
			}
			else
			{
				MessageBox.Show("Aluno não encontrado");
			}
		}

		#endregion

		#region DATAGRIDVIEW CONTROLS

		private void btn_loadLoans_Click(object sender, EventArgs e)
		{
			_student.LoadForfeitData();

			foreach (Student.forfeit row in this._student._forfeit)
			{
				dgv_Loans.Rows.Add(
					row._book.title,
					row._book.ibsn,
					row._book.tombo,
					row.start.ToString(),
					row.end.ToString(),
					row.delay.ToString() + " dias.",
					"R$ " + row.value.ToString() + "."
				);
			};
		}

		private void dgv_Loans_SelectionChanged(object sender, EventArgs e)
		{

		}
		private void btn_returnBook_Click(object sender, EventArgs e)
		{
			byte index = (byte)dgv_Loans.CurrentCell.RowIndex;
			if ((short)this._student._forfeit[index].value != 0)
			{
				if (MessageBox.Show(
					"Confirme se a multa foi paga",
					"Devolução",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Warning
					) == DialogResult.OK)
				{
					returnBook(index);
				}
			}
			else
			{
				returnBook(index);
			}
		}
		private void btn_sair_Click(object sender, EventArgs e)
		{
			_student.Dispose();
			Close();
		}

		#endregion

		#region NEW LOAN

		private void btn_loan_Click(object sender, EventArgs e)
		{
			setNewLoanControlsEnabled(true);
			Dictionary<long, string> books = new Dictionary<long, string>();
			string select = String.Format(@"
				SELECT nm_titulo, cd_livro
				FROM tb_livro
				WHERE qt_exemplares > 1 AND ic_desativado = 0
			");
			DataTable dt = Database.dql(select);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				books.Add(
					dt.Rows[i].Field<long>("cd_livro"),
					dt.Rows[i].Field<string>("nm_titulo")
				);
			}
			cb_books.Items.Clear();
			cb_books.DataSource = new BindingSource(books, null);
			cb_books.DisplayMember = "Values";
			cb_books.ValueMember = "Key";

		}
		private void btn_clearLoan_Click(object sender, EventArgs e) => clearLoanControls();
		private void btn_newLoan_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region COMMON FUNCTIONS

		public void setNewLoanControlsEnabled(bool state)
		{
			cb_books.Enabled = state;
			cb_tombo.Enabled = state;
			btn_clearLoan.Enabled = state;
			btn_newLoan.Enabled = state;
		}
		public void setEditControlsEnabled(bool state)
		{
			tb_name.Enabled = state;
			tb_email.Enabled = state;
			mtb_cpf.Enabled = state;
			btn_setName.Enabled = state;
			btn_setEmail.Enabled = state;
			btn_setCpf.Enabled = state;
			btn_Clear.Enabled = state;
		}
		public void clearLoanControls()
		{
			cb_books.SelectedIndex = -1;
			cb_tombo.SelectedIndex = -1;
			tb_deadLine.Clear();
			tb_loanValue.Clear();
		}
		public void clearEditControls()
		{
			tb_name.Clear();
			tb_email.Clear();
			mtb_cpf.Clear();
		}
		public void returnBook(byte index)
		{
			string update = String.Format(@"
				UPDATE tb_livro_unit 
				SET ic_disponivel = 1 
				WHERE cd_tombo = {0}",
				dgv_Loans.Rows[index].Cells[2].Value.ToString()
			);
			Database.dml(update);

			//Optei por fazer o select na hora pra evitar erros caso a quantidade de exemplares mudasse no meio da operação
			update = String.Format(@"
				UPDATE tb_livro 
				SET qt_exemplares = 
					(SELECT qt_exemplares FROM tb_livro WHERE nm_titulo = '{0}' - 1) 
				WHERE cd_ibsn= '{1}'",
				_student._forfeit[index]._book.title,
				_student._forfeit[index]._book.ibsn
			);
			Database.dml(update);
			update = String.Format(@"
				UPDATE tb_emprestimos 
				SET dt_devolucao = DATETIME('NOW', 'LOCALTIME') 
				WHERE cd_emprestimo= {0}",
				_student._forfeit[index].cd_emprestimo
			);
			Database.dml(update, "Devolução bem sucedida", "Erro");
		}
		#endregion
	}
}
