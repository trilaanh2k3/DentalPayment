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
    public partial class DentalPayment : Form
    {
        public DentalPayment()
        {
            InitializeComponent();
        }
        public bool CheckNull()
        {
            if(txtTenKhach.Text == "" || (chbCaoVoi.Checked == false && chbChupHinhRang.Checked == false 
                && chbTayTrang.Checked == false && nudTramRang.Value <= 0))
            {
                return true;
            }
            return false;
        }
        public double TinhTien()
        {
            double tong = 0, tienCaoVoi = 0, tienTayTrang = 0, tienChupHinh = 0, tienTramRang = 0;
            if(chbCaoVoi.Checked == true)
            {
                tienCaoVoi = double.Parse(lblTienCaoVoi.Text.Replace(".", string.Empty));
            }
            if(chbTayTrang.Checked == true)
            {
                tienTayTrang = double.Parse(lblTienTayTrang.Text.Replace(".", string.Empty));
            }
            if (chbChupHinhRang.Checked == true)
            {
                tienChupHinh = double.Parse(lblTienChupHinhRang.Text.Replace(".", string.Empty));
            }
            if(nudTramRang.Value > 0)
            {
                tienTramRang = double.Parse(nudTramRang.Value.ToString()) * double.Parse(lblTienTramRang.Text.Replace(".", string.Empty).Replace("/cái", string.Empty));

            }
            tong = tienCaoVoi + tienTayTrang + tienChupHinh + tienTramRang;
            return tong;
        }
        private void btnTongTien_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                MessageBox.Show("Nhap day du thong tin!!", "Thong Bao");
            }
            else
            {
                lblTongTien.Text = string.Empty;
                lblTongTien.Text = TinhTien().ToString();
            }
            ghiThongTin();
        }
        public void ghiThongTin()
        {
            ListViewItem item = new ListViewItem(txtTenKhach.Text);
            item.SubItems.Add(TinhTien().ToString());
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                if (item.SubItems.Count >= 2)
                {
                    txtTenKhach.Text = item.SubItems[0].Text;
                    lblTongTien.Text = item.SubItems[1].Text;
                }
                else
                {
                    // Handle the case where the selected item doesn't have enough sub-items.
                    txtTenKhach.Text = "";
                    lblTongTien.Text = "";
                }
            }
            else
            {
                // Handle the case where no items are selected.
                txtTenKhach.Text = "";
                lblTongTien.Text = "";
            }
        }
        public void ChangeMdiParentProperty(string newValue1, string newValue2, string newValue3, string newValue4)
        {
            
            if (this.Text != null)
            {
                if (newValue2 != "")
                    this.lblTienChupHinhRang.Text = newValue2;
                //if (newValue1 != "")
                    this.lblTienCaoVoi.Text = newValue1;
                if (newValue3 != "")
                    this.lblTienTayTrang.Text = newValue3;
                if (newValue4 != "")
                    this.lblTienTramRang.Text = newValue4;
            }
            
        }
        private void txtSuaGia_Click(object sender, EventArgs e)
        {
            BangSuaGia bang = new BangSuaGia();
            bang.MdiParent = this.MdiParent;
            bang.Show();
            ChangeMdiParentProperty(bang.txtTienCaoVoi.Text, bang.txtTienChupHinhRang.Text, bang.txtTienTayTrang.Text, bang.txtTienTramRang.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DentalPayment_Load(object sender, EventArgs e)
        {
            lblTienCaoVoi.Text = "100.000";
            lblTienChupHinhRang.Text = "200.000";
            lblTienTayTrang.Text = "1.200.000";
        }
    }
}
