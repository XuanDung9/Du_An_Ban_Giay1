using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Persentation_Layer.Frm.Frm_Dialog
{
    public partial class SoLuongMua : Form
    {
        public int soLuong;
        public SoLuongMua()
        {
            InitializeComponent();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoLuong_Click(object sender, EventArgs e)
        {
            try
            {
                soLuong = int.Parse(txtSoLuong.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show(" Có lỗi xảy ra");
            }
        }

        private void SoLuongMua_Load(object sender, EventArgs e)
        {
            soLuong = new();
        }
    }
}
