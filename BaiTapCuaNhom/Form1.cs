using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCuaNhom
{
    public partial class Form1 : Form
    {
        private KetNoiCSDL ketNoiCSDL = new KetNoiCSDL();
        public Form1()
        {
            InitializeComponent();
        }
        public void ResetForm()
        {
            ketNoiCSDL.Open();
            foreach(Control control in pnNhapThongTin.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ComboBox cbb = (ComboBox) control;
                    cbb.SelectedIndex = -1;
                }
            }
            foreach (Control control in pnFilter.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cbb = (ComboBox) control;
                    cbb.SelectedIndex = -1;
                }
            }

            LoadDanhSach();

            pnNhapThongTin.Enabled = false;
            pnFilter.Enabled = false;

            tbButInProg.Text = "0";

            foreach (Control control in pnButton.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false;
                }
            }
            btnThem.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
            ketNoiCSDL.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void LoadDanhSach()
        {
            String sql = "Select * From SinhVien";
            dgvDs.DataSource = ketNoiCSDL.TaoBang(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            pnNhapThongTin.Enabled = true;
            btnLuu.Enabled = true;
            tbButInProg.Text = "1";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            tbButInProg.Text = "2";
            pnNhapThongTin.Enabled = true;
            tbMaSV.Enabled = false;
            btnLuu.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketNoiCSDL.Open();

            tbButInProg.Text = "3";
            int res = ketNoiCSDL.XoaSinhVien(tbMaSV.Text);

            ketNoiCSDL.Close();

            if (res > 0)
            {
                DialogResult dlRes = MessageBox.Show(
                    "Xóa sinh viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

                if (dlRes == DialogResult.OK)
                {
                    ResetForm();
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tbButInProg.Text == "1")
            {
                ketNoiCSDL.Open();
                int res = ketNoiCSDL.ThemSinhVien(tbMaSV.Text, tbHoSV.Text, tbTenSV.Text, dtpNgaySInh.Value, cbbGioiTinh.SelectedItem.ToString(), tbMaKhoa.Text, pbAvatar.ImageLocation);
                ketNoiCSDL.Close();

                if (res > 0)
                {
                    DialogResult dlRes = MessageBox.Show("thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    
                    if (dlRes == DialogResult.OK)
                    {
                        ResetForm();
                    }
                }
            }
            else if( tbButInProg.Text == "2")
            {
                ketNoiCSDL.Open();
                int res;

                if (tbCoClickChonAvartar.Text == "daclick")
                {
                    res = ketNoiCSDL.SuaSinhVien(tbMaSV.Text, tbHoSV.Text, tbTenSV.Text, dtpNgaySInh.Value, cbbGioiTinh.SelectedItem.ToString(), tbMaKhoa.Text, pbAvatar.ImageLocation);

                }
                else
                {
                    res = ketNoiCSDL.SuaSinhVien(tbMaSV.Text, tbHoSV.Text, tbTenSV.Text, dtpNgaySInh.Value, cbbGioiTinh.SelectedItem.ToString(), tbMaKhoa.Text, "");
                }

                ketNoiCSDL.Close();

                if (res > 0)
                {
                    DialogResult dlRes = MessageBox.Show("Sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (dlRes == DialogResult.OK)
                    {
                        tbCoClickChonAvartar.Text = "chuaclick";
                        ResetForm();
                    }
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnNhapThongTin.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;

            DataTable dt = (DataTable)dgvDs.DataSource;
            int chiSo = dgvDs.SelectedCells[0].RowIndex;
            DataRow dr = dt.Rows[chiSo];

            tbMaSV.Text = dr["MaSV"].ToString();
            tbHoSV.Text = dr["HoSV"].ToString();
            tbTenSV.Text = dr["TenSV"].ToString();
            dtpNgaySInh.Text = dr["NgaySinh"].ToString();
            cbbGioiTinh.Text = dr["GioiTinh"].ToString();
            tbMaKhoa.Text = dr["MaKhoa"].ToString();

            Image image = null;
            if (dgvDs.CurrentRow.Cells[6].Value != DBNull.Value)
            {
                image = ChuyenVeHinhAnh((byte[])dgvDs.CurrentRow.Cells[6].Value);
            }
            pbAvatar.Image = image;

            pnNhapThongTin.Enabled = false;
        }
        private Image ChuyenVeHinhAnh(byte[] hinh)
        {
            MemoryStream ms = new MemoryStream(hinh);
            Image result = Image.FromStream(ms);
            return result;
        }
        private void btnChonAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "jpg|*.jpg|png|*.png|gif|*.gif|All Files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                pbAvatar.ImageLocation = openFileDialog.FileName;
                tbCoClickChonAvartar.Text = openFileDialog.FileName;
                openFileDialog.Dispose();
            }

            tbCoClickChonAvartar.Text = "daclick";
        }
    }
}
