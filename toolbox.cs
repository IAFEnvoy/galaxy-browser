using NeteaseMuisc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galaxy_browser
{
    public partial class toolbox : Form
    {
        public toolbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new musics();
            f.Show();
            while (f.Visible == true) Application.DoEvents();
            f.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new QR.QR();
            f.Show();
            while (f.Visible == true) Application.DoEvents();
            f.Dispose();
        }
    }
}
