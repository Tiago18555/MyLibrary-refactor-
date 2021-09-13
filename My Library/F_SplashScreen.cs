using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace My_Library
{
    public partial class F_SplashScreen : Form
    {
        public F_SplashScreen()
        {
            InitializeComponent();
        }

        private void F_SplashScreen_Load(object sender, EventArgs e)
        {
            pb_load.Value = 100;
            
            load.Interval = 100;
            loadForfeitConfigs();
            loadThemeData();
            load.Start();
        }
        private void goToLogin(object obj)
        {
            Application.Run(new F_Login());
        }

        private void pb_load_Click(object sender, EventArgs e)
        {

        }

        private async void load_Tick(object sender, EventArgs e)
        {
            if (pb_load.Value == 100)
            {
                Thread JanelaII;
                JanelaII = new Thread(goToLogin);
                load.Stop();
                await Task.Delay(400);
                JanelaII.SetApartmentState(ApartmentState.STA);
                JanelaII.Start();
                this.Close();
            }
            else
            {
                pb_load.Value += 2;
            }
        }

        private void pb_load_Validated(object sender, EventArgs e)
        {

        }

        private void lb_p_Click(object sender, EventArgs e)
        {

        }
		public void loadThemeData()
		{

		}
        public void loadForfeitConfigs()
		{
            string select = String.Format(@"
                SELECT * FROM tb_configs
                WHERE cd_configuracao = (SELECT MAX(cd_configuracao) FROM tb_configs)
            ");
            DataTable dt = Database.dql(select);
            Globals.id_config = dt.Rows[0].Field<long?>("cd_configuracao");
            Globals.value = dt.Rows[0].Field<decimal?>("vl_multa");
            Globals.allowence = dt.Rows[0].Field<int?>("qt_tolerancia");
            Globals.startsAt = dt.Rows[0].Field<DateTime?>("dt_inicio");
            Globals.endsAt = dt.Rows[0].Field<DateTime?>("dt_fim");
            Globals.func_boundary = dt.Rows[0].Field<int?>("qt_limite_func");
            Globals.prof_boundary = dt.Rows[0].Field<int?>("qt_limite_prof");
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
