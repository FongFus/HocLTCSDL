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
using System.Configuration;

namespace TH2_ADONET
{
    public partial class Bai02 : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        private DataTable categoriesTable;
        private DataTable suppliersTable;

        public Bai02()
        {
            InitializeComponent();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy chuỗi kết nối từ app.config
                string connectionString = ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString;

                // Tạo kết nối
                connection = new SqlConnection(connectionString);

                // Tải dữ liệu cho DataGridView từ bảng Products
                dataTable = new DataTable();
                string query = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock, CategoryID, SupplierID FROM Products";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }

                // Thêm cột CategoryName và CompanyName vào DataTable
                if (!dataTable.Columns.Contains("CategoryName"))
                    dataTable.Columns.Add("CategoryName", typeof(string));
                if (!dataTable.Columns.Contains("CompanyName"))
                    dataTable.Columns.Add("CompanyName", typeof(string));

                // Tải dữ liệu cho ComboBox Loại sản phẩm
                string categoryQuery = "SELECT CategoryID, CategoryName FROM Categories";
                using (SqlDataAdapter categoryAdapter = new SqlDataAdapter(categoryQuery, connection))
                {
                    categoriesTable = new DataTable();
                    categoryAdapter.Fill(categoriesTable);
                    if (categoriesTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu danh mục sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        categoriesTable.Rows.Add(-1, "Không xác định");
                    }
                    cbLoaiSanPham.DataSource = categoriesTable;
                    cbLoaiSanPham.DisplayMember = "CategoryName";
                    cbLoaiSanPham.ValueMember = "CategoryID";
                    cbLoaiSanPham.SelectedIndex = -1;
                }

                // Tải dữ liệu cho ComboBox Nhà cung cấp
                string supplierQuery = "SELECT SupplierID, CompanyName FROM Suppliers";
                using (SqlDataAdapter supplierAdapter = new SqlDataAdapter(supplierQuery, connection))
                {
                    suppliersTable = new DataTable();
                    supplierAdapter.Fill(suppliersTable);
                    if (suppliersTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        suppliersTable.Rows.Add(-1, "Không xác định");
                    }
                    cbNhaCungCap.DataSource = suppliersTable;
                    cbNhaCungCap.DisplayMember = "CompanyName";
                    cbNhaCungCap.ValueMember = "SupplierID";
                    cbNhaCungCap.SelectedIndex = -1;
                }

                // Cập nhật DataGridView với tên
                UpdateDataGridViewWithNames();

                // Tùy chỉnh tiêu đề cột
                dgvThongTinChung.Columns["ProductID"].HeaderText = "Mã sản phẩm";
                dgvThongTinChung.Columns["ProductName"].HeaderText = "Tên sản phẩm";
                dgvThongTinChung.Columns["UnitPrice"].HeaderText = "Đơn giá";
                dgvThongTinChung.Columns["UnitsInStock"].HeaderText = "Số lượng"; // Thay đổi tiêu đề thành "Số lượng"
                dgvThongTinChung.Columns["CategoryID"].Visible = false;
                dgvThongTinChung.Columns["SupplierID"].Visible = false;
                dgvThongTinChung.Columns["CategoryName"].HeaderText = "Loại sản phẩm";
                dgvThongTinChung.Columns["CompanyName"].HeaderText = "Nhà cung cấp";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridViewWithNames()
        {
            try
            {
                if (categoriesTable == null || suppliersTable == null)
                {
                    MessageBox.Show("Dữ liệu danh mục hoặc nhà cung cấp không khả dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["CategoryID"] != DBNull.Value)
                    {
                        int categoryId = Convert.ToInt32(row["CategoryID"]);
                        var category = categoriesTable.AsEnumerable()
                            .FirstOrDefault(c => c.Field<int>("CategoryID") == categoryId);
                        row["CategoryName"] = category != null ? category.Field<string>("CategoryName") : "Không khớp";
                    }
                    if (row["SupplierID"] != DBNull.Value)
                    {
                        int supplierId = Convert.ToInt32(row["SupplierID"]);
                        var supplier = suppliersTable.AsEnumerable()
                            .FirstOrDefault(s => s.Field<int>("SupplierID") == supplierId);
                        row["CompanyName"] = supplier != null ? supplier.Field<string>("CompanyName") : "Không khớp";
                    }
                }

                dgvThongTinChung.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThongTinChung_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinChung.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvThongTinChung.SelectedRows[0];
                    txtTenSP.Text = row.Cells["ProductName"].Value?.ToString() ?? "";
                    txtDonGia.Text = row.Cells["UnitPrice"].Value?.ToString() ?? "";
                    txtSoLuong.Text = row.Cells["UnitsInStock"].Value?.ToString() ?? ""; // Sử dụng UnitsInStock

                    if (row.Cells["CategoryID"].Value != null && row.Cells["CategoryID"].Value != DBNull.Value && categoriesTable != null)
                    {
                        cbLoaiSanPham.SelectedValue = Convert.ToInt32(row.Cells["CategoryID"].Value);
                    }
                    else
                    {
                        cbLoaiSanPham.SelectedIndex = -1;
                    }

                    if (row.Cells["SupplierID"].Value != null && row.Cells["SupplierID"].Value != DBNull.Value && suppliersTable != null)
                    {
                        cbNhaCungCap.SelectedValue = Convert.ToInt32(row.Cells["SupplierID"].Value);
                    }
                    else
                    {
                        cbNhaCungCap.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenSP.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) || cbLoaiSanPham.SelectedValue == null ||
                    cbNhaCungCap.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mở kết nối
                connection.Open();

                // Tạo câu lệnh SQL INSERT với tham số và lấy SCOPE_IDENTITY()
                string insertQuery = "INSERT INTO Products (ProductName, UnitPrice, UnitsInStock, CategoryID, SupplierID) " + // Sử dụng UnitsInStock
                                    "VALUES (@ProductName, @UnitPrice, @UnitsInStock, @CategoryID, @SupplierID); " +
                                    "SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductName", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(txtDonGia.Text));
                    cmd.Parameters.AddWithValue("@UnitsInStock", Convert.ToInt32(txtSoLuong.Text)); // Sử dụng UnitsInStock
                    cmd.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(cbLoaiSanPham.SelectedValue));
                    cmd.Parameters.AddWithValue("@SupplierID", Convert.ToInt32(cbNhaCungCap.SelectedValue));

                    // Thực thi truy vấn và lấy ProductID mới
                    object result = cmd.ExecuteScalar();
                    int newProductId = result != null ? Convert.ToInt32(result) : -1;

                    if (newProductId > 0)
                    {
                        // Cập nhật DataTable và DataGridView
                        DataRow newRow = dataTable.NewRow();
                        newRow["ProductID"] = newProductId;
                        newRow["ProductName"] = txtTenSP.Text;
                        newRow["UnitPrice"] = Convert.ToDecimal(txtDonGia.Text);
                        newRow["UnitsInStock"] = Convert.ToInt32(txtSoLuong.Text); // Sử dụng UnitsInStock
                        newRow["CategoryID"] = Convert.ToInt32(cbLoaiSanPham.SelectedValue);
                        newRow["SupplierID"] = Convert.ToInt32(cbNhaCungCap.SelectedValue);
                        var category = categoriesTable.AsEnumerable()
                            .FirstOrDefault(c => c.Field<int>("CategoryID") == Convert.ToInt32(cbLoaiSanPham.SelectedValue));
                        newRow["CategoryName"] = category != null ? category.Field<string>("CategoryName") : "Không khớp";
                        var supplier = suppliersTable.AsEnumerable()
                            .FirstOrDefault(s => s.Field<int>("SupplierID") == Convert.ToInt32(cbNhaCungCap.SelectedValue));
                        newRow["CompanyName"] = supplier != null ? supplier.Field<string>("CompanyName") : "Không khớp";
                        dataTable.Rows.Add(newRow);

                        MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinChung.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenSP.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) || cbLoaiSanPham.SelectedValue == null ||
                    cbNhaCungCap.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dgvThongTinChung.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                // Mở kết nối
                connection.Open();

                // Tạo câu lệnh SQL UPDATE với tham số
                string updateQuery = "UPDATE Products SET ProductName = @ProductName, UnitPrice = @UnitPrice, " +
                                    "UnitsInStock = @UnitsInStock, CategoryID = @CategoryID, SupplierID = @SupplierID " + // Sử dụng UnitsInStock
                                    "WHERE ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@ProductName", txtTenSP.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(txtDonGia.Text));
                    cmd.Parameters.AddWithValue("@UnitsInStock", Convert.ToInt32(txtSoLuong.Text)); // Sử dụng UnitsInStock
                    cmd.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(cbLoaiSanPham.SelectedValue));
                    cmd.Parameters.AddWithValue("@SupplierID", Convert.ToInt32(cbNhaCungCap.SelectedValue));

                    // Thực thi truy vấn
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Cập nhật DataTable
                        DataRow row = dataTable.Rows.Cast<DataRow>().First(r => Convert.ToInt32(r["ProductID"]) == productId);
                        row["ProductName"] = txtTenSP.Text;
                        row["UnitPrice"] = Convert.ToDecimal(txtDonGia.Text);
                        row["UnitsInStock"] = Convert.ToInt32(txtSoLuong.Text); // Sử dụng UnitsInStock
                        row["CategoryID"] = Convert.ToInt32(cbLoaiSanPham.SelectedValue);
                        row["SupplierID"] = Convert.ToInt32(cbNhaCungCap.SelectedValue);
                        var category = categoriesTable.AsEnumerable()
                            .FirstOrDefault(c => c.Field<int>("CategoryID") == Convert.ToInt32(cbLoaiSanPham.SelectedValue));
                        row["CategoryName"] = category != null ? category.Field<string>("CategoryName") : "Không khớp";
                        var supplier = suppliersTable.AsEnumerable()
                            .FirstOrDefault(s => s.Field<int>("SupplierID") == Convert.ToInt32(cbNhaCungCap.SelectedValue));
                        row["CompanyName"] = supplier != null ? supplier.Field<string>("CompanyName") : "Không khớp";

                        MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinChung.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgvThongTinChung.SelectedRows[0];
                    int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);

                    // Kiểm tra xem sản phẩm có trong Order Details không
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM [Order Details] WHERE ProductID = @ProductID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productId);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Không thể xóa sản phẩm vì nó đã được sử dụng trong đơn hàng!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }
                    }

                    // Nếu không có ràng buộc, thực hiện xóa
                    string deleteQuery = "DELETE FROM Products WHERE ProductID = @ProductID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);

                        // Thực thi truy vấn
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Xóa khỏi DataTable
                            DataRow row = dataTable.Rows.Cast<DataRow>().First(r => Convert.ToInt32(r["ProductID"]) == productId);
                            row.Delete();
                            dataTable.AcceptChanges();

                            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtTimTenSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtTimTenSP.Text.Trim();
                if (string.IsNullOrEmpty(filterText))
                {
                    // Nếu không có từ khóa tìm kiếm, hiển thị toàn bộ dữ liệu
                    UpdateDataGridViewWithNames();
                }
                else
                {
                    // Lọc dữ liệu dựa trên tên sản phẩm
                    DataView dv = new DataView(dataTable);
                    dv.RowFilter = $"ProductName LIKE '%{filterText}%'";
                    dgvThongTinChung.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            cbLoaiSanPham.SelectedIndex = -1;
            cbNhaCungCap.SelectedIndex = -1;
        }
    }
}