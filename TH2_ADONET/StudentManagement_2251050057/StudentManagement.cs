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

namespace StudentManagement_2251050057
{
    public partial class StudentManagement : Form
    {
        private StudentManager studentManager;

        public StudentManagement()
        {
            InitializeComponent();
            studentManager = new StudentManager();
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                dgvStudents.DataSource = studentManager.GetStudentsDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtMajor.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và chuyên ngành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Vui lòng nhập tuổi hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                studentManager.AddStudent(txtFullName.Text, age, txtMajor.Text);
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudents();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtMajor.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và chuyên ngành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Vui lòng nhập tuổi hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);
            try
            {
                studentManager.UpdateStudent(studentID, txtFullName.Text, age, txtMajor.Text);
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudents();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    studentManager.DeleteStudent(studentID);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                txtFullName.Text = dgvStudents.SelectedRows[0].Cells["FullName"].Value.ToString();
                txtAge.Text = dgvStudents.SelectedRows[0].Cells["Age"].Value.ToString();
                txtMajor.Text = dgvStudents.SelectedRows[0].Cells["Major"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtFullName.Clear();
            txtAge.Clear();
            txtMajor.Clear();
        }
    }
}