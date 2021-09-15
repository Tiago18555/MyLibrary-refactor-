using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.IO;
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
            loadThemeData();
            load.Start();
            loadForfeitConfigs();
        }
        private void goToLogin(object obj)
        {
            Application.Run(new F_Login(Globals.autoCompleteUserName));
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

        /// <summary>
        /// Verifica os arquivos de configuração
        /// </summary>
		public static void loadThemeData()
		{
            string filepath = Globals.sys_path + "\\themes.configs";

            if (File.Exists(filepath))            
                readFile(filepath);            
            else
            {
                backupFile();
                readFile(filepath);
            }

        }

        /// <summary>
        /// Cria um arquivo themes.config padrão
        /// </summary>
        private static void backupFile()
        {
            string filetemplate = String
                .Format(@"
                    **CONFIGURAÇÕES**


                    theme : Claro,
                    autoCompleteLogin: root,
                    genericFontColor: 000.000.000,
                    titleFontColor: 080.080.080,
                    genericBackgroundColor: 255.255.255,
                    forecolorOK: 000.255.000,
                    forecolorERR: 255.000.000



                    Made by Tiago18555
                    www.github.com/Tiago18555
                ")
                .Replace("                    ", "");
            File.WriteAllText("themes.configs", filetemplate);
        }

        /// <summary>
        /// Lê o arquivo themes.config e seta as variáveis globals correspondentes
        /// </summary>
        /// <param name="filepath"></param>
        private static void readFile(string filepath)
        {
            string readedText = File.ReadAllText(filepath);
            Regex acl_pattern = new Regex(@"(?<=autoCompleteLogin:+[\s])[\w]{4,50}");
            Globals.autoCompleteUserName =
                acl_pattern.IsMatch(readedText) ?
                acl_pattern.Matches(readedText)[0].Value :
                null;

            Regex themePattern = new Regex(@"(?m)(?<=colorOK:+[\s]|colorERR:+[\s]|Color:+[\s])[\w\.]{11}");

            int[,] v = new int[6, 3];
            for (int i = 0; i < themePattern.Matches(readedText).Count; i++)
            {
                string[] rgb = themePattern.Matches(readedText)[i].Value.Split('.');
                for (int j = 0; j < rgb.Length; j++)
                {
                    v[i, j] = int.Parse(rgb[j]);
                }
            }
            Globals.genericFontColor = Color.FromArgb(v[0, 0], v[0, 1], v[0, 2]);
            Globals.titleFontColor = Color.FromArgb(v[1, 0], v[1, 1], v[1, 2]);
            Globals.genericBackgroundColor = Color.FromArgb(v[2, 0], v[2, 1], v[2, 2]);
            Globals.forecolorOK = Color.FromArgb(v[3, 0], v[3, 1], v[3, 2]);
            Globals.forecolorERR = Color.FromArgb(v[4, 0], v[4, 1], v[4, 2]);
        }

        /// <summary>
        /// Carrega as configurações gerais com o banco de dados
        /// </summary>
        public static void loadForfeitConfigs()
		{
            string select = String.Format(@"
                SELECT * FROM tb_configs
                WHERE cd_configuracao = (SELECT MAX(cd_configuracao) FROM tb_configs)
            ");
            DataTable dt = Database.dql(select);
            Globals.id_config = dt.Rows[0].Field<long?>("cd_configuracao");
            Globals.value = dt.Rows[0].Field<decimal>("vl_multa");
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
