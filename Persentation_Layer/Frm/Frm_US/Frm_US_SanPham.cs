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
    }
}
