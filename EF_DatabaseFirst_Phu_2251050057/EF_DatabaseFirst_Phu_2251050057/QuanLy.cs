using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DatabaseFirst_Phu_2251050057
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            using (var db = new QLSVEntities())
            {
                dgvSinhVien.DataSource = db.SinhViens.ToList();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var db = new QLSVEntities())
            {
                var sv = new SinhVien()
                {
                    SV_Name = txtHoTen.Text,
                    SV_Phone = txtSDT.Text,
                    SV_Email = txtEmail.Text
                };
                db.SinhViens.Add(sv);
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["SV_ID"].Value);
                using (var db = new QLSVEntities())
                {
                    var sv = db.SinhViens.Find(id);
                    if (sv != null)
                    {
                        sv.SV_Name = txtHoTen.Text;
                        sv.SV_Phone = txtSDT.Text;
                        sv.SV_Email = txtEmail.Text;
                        db.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["SV_ID"].Value);
                using (var db = new QLSVEntities())
                {
                    var sv = db.SinhViens.Find(id);
                    if (sv != null)
                    {
                        db.SinhViens.Remove(sv);
                        db.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                txtHoTen.Text = dgvSinhVien.CurrentRow.Cells["SV_Name"].Value.ToString();
                txtSDT.Text = dgvSinhVien.CurrentRow.Cells["SV_Phone"].Value.ToString();
                txtEmail.Text = dgvSinhVien.CurrentRow.Cells["SV_Email"].Value.ToString();
            }
        }


    }
}
