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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }
        public ChildForm(string imageFile)
        {
            InitializeComponent();
            ptbImage.Image = Image.FromFile(imageFile);
            Text = imageFile.Substring(imageFile.LastIndexOf('\\') + 1);
        }
    }
}
