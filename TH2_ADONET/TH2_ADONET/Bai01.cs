﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TH2_ADONET
{
    public partial class Bai01 : Form
    {
        private SqlConnection connection;

        public Bai01()
        {
            InitializeComponent();
        }

        private void rbtnWA_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = rbtnSSA.Checked;
            txtPassword.Enabled = rbtnSSA.Checked;
        }

        private void rbtnSSA_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = rbtnSSA.Checked;
            txtPassword.Enabled = rbtnSSA.Checked;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServerName.Text) || string.IsNullOrWhiteSpace(txtDatabaseName.Text))
            {
                MessageBox.Show("Vui lòng nhập Server Name và Database Name!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbtnSSA.Checked && (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                MessageBox.Show("Vui lòng nhập User Name và Password cho SQL Server Authentication!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString;
            if (rbtnWA.Checked)
            {
                connectionString = $"Server={txtServerName.Text};Database={txtDatabaseName.Text};Trusted_Connection=True;";
            }
            else
            {
                connectionString = $"Server={txtServerName.Text};Database={txtDatabaseName.Text};User Id={txtUserName.Text};Password={txtPassword.Text};";
            }

            // Initialize the connection if not already initialized
            if (connection == null || connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection = new SqlConnection(connectionString);
            }

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                    MessageBox.Show("Kết nối thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnConnect.Enabled = false; // Disable Connect button
                    btnDisconnect.Enabled = true; // Enable Disconnect button
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection?.Dispose();
                connection = null;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
                MessageBox.Show("Đã ngắt kết nối!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConnect.Enabled = true; // Re-enable Connect button
                btnDisconnect.Enabled = false; // Disable Disconnect button
            }
            else
            {
                MessageBox.Show("Không có kết nối đang hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Ensure connection is closed when the form closes
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
            base.OnFormClosing(e);
        }
    }
}