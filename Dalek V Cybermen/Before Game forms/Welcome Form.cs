using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dalek_V_Cybermen.Before_Game_forms
{
    public partial class Welcome_Form : Form
    {
        bool wasClicked = false;
        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void beginBTN_Click(object sender, EventArgs e)
        {
            wasClicked = true;
        }

        private void loadingBarTimer_Tick(object sender, EventArgs e)
        {
            if (wasClicked == true)
            {
                loadingBarProBar.Visible = true;
                beginBTN.Visible = false;

                loadingBarTimer.Enabled = true;
                loadingBarProBar.Increment(50);

                if (loadingBarProBar.Value == 100)
                {
                    loadingBarTimer.Enabled = false;

                    this.Hide();
                    Login_Form lf = new Login_Form();
                    lf.Show();
                }
            }
        }
    }
}
