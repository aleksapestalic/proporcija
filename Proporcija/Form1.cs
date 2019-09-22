using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proporcija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bDoIt_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(tbLG.Text); // LG = LEVO-GORE
                double x2 = double.Parse(tbDG.Text);
                double y1 = double.Parse(tbLD.Text);
                double xRez = 0;

                if (rbDir.Checked) xRez = (x2 * y1) / x1;
                if (rbObr.Checked) xRez = (x1 * x2) / y1;

                lRes.Text = xRez.ToString("0.00");

            }
            catch (Exception)
            {
                MessageBox.Show("Params incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
