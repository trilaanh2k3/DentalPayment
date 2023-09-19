using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinhMinhTri_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dentalPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DentalPayment frm = new DentalPayment();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
