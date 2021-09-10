using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Library
{
    public abstract class Client
    {
        protected string id { get; set; }
        protected string cpf { get; set; }
        protected string email { get; set; }
        protected string name { get; set; }
        public struct book
        {
            public string title;
            public string ibsn;
            public string tombo;
        }
    }
    public class Student : Client, IDisposable
    {
        public List<forfeit> _forfeit;
		private bool disposedValue;

		public struct forfeit
        {
            public decimal value;
            public DateTime? deadline;
            public DateTime end;
            public DateTime start;
            public long delay;
            public book _book;
            public long cd_emprestimo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_cpf"></param>
        /// <param name="_email"></param>
        /// <param name="_name"></param>
		public Student(string _id, string _cpf, string _email, string _name)
		{
            id = _id;
            cpf = _cpf;
            email = _email;
            name = _name;
		}
        /// <summary>
        /// Carrega informações de empréstimos em structs "book" e "forfeit"
        /// </summary>
		public void LoadForfeitData()
		{
            book b = new book();
            forfeit f = new forfeit();
            this._forfeit = new List<forfeit>();
            string select = String.Format(@"
                SELECT 
                    e.dt_inicio, e.dt_fim, e.cd_emprestimo
                    CAST((JULIANDAY(e.dt_fim) - JULIANDAY(DATETIME('NOW', 'LOCALTIME'))) AS INTEGER) AS atraso,
                    c.vl_multa,
                    lu.cd_tombo,
                    l.nm_titulo, l.cd_ibsn, l.cd_livro
                FROM 
                    tb_emprestimos AS e
                INNER JOIN 
                    tb_configs AS c ON c.cd_configuracao = e.cd_configuracao
                INNER JOIN
                    tb_livro_unit AS lu ON lu.cd_tombo = e.cd_tombo
                INNER JOIN
                    tb_livro AS l ON l.cd_livro = lu.cd_livro
                WHERE
                    cd_usuario = 1 AND dt_devolucao IS NULL;
                ", this.id);
            DataTable dt = Database.dql(select);
            for(byte i = 0; i < dt.Rows.Count; i++)
			{
                b.tombo = dt.Rows[i].Field<long>("cd_tombo").ToString();
                b.title = dt.Rows[i].Field<string>("nm_titulo");
                b.ibsn = dt.Rows[i].Field<string>("cd_ibsn");

                f.start = dt.Rows[i].Field<DateTime>("dt_inicio");
                f.end = dt.Rows[i].Field<DateTime>("dt_fim");
                f.delay = dt.Rows[i].Field<long>("atraso");
                f.value = calcValue(dt.Rows[i].Field<decimal>("vl_multa"), f.delay);

                f.cd_emprestimo = dt.Rows[i].Field<long>("cd_emprestimo");
                f._book = b;

                this._forfeit.Add(f);
			}
        }

        /// <summary>
        /// Retorna 0 se o tempo de atraso for posotivo, caso contrário retorna o valor da multa diária * dias de atraso
        /// </summary>
        /// <param name="value"></param>
        /// <param name="atraso"></param>
        /// <returns></returns>
		public decimal calcValue(decimal value, long atraso) => atraso < 0 ? Math.Abs(atraso) * Math.Round(value, 2) : 0;
		public virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// Tarefa pendente: descartar o estado gerenciado (objetos gerenciados)
				}

				// Tarefa pendente: liberar recursos não gerenciados (objetos não gerenciados) e substituir o finalizador
				// Tarefa pendente: definir campos grandes como nulos
				disposedValue = true;
			}
		}
		public void Dispose()
		{
			// Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
    public class Professor : Client, IDisposable
    {
        private List<book> _book;
		private bool disposedValue;
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// Tarefa pendente: descartar o estado gerenciado (objetos gerenciados)
				}

				// Tarefa pendente: liberar recursos não gerenciados (objetos não gerenciados) e substituir o finalizador
				// Tarefa pendente: definir campos grandes como nulos
				disposedValue = true;
			}
		}

		public void Dispose()
		{
			// Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
