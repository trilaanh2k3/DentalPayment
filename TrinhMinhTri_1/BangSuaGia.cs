using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TrinhMinhTri_1
{
    public partial class BangSuaGia : Form
    {
        public BangSuaGia()
        {
            InitializeComponent();
        }

     

        private void BangSuaGia_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChangeParentPropertyFromChild(string newValue1, string newValue2, string newValue3, string newValue4)
        {
            
            if (this.MdiParent is DentalPayment mdiParentForm)
            {
                mdiParentForm.ChangeMdiParentProperty(newValue1, newValue2, newValue3, newValue4);
            }
            
        }

        private void btnDongYDoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thay đổi không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thay đổi thành công", "Thông báo");
                if (txtTienCaoVoi.Text != "")
                    lblTienCaoVoi.Text = txtTienCaoVoi.Text;
                if (txtTienChupHinhRang.Text != "")
                    lblChupHinhRang.Text = txtTienChupHinhRang.Text;
                if (txtTienTayTrang.Text != "")
                    lblTienTayTrang.Text = txtTienTayTrang.Text;
                if (txtTienTramRang.Text != "")
                    lblTramRang.Text = txtTienTramRang.Text;


            }
            else MessageBox.Show("Thay đổi không thành công", "Thông báo");
        }
    }
}
