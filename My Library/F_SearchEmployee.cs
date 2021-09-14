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
    public partial class F_SearchEmployee : Form
    {
        private Employee _employee;
        private Color foreColorOK { get; set; } = Color.Green;
        private Color foreColorErr { get; set; } = Color.Red;
        Dictionary<int, string> books = new Dictionary<int, string>();
        public F_SearchEmployee() => InitializeComponent();
        private void F_SearchEmployee_Load(object sender, EventArgs e)
        {
            setEditControlsEnabled(false);
            setNewLoanControlsEnabled(false);
            rb_employee.Checked = true;
        }

        #region: EDIT AND SEARCH CONTROLS

        private void btn_Clear_Click(object sender, EventArgs e) =>
            clearEditControls();
        private void btn_edit_Click(object sender, EventArgs e) =>
            setEditControlsEnabled(true);
        private void tb_registration_TextChanged(object sender, EventArgs e) =>
            btn_search.Enabled = !String.IsNullOrEmpty(tb_registration.Text);
        private void btn_setName_Click(object sender, EventArgs e)
        {
            string update = String.Format(@"
				UPDATE tb_usuario
				SET nm_usuario = '{0}'
				WHERE cd_usuario = '{1}'",
                tb_name.Text, tb_registration.Text
            );
            Database.dml(update);
        }
        private void btn_setEmail_Click(object sender, EventArgs e)
        {
            string update = String.Format(@"
				UPDATE tb_usuario
				SET ds_email = '{0}'
				WHERE cd_usuario = '{1}'",
                tb_email.Text, tb_registration.Text
            );
            Database.dml(update);
        }
        private void btn_setCpf_Click(object sender, EventArgs e)
        {
            string update = String.Format(@"
				UPDATE tb_usuario
				SET cd_cpf = '{0}'
				WHERE cd_usuario = '{1}'",
                Globals.formatCPF(mtb_cpf.Text), tb_registration.Text
            );
            Database.dml(update);
        }
        private void tb_name_TextChanged(object sender, EventArgs e) =>
            btn_setName.Enabled = tb_name.Text.Length > 5 && tb_name.Enabled;
        private void tb_email_TextChanged(object sender, EventArgs e) =>
            btn_setEmail.Enabled = Globals.validaEmail(tb_email.Text) && mtb_cpf.Enabled;
        private void mtb_cpf_TextChanged(object sender, EventArgs e)
        {
            if (mtb_cpf.Text.Length == 14 && mtb_cpf.Enabled)
            {
                btn_setCpf.Enabled = Globals.validaCPF(Globals.formatCPF(mtb_cpf.Text));
                mtb_cpf.ForeColor = btn_setCpf.Enabled ? foreColorOK : foreColorErr;
            }
            else { mtb_cpf.ForeColor = foreColorErr; btn_setCpf.Enabled = false; }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            resetWindow();
            btn_loadLoans.Enabled = true;
            //2: prof, 3: func
            string type = rb_professor.Checked ? "2" : "3";
            string message = rb_professor.Checked ? "Professor" : "Funcionário";
            string select = String.Format(@"
				SELECT
					cd_cpf, ds_email, nm_usuario
				FROM
					tb_usuario
				WHERE
					cd_usuario = '{0}' AND ic_desativado = 1 AND ds_tipo = {1} 
				", tb_registration.Text, type
            );
            DataTable dt = Database.dql(select);
            if (dt.Rows.Count != 0)
            {
                tb_name.Text = dt.Rows[0].Field<string>("nm_usuario");
                tb_email.Text = dt.Rows[0].Field<string>("ds_email");
                mtb_cpf.Text = dt.Rows[0].Field<string>("cd_cpf");
                this._employee = new Employee(
                    tb_registration.Text,
                    Globals.formatCPF(mtb_cpf.Text),
                    tb_email.Text,
                    tb_name.Text
                );
            }
            else
            {
                MessageBox.Show(message + " não encontrado");
            }
        }
        private void tb_registration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Globals.keyIsNumber(e))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números");
            }
        }

        #endregion

        #region DATAGRIDVIEW CONTROLS

        private void btn_loadLoans_Click(object sender, EventArgs e)
        {
            _employee.LoadForfeitData(rb_professor.Checked);
            setNewLoanButtonEnabled();

            foreach (Employee.forfeit row in this._employee._forfeit)
            {
                dgv_Loans.Rows.Add(
                    row._book.title,
                    row._book.ibsn,
                    row._book.tombo,
                    row.start.ToString()
                );
            };
            btn_loadLoans.Enabled = false;
            refreshBoundaryStatus(
                rb_professor.Checked ? 
                Globals.prof_boundary : 
                Globals.func_boundary
            );
        }
        private void btn_returnBook_Click(object sender, EventArgs e)
        {
            byte index = (byte)dgv_Loans.CurrentCell.RowIndex;
            returnBook(index);
            _employee._forfeit.RemoveAt(index);
            dgv_Loans.Rows.RemoveAt(index);
            loadCB_books();
            refreshBoundaryStatus(
                rb_professor.Checked ? 
                Globals.prof_boundary : 
                Globals.func_boundary
            );
        }
        public void btn_sair_Click(object sender, EventArgs e)
        {
            if(_employee != null)
              _employee.Dispose();
            Close();
        }
        private void dgv_Loans_SelectionChanged(object sender, EventArgs e) =>
            btn_returnBook.Enabled = dgv_Loans.SelectedRows.Count != 0;

        #endregion

        #region NEW LOAN

        private void btn_showLoan_Click(object sender, EventArgs e)
        {
            setNewLoanControlsEnabled(true);

            loadCB_books();
            if (cb_books.SelectedValue == null) { return; }
            loadCB_tombo(cb_books.SelectedValue.ToString());
        }
        private void btn_newLoan_Click(object sender, EventArgs e)
        {
            getNewBook(rb_professor.Checked);
            cb_tombo.Items.RemoveAt(cb_tombo.SelectedIndex);
            cb_tombo.SelectedIndex = -1;
            cb_tombo.Text = "";
            cb_books.Text = "";
            refreshBoundaryStatus(
                rb_professor.Checked ? 
                Globals.prof_boundary : 
                Globals.func_boundary
            );
        }
        private void btn_clearLoan_Click(object sender, EventArgs e) => clearLoanControls();
        private void cb_tombo_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;
        private void cb_books_SelectedIndexChanged(object sender, EventArgs e) =>
            loadCB_tombo(cb_books.SelectedValue.ToString());
        private void cb_books_TextChanged(object sender, EventArgs e) =>
            btn_showLoan.Enabled = Globals.compare(books, cb_books.Text);
        private void cb_tombo_TextChanged(object sender, EventArgs e) =>
            btn_newLoan.Enabled = !String.IsNullOrEmpty(cb_tombo.Text);

        #endregion

        #region COMMON FUNCTIONS

        /// <summary>
        /// Controla a propriedade 'Enabled' dos componentes para novos empréstimos
        /// </summary>
        /// <param name="state"></param>
        public void setNewLoanControlsEnabled(bool state)
        {
            cb_books.Enabled = state;
            cb_tombo.Enabled = state;
            btn_clearLoan.Enabled = state;
        }

        /// <summary>
        /// Controla a propriedade 'Enabled' dos componentes para alteração de dados cadastrais
        /// </summary>
        /// <param name="state"></param>
        public void setEditControlsEnabled(bool state)
        {
            tb_name.Enabled = state;
            tb_email.Enabled = state;
            mtb_cpf.Enabled = state;
            btn_Clear.Enabled = state;
        }

        /// <summary>
        /// Ativa/ Desativa o botão "Novo empréstimo", de acordo com o total de livros na List<Forfeit>
        /// </summary>
        public void setNewLoanButtonEnabled()
		{
            btn_showLoan.Enabled = (
                rb_employee.Checked &&
                _employee._forfeit.Count < Convert.ToInt32(Globals.func_boundary)
            ) || (
                rb_professor.Checked &&
                _employee._forfeit.Count < Convert.ToInt32(Globals.prof_boundary)
            );
        }

        /// <summary>
        /// Limpa os componentes de novos empréstimos
        /// </summary>
        public void clearLoanControls()
        {
            cb_books.Text = "";
            cb_tombo.Text = "";
        }

        /// <summary>
        /// Limpa os componentes de alteração de dados cadastrais
        /// </summary>
        public void clearEditControls()
        {
            tb_name.Clear();
            tb_email.Clear();
            mtb_cpf.Clear();
        }

        /// <summary>
        /// Preenche o Dropdown List "livros"
        /// </summary>
        public void loadCB_books()
        {
            string select = String.Format(@"
				SELECT nm_titulo, cd_livro
				FROM tb_livro
				WHERE qt_exemplares > 1 AND ic_desativado = 0
			");
            DataTable dt = Database.dql(select);
            books.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                books.Add(
                    Convert.ToInt32(dt.Rows[i].Field<long>("cd_livro")),
                    dt.Rows[i].Field<string>("nm_titulo")
                );
            }
            if (books.Count == 0) { 
                MessageBox.Show("Não há livros disponíveis.");
                setNewLoanControlsEnabled(false);
                return; }
            cb_books.DataSource = new BindingSource(books, null);
            cb_books.DisplayMember = "Value";
            cb_books.ValueMember = "Key";
            dt.Dispose();
        }

        /// <summary>
        /// Preenche o Dropdown List "tombo"
        /// </summary>
        /// <param name="id"></param>
        public void loadCB_tombo(string id)
        {
            string select = String.Format(@"
				SELECT cd_tombo
				FROM tb_livro_unit
				WHERE cd_livro = '{0}'
                AND ic_disponivel = 1",
                id
            );
            DataTable dt = Database.dql(select);
            cb_tombo.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_tombo.Items.Add(
                    dt.Rows[i].Field<long>("cd_tombo").ToString()
                );
            }
            cb_tombo.Text = "";
            dt.Dispose();
        }

        /// <summary>
        /// Efetua a operação de empréstimo
        /// </summary>
        /// <param name="isProf"></param>
        public void getNewBook(bool isProf)
        {
            //1: Atualização no banco de dados
            long? boundary = isProf ? Globals.prof_boundary : Globals.func_boundary;
            string update = String.Format(@"
                UPDATE tb_livro
                SET qt_exemplares = (SELECT qt exemplares FROM tb_livro) - 1
                WHERE cd_livro = {0}",
                cb_books.SelectedValue
            );
            Database.dml(update);
            update = String.Format(@"
                UPDATE tb_livro_unit
                SET ic_disponivel = 0
                WHERE cd_tombo = {0}",
                cb_tombo.SelectedItem
            );
            Database.dml(update);
            string insert = String.Format(@"
                INSERT INTO tb_emprestimos
                (cd_usuario, cd_tombo, cd_configuracao, dt_inicio)
                VALUES
                ('{0}', {1}, {2}, DATETIME('NOW','LOCALTIME'))",
                _employee.getUserID(),
                cb_tombo.SelectedItem,
                Globals.id_config
            );

            //2: Atualização do DataGridView e da List<Forfeit>
            int index = _employee._forfeit.Count - 1;
            Database.dml(insert,
                "Operação bem sucedida. \n\nVocê possui " + (index + 2) .ToString() + "/" + boundary.ToString(),
                "Erro");
            addRowToForfeitList();
            dgv_Loans.Rows.Add(
                _employee._forfeit[index]._book.title,
                _employee._forfeit[index]._book.ibsn,
                _employee._forfeit[index]._book.tombo,
                _employee._forfeit[index].start.ToString()
            );
            setNewLoanControlsEnabled(false);
            setNewLoanButtonEnabled();
        }

        /// <summary>
        /// Efetua a operação de devolução
        /// </summary>
        /// <param name="index">Código do livro</param>
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
                (SELECT qt_exemplares FROM tb_livro WHERE nm_titulo = '{0}') + 1 
                WHERE cd_ibsn= '{1}'",
                _employee._forfeit[index]._book.title,
                _employee._forfeit[index]._book.ibsn
            );
            Database.dml(update);
            update = String.Format(@"
                UPDATE tb_emprestimos 
                SET dt_devolucao = DATETIME('NOW', 'LOCALTIME') 
                WHERE cd_emprestimo= {0}",
                _employee._forfeit[index].cd_emprestimo
            );
            Database.dml(update, "Devolução bem sucedida", "Erro");
            setNewLoanButtonEnabled();
        }

        /// <summary>
        /// Adiciona um novo item do tipo Forfeit(Empréstimo) na coleção List<Forfeit>
        /// </summary>
		public void addRowToForfeitList()
		{
            int index = _employee._forfeit.Count();
            Employee.forfeit f = new Employee.forfeit();
            Employee.book b = new Employee.book();
            DataTable dt = Database.dql("SELECT MAX(cd_emprestimo) FROM tb_emprestimos");
            f.cd_emprestimo = dt.Rows[0].Field<long>("MAX(cd_emprestimo)");
            dt = Database.dql("SELECT cd_ibsn FROM tb_livro WHERE cd_livro = " + cb_books.SelectedValue);
            b.ibsn = dt.Rows[0].Field<string>("cd_ibsn");
            b.tombo = cb_tombo.SelectedItem.ToString();
            b.title = cb_books.Text;
            f.start = DateTime.Now;
            f._book = b;

            _employee._forfeit.Add(f);
        }

        /// <summary>
        /// Redefine todos os campos da janela
        /// </summary>
        public void resetWindow()
        {
            clearLoanControls();
            setEditControlsEnabled(false);
            setNewLoanControlsEnabled(false);
            if (dgv_Loans.Rows.Count != 0) { dgv_Loans.Rows.Clear(); }
            btn_returnBook.Enabled = false;
            btn_newLoan.Enabled = false;
        }

        /// <summary>
        /// Atualiza a textbox "boundary"
        /// </summary>
        /// <param name="allowence">Valor do limite de empréstimos simultâneos</param>
        public void refreshBoundaryStatus(long? allowence)
        {
            tb_boundary.Text = String.Format(@"{0} / {1}",
                _employee._forfeit.Count.ToString(),
                allowence.ToString());
        }

        #endregion
    }
}
