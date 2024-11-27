using B_Bussiness_Layer.Services;
using C_Data_Access_Layer.Models;
using C_Data_Access_Layer.Models.ModelRefer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Giay_form : Form
    {
        GiayService _service = new GiayService();
        List<Giay> lst_Giay = new List<Giay>();
        int idClicked;
        int maTaiKhoan;
        public Giay_form()
        {
            InitializeComponent();
        }
        public bool CheckData()
        {
            if (txtTen.Text == "" || XacThucDangNhap.Instance.IdTaiKhoan == 0)
            {
                return false;
            }
            return true;
        }
        private void Giay_form_Load(object sender, EventArgs e)
        {
            LoadData(null, null);
            SerchType_CBB();
        }
        private void SerchType_CBB()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add(SearchType.All);
            cbbTimKiem.Items.Add(SearchType.tenGiay);
            cbbTimKiem.SelectedIndex = 0; // mặc định thằng ko được chọn là all
        }
        private void LoadData(string? txtTimKiem, string? SearchType)
        {
            dgv_Objects.Rows.Clear();
            dgv_Objects.ColumnCount = 2;
            dgv_Objects.Columns[0].Name = "STT";
            dgv_Objects.Columns[1].Name = "Tên"; ;
            lst_Giay = _service.GetAll(txtTimKiem, SearchType);
            foreach (var item in lst_Giay)
            {
                int stt = lst_Giay.IndexOf(item) + 1;

                dgv_Objects.Rows.Add(stt, item.Tengiay);
            }
        }

        public void ClearTextBox()
        {
            txtTen.Text = "";
            txtTimKiem.Text = "";
        }

        private void dgv_Objects_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || index >= lst_Giay.Count)
            {
                ClearTextBox();
                return;
            }

            var objCellClick = lst_Giay[index];

            idClicked = objCellClick.Magiay;
            txtTen.Text = objCellClick.Tengiay;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            bool result;
            if (CheckData())
            {
                var confirmResult = MessageBox.Show("Xác nhận THÊM", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var existingProduct = _service.GetAll(null, null)
                            .FirstOrDefault(p =>
                                p.Tengiay == txtTen.Text);
                    if (existingProduct != null)
                    {
                        MessageBox.Show("Tên giày đã tồn tại!");
                        result = false;
                    }
                    else
                    {
                        result = _service.Them(new Giay()
                        {
                            Tengiay = txtTen.Text
                        });

                    }


                    if (result)
                    {
                        MessageBox.Show("THÊM thành công");

                        LoadData(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Thêm' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'THÊM' ");
                }
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lý!");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (CheckData())
            {
                var confirmResult = MessageBox.Show("Xác nhận SỬA", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _service.Sua(idClicked, new Giay()
                    {
                        Tengiay = txtTen.Text,
                    });

                    if (result)
                    {
                        LoadData(null, null);
                    }
                    else
                    {
                        MessageBox.Show("SỬA thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy SỬA");
                }
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lý!");
            }
            ClearTextBox();
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text, cbbTimKiem.Text);
        }
    }
}
