using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;



namespace De02
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến cơ sở dữ liệu
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QLSanpham1;Integrated Security=True";


        // Khởi tạo SqlConnection
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadLoaiSP(); // Tải dữ liệu LoaiSP khi khởi động form
            LoadSanPham(); // Tải dữ liệu Sanpham khi khởi động form
            string queryLoaiSP = "SELECT * FROM LoaiSP";
            string querySanpham = "SELECT * FROM Sanpham";
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("vi-VN");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("vi-VN");
            

            

        }

        private bool isEditing = false;

        private void LoadLoaiSP()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM LoaiSP";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbloaisp.Items.Add(new KeyValuePair<string, string>(
                        reader["MaLoai"].ToString(),
                        reader["TenLoai"].ToString()));
                }
           
                cbloaisp.DisplayMember = "Value";
                cbloaisp.ValueMember = "Key";
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadSanPham()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Sanpham";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    lvSanpham.DataSource = table; // Gán dữ liệu cho DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void txtmasp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttensp_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbloaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbloaisp.SelectedItem != null)
            {
                var selectedPair = (KeyValuePair<string, string>)cbloaisp.SelectedItem;
                MessageBox.Show($"Mã Loại: {selectedPair.Key}, Tên Loại: {selectedPair.Value}");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Bạn có chắc chắn muốn thoát không?",
       "Xác nhận thoát",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {
                this.Close(); // Thoát ứng dụng
            }
        }

        private void btkluu_Click(object sender, EventArgs e)
        {

            isEditing = false;
            UpdateButtonState();

            // Khôi phục dữ liệu ban đầu
          

            MessageBox.Show("Các thay đổi đã bị hủy.");
        }

        private void UpdateButtonVisibility()
        {
            btluu.Visible = isEditing;   // Hiển thị nút Lưu nếu đang Thêm/Sửa/Xóa
            btkluu.Visible = isEditing; // Hiển thị nút Không lưu nếu đang Thêm/Sửa/Xóa
        }

        private void UpdateButtonState()
        {
            btluu.Enabled = isEditing;   // Chỉ cho phép nhấn nút Lưu khi đang Thêm/Xóa/Sửa
            btkluu.Enabled = isEditing; // Chỉ cho phép nhấn nút Không Lưu khi đang Thêm/Xóa/Sửa
        }

        

        private void btluu_Click(object sender, EventArgs e)
        {
            isEditing = false;
            UpdateButtonState();

            MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.");
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    string query = "DELETE FROM Sanpham WHERE MaSP = @MaSP";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaSP", txtmasp.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    LoadSanPham();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbloaisp.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn một loại sản phẩm!");
                    return;
                }

                connection.Open();
                string query = "UPDATE Sanpham SET TenSP = @TenSP, MaLoai = @MaLoai WHERE MaSP = @MaSP";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSP", txtmasp.Text);
                command.Parameters.AddWithValue("@TenSP", txttensp.Text);
                command.Parameters.AddWithValue("@MaLoai", ((KeyValuePair<string, string>)cbloaisp.SelectedItem).Key);
                command.Parameters.AddWithValue("@NgayNhap", dtngaynhap.Value); // Giá trị từ DateTimePicker

                command.ExecuteNonQuery();
                MessageBox.Show("Sửa sản phẩm thành công!");
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Sanpham (MaSP, TenSP, NgayNhap, MaLoai) VALUES (@MaSP, @TenSP, @NgayNhap, @MaLoai)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSP", txtmasp.Text);
                command.Parameters.AddWithValue("@TenSP", txttensp.Text);
                command.Parameters.AddWithValue("@NgayNhap", DateTime.Now); // Hoặc lấy từ DateTimePicker
                command.Parameters.AddWithValue("@MaLoai", ((KeyValuePair<string, string>)cbloaisp.SelectedItem).Key);

                command.ExecuteNonQuery();
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadSanPham();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            isEditing = true;
            UpdateButtonState(); // Kích hoạt nút Lưu và Không Lưu
            txtmasp.Text = "";
            txttensp.Text = "";
            cbloaisp.SelectedIndex = -1;
            dtngaynhap.Value = DateTime.Now;
        }

        private void dtngaynhap_ValueChanged(object sender, EventArgs e)
        {
        }



        private void lvSanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = lvSanpham.Rows[e.RowIndex];

                txtmasp.Text = row.Cells["MaSP"].Value.ToString();
                txttensp.Text = row.Cells["TenSP"].Value.ToString();
                cbloaisp.SelectedValue = row.Cells["MaLoai"].Value.ToString();

                // Hiển thị ngày nhập
                if (row.Cells["NgayNhap"].Value != DBNull.Value)
                {
                    dtngaynhap.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value);
                }
                else
                {
                    dtngaynhap.Value = DateTime.Now; // Mặc định ngày hiện tại
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}