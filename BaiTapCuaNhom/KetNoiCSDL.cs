using System;
using System.Collections.Generic;
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
    internal class KetNoiCSDL
    {
        private SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SinhVienGiuaKi;Persist Security Info=True;User ID=sa;Password=123456");

        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable TaoBang(String sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public int ThemSinhVien(String MaSV, String HoSV, String TenSV, DateTime NgaySinh, String GioiTinh, String MaKhoa, String AvartarDirec)
        {
            String sql = "Insert into SinhVien values(@MaSV, @HoSV, @TenSV, @NgaySinh, @GioiTinh, @MaKhoa, @Avartar)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaSV" ,MaSV);
            cmd.Parameters.AddWithValue("@HoSV", HoSV);
            cmd.Parameters.AddWithValue("@TenSV", TenSV);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh.ToShortDateString());
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@MaKhoa", MaKhoa);

            byte[] imageData = null;
            using (FileStream fs = new FileStream(AvartarDirec, FileMode.Open, FileAccess.Read))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }
            cmd.Parameters.AddWithValue("@Avartar", imageData);

            return cmd.ExecuteNonQuery();
        }
        public int XoaSinhVien(String MaSV)
        {
            String sql = "DELETE FROM SinhVien" +
                " WHERE MaSV = @MaSV";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlParameter prMaSV = new SqlParameter("@MaSV", SqlDbType.Int);
            prMaSV.Value = MaSV;
            cmd.Parameters.Add(prMaSV);

            return cmd.ExecuteNonQuery();
        }
        public int SuaSinhVien(String MaSV, String HoSV, String TenSV, DateTime NgaySinh, String GioiTinh, String MaKhoa, String AvartarDirec)
        {
            String sql;
            SqlCommand cmd;

            if (AvartarDirec != "")
            {
                sql = "UPDATE SinhVien" +
                    " SET HoSV=@HoSV, TenSV=@TenSV, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, MaKhoa=@MaKhoa, Avartar=@Avartar" +
                    " WHERE MaSV = @MaSV";

                cmd = new SqlCommand (sql, conn);

                byte[] imageData = null;
                using (FileStream fs = new FileStream(AvartarDirec, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                }

                cmd.Parameters.AddWithValue("@Avartar", imageData);
            }
            else
            {
                sql = "UPDATE SinhVien" +
                    " SET HoSV=@HoSV, TenSV=@TenSV, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, MaKhoa=@MaKhoa" +
                    " WHERE MaSV = @MaSV";

                cmd = new SqlCommand (sql, conn);
            }

            cmd.Parameters.AddWithValue("@MaSV", MaSV);
            cmd.Parameters.AddWithValue("@HoSV", HoSV);
            cmd.Parameters.AddWithValue("@TenSV", TenSV);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh.ToShortDateString());
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@MaKhoa", MaKhoa);

            return cmd.ExecuteNonQuery();
        }
    }
}
