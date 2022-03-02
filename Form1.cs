using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTRecovering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 1;
            if (panel1.Width >= 420)
            {
                timer1.Stop();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }

    }
}
