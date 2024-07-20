using A_Persentation_Layer.Frm.Frm_Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Persentation_Layer.Frm.Frm_US
{
    public partial class Frm_US_SanPham : UserControl
    {
        public Frm_US_SanPham()
        {
            InitializeComponent();
        }

        private void ptbGiay_Click(object sender, EventArgs e)
        {

        }

        private void ptbChatLieu_Click(object sender, EventArgs e)
        {
            ChatLieu_form frm_chatLieu = new ChatLieu_form();
            frm_chatLieu.ShowDialog();
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptbKichCo_Click(object sender, EventArgs e)
        {
            KichCo_form frm_kichCo = new KichCo_form();
            frm_kichCo.ShowDialog();
        }

        private void ptbThemThuongHieu_Click(object sender, EventArgs e)
        {
            ThuongHieu_form frm_thuongHieu = new ThuongHieu_form();
            frm_thuongHieu.ShowDialog();
        }

        private void ptbKieuDang_Click(object sender, EventArgs e)
        {
            KieuDang_form kieuDang_Form = new KieuDang_form();
            kieuDang_Form.ShowDialog();
        }

        private void ptbMauSac_Click(object sender, EventArgs e)
        {
            MauSac_form mauSac_frm = new MauSac_form();
            mauSac_frm.ShowDialog();    
        }
    }
}
