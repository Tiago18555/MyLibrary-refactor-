using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace My_Library
{
    class Database
    {
        private static SQLiteConnection conexao;

		#region Generic Functions

		/// <summary>
		/// Para realizar a conexão com o banco SQLite
		/// </summary>
		/// <returns>Objeto de conexão do tipo SQLite aberta</returns>
		private static SQLiteConnection ConexaoBanco()
		{
			conexao = new SQLiteConnection("Data Source=" + Globals.path + Globals.data_base_name);
			conexao.Open();
			return conexao;
		}
		/// <summary>
		/// Para operações de SELECT
		/// </summary>
		/// <param name="sql"></param>
		/// <returns></returns>
		public static DataTable dql(string sql)
		{
			SQLiteDataAdapter da = null;
			DataTable dt = new DataTable();
			try
			{
				var vcon = ConexaoBanco();
				var cmd = vcon.CreateCommand();
				{
					cmd.CommandText = sql;
					da = new SQLiteDataAdapter(cmd.CommandText, vcon);
					da.Fill(dt);
					vcon.Close();
					return dt;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
		/// <summary>
		/// Para operações de INSERT, UPDATE e DELETE
		/// </summary>
		/// <param name="_query"></param>
		/// <param name="msgOK"></param>
		/// <param name="msgErro"></param>
		public static void dml(string _query, string msgOK = null, string msgErro = null)
		{
			try
			{
				var vcon = ConexaoBanco();
				var cmd = vcon.CreateCommand();
				{
					cmd.CommandText = _query;
					cmd.ExecuteNonQuery();
					vcon.Close();
				}
				if (msgOK != null)
					MessageBox.Show(msgOK);
			}
			catch (Exception err)
			{
				if (msgErro != null)
					MessageBox.Show(msgErro = "\n" + err);
			}
		}

        #endregion
    }
}
