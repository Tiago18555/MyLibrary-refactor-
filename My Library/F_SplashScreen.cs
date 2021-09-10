using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
