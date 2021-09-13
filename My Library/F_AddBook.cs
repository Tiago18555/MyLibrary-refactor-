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
    public partial class F_AddBook : Form
    {
		DataTable dt;

		public F_AddBook() => InitializeComponent();
		Dictionary<int, string> authors = new Dictionary<int, string>();
		Dictionary<int, string> publishers = new Dictionary<int, string>();

		private void tb_title_TextChanged(object sender, EventArgs e) =>
			activateRegisterButton();
		private void tb_ibsn_TextChanged(object sender, EventArgs e) =>		
			activateRegisterButton();
		private void cb_publisher_SelectedIndexChanged(object sender, EventArgs e) =>		
			activateRegisterButton();
		private void cb_author_SelectedIndexChanged(object sender, EventArgs e) =>
			activateRegisterButton();
		private void tb_description_TextChanged(object sender, EventArgs e) =>		
			activateRegisterButton();
		private void nm_qtd_ValueChanged(object sender, EventArgs e) =>
			activateRegisterButton();
		private void cb_author_TextChanged(object sender, EventArgs e) =>		
			btn_add.Enabled = Globals.compare(authors, cb_author.Text);
		private void cb_publisher_TextChanged(object sender, EventArgs e) =>		
			btn_add.Enabled = Globals.compare(publishers, cb_publisher.Text);		
		private void btn_sair_Click(object sender, EventArgs e) => Close();
		private void btn_clear_Click(object sender, EventArgs e) => clearAll();
		private void btn_add_Click(object sender, EventArgs e)
		{
			string type = chboxPeriodico.Checked ? "1" : "0";
			string select = String.Format(@"
				SELECT cd_ibsn
				FROM tb_livro
				WHERE cd_ibsn = '{0}'",
				tb_ibsn.Text
			);
			if(Database.dql(select).Rows.Count == 0)
			{
				registerBook(type);
				MessageBox.Show("Livro cadastrado com sucesso");
			}
			else
			{
				addBook();
				MessageBox.Show("Livros adicionados com sucesso");
			}
		}

		private void F_AddBook_Load(object sender, EventArgs e)
		{
			loadAuthorsList();
			loadPublishersList();
		}
		private void tb_ibsn_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Globals.keyIsNumber(e))
			{
				e.Handled = true;
				MessageBox.Show("Digite apenas números");
			}
		}

		public void activateRegisterButton()
		{
			btn_add.Enabled =
				tb_title.Text.Length >= 5 &&
				tb_ibsn.Text.Length >= 5 &&
				cb_author.Text.Length != 0 &&
				cb_publisher.Text.Length != 0 &&
				tb_description.Text.Length >= 5 &&
				nm_qtd.Value != 0;
		}
		public void loadAuthorsList()
		{
			string select = "SELECT nm_autor, cd_autor FROM tb_autor";
			DataTable dt = Database.dql(select);
			for(int i = 0; i < dt.Rows.Count; i++)
			{
				authors.Add(
					Convert.ToInt32(dt.Rows[i].Field<long>("cd_autor")),
					dt.Rows[i].Field<string>("nm_autor")
				);
			}
			cb_author.Items.Clear();
			cb_author.DataSource = new BindingSource(authors, null);
			cb_author.DisplayMember = "Value";
			cb_author.ValueMember = "Key";
		}
		public void loadPublishersList()
		{
			string select = "SELECT nm_editora, cd_editora FROM tb_editora";
			DataTable dt = Database.dql(select);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				publishers.Add(
					Convert.ToInt32(dt.Rows[i].Field<long>("cd_editora")),
					dt.Rows[i].Field<string>("nm_editora")
				);
			}
			cb_publisher.Items.Clear();
			cb_publisher.DataSource = new BindingSource(publishers, null);
			cb_publisher.DisplayMember = "Value";
			cb_publisher.ValueMember = "Key";
		}
		public void clearAll()
		{
			tb_title.Clear();
			tb_ibsn.Clear();
			cb_publisher.SelectedIndex = -1;
			cb_publisher.Text = "";
			cb_author.SelectedIndex = -1;
			cb_author.Text = "";
			tb_description.Clear();
			nm_qtd.Value = 0;
			chboxPeriodico.Checked = false;
			tb_title.Focus();
		}
		public void addBook()
		{
			if (MessageBox.Show(
				"IBSN de Livro já cadastrado. \nDeseja adicionar unidades?\n\nOutras alterações de dados serão ignoradas",
				"Alterar quantidade?",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Warning
				) == DialogResult.OK)
			{
				string update = String.Format(@"
						UPDATE tb_livro
						SET qt_exemplares = (
							SELECT qt_exemplares 
							FROM tb_livro 
							WHERE cd_ibsn = '{0}') + {1}
						WHERE cd_ibsn = '{0}'",
					tb_ibsn.Text, nm_qtd.Value
				);
				MessageBox.Show("IBSN: " + tb_ibsn.Text + "\nQTD: " + nm_qtd.Value);
				Database.dml(update, "updateMAINOK", "ERR MAIN");
				string insert = String.Format(@"
						INSERT INTO tb_livro_unit(cd_livro, ic_disponivel)
						VALUES((SELECT cd_livro FROM tb_livro WHERE cd_ibsn = '{0}'), 1)
					", tb_ibsn.Text);
				for (int i = 0; i < nm_qtd.Value; i++)				
					Database.dml(insert);
			}
		}
		public void registerBook(string type)
		{
			string insert = String.Format(@"
					INSERT INTO tb_livro(
					cd_ibsn, cd_editora, cd_autor, nm_titulo, 
					ds_assunto, qt_exemplares, ic_tipo, ic_desativado
					)
					VALUES(
					'{0}', {1}, {2}, '{3}', '{4}', {5}, {6}, 0)",
						tb_ibsn.Text,
						cb_publisher.SelectedValue.ToString(),
						cb_author.SelectedValue.ToString(),
						tb_title.Text,
						tb_description.Text,
						nm_qtd.Value,
						type
					);
			Database.dml(insert);
			insert = String.Format(@"
					INSERT INTO tb_livro_unit(
						cd_livro, ic_disponivel
					)
					VALUES((SELECT MAX(cd_livro) FROM tb_livro), 1)"
			);
			for (int i = 0; i < nm_qtd.Value; i++)
				Database.dml(insert);
		}
	}
}
