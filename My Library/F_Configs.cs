using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Library
{
    public partial class F_Configs : Form
    {
        public F_Configs()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e) => this.Close();

        private void F_Configs_Load(object sender, EventArgs e)
        {
            tb_allowence.Text = Globals.allowence.ToString();
            mtb_value.Text = 
                String.Format("{0:f2}", Globals.value.ToString());
            tb_funcBoundary.Text = Globals.func_boundary.ToString();
            tb_profBoundary.Text = Globals.prof_boundary.ToString();

            cb_theme.Items.Add("Claro");
            cb_theme.Items.Add("Escuro");
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            update_tb_configs();
            update_configFile(cb_theme.Text);
            F_SplashScreen.loadForfeitConfigs();
            F_SplashScreen.loadThemeData();
            btn_apply.Enabled = false;
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            tb_allowence.Text = "20";
            mtb_value.Text = "5";
            tb_funcBoundary.Text = "5";
            tb_profBoundary.Text = "15";
            cb_theme.SelectedIndex = 1;
        }

        private void tb_funcBoundary_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Globals.keyIsNumber(e);

        private void tb_profBoundary_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Globals.keyIsNumber(e);

        private void tb_allowence_KeyPress(object sender, KeyPressEventArgs e) =>        
            e.Handled = Globals.keyIsNumber(e);
        
        public string formatValue(string value)
        {
            return value.Replace("R$", "").Replace(",", ".");
        }
        public void setBtnApplyEnabled()
        {
            btn_apply.Enabled =
                !String.IsNullOrEmpty(tb_allowence.Text) &&
                !String.IsNullOrEmpty(mtb_value.Text.Replace("R$","").Replace(",","")) &&
                !String.IsNullOrEmpty(tb_funcBoundary.Text) &&
                !String.IsNullOrEmpty(tb_profBoundary.Text);
        }
        public void update_tb_configs()
        {
            string update = String.Format(@"
                UPDATE tb_configs 
                SET dt_fim = DATETIME('NOW', 'LOCALTIME') 
                WHERE cd_configuracao = (SELECT MAX(cd_configuracao) FROM tb_configs)"
            );
            Database.dml(update);
            string insert = String.Format(@"
                INSERT INTO tb_configs
                (vl_multa, qt_tolerancia, dt_inicio, dt_fim, qt_limite_prof, qt_limite_func)
                VALUES ({0}, {1}, DATETIME('NOW', 'LOCALTIME'), NULL, {2}, {3})",
                formatValue(mtb_value.Text),
                tb_allowence.Text,
                tb_profBoundary.Text,
                tb_funcBoundary.Text
            );
            Database.dml(insert);
        }
        public void update_configFile(string theme)
        {
            if(theme == "Claro")
            {
                string newTemplate = String
                    .Format(@"
                        * *CONFIGURAÇÕES * *


                        theme : {0},
                        autoCompleteLogin: {1},
                        genericFontColor: 000.000.000,
                        titleFontColor: 080.080.080,
                        genericBackgroundColor: 255.255.255,
                        forecolorOK: 000.255.000,
                        forecolorERR: 255.000.000



                        Made by Tiago18555
                        www.github.com / Tiago18555
                    ", theme, Globals.autoCompleteUserName)
                    .Replace("                    ", "");
                File.WriteAllText("themes.configs", newTemplate);
            }
            else if(theme == "Escuro")
            {
                string newTemplate = String
                    .Format(@"
                        * *CONFIGURAÇÕES * *


                        theme : {0},
                        autoCompleteLogin: {1},
                        genericFontColor: 255.255.255,
                        titleFontColor: 175.175.175,
                        genericBackgroundColor: 000.000.000,
                        forecolorOK: 150.255.150,
                        forecolorERR: 255.150.150



                        Made by Tiago18555
                        www.github.com / Tiago18555
                    ", theme, Globals.autoCompleteUserName)
                    .Replace("                    ", "");
                File.WriteAllText("themes.configs", newTemplate);
            }
        }

        private void tb_funcBoundary_TextChanged(object sender, EventArgs e) => setBtnApplyEnabled();
        private void tb_profBoundary_TextChanged(object sender, EventArgs e) => setBtnApplyEnabled();
        private void tb_allowence_TextChanged(object sender, EventArgs e) => setBtnApplyEnabled();
        private void mtb_value_TextChanged(object sender, EventArgs e) => setBtnApplyEnabled();
    }
}
