
namespace TH2_ADONET
{
    partial class Bai01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbKetNoiServer = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grbChungThuc = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbtnSSA = new System.Windows.Forms.RadioButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.rbtnWA = new System.Windows.Forms.RadioButton();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lbDatabaseName = new System.Windows.Forms.Label();
            this.lb_ServerName = new System.Windows.Forms.Label();
            this.grbKetNoiServer.SuspendLayout();
            this.grbChungThuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKetNoiServer
            // 
            this.grbKetNoiServer.Controls.Add(this.btnDisconnect);
            this.grbKetNoiServer.Controls.Add(this.btnConnect);
            this.grbKetNoiServer.Controls.Add(this.grbChungThuc);
            this.grbKetNoiServer.Controls.Add(this.txtDatabaseName);
            this.grbKetNoiServer.Controls.Add(this.txtServerName);
            this.grbKetNoiServer.Controls.Add(this.lbDatabaseName);
            this.grbKetNoiServer.Controls.Add(this.lb_ServerName);
            this.grbKetNoiServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKetNoiServer.Location = new System.Drawing.Point(12, 12);
            this.grbKetNoiServer.Name = "grbKetNoiServer";
            this.grbKetNoiServer.Size = new System.Drawing.Size(514, 426);
            this.grbKetNoiServer.TabIndex = 0;
            this.grbKetNoiServer.TabStop = false;
            this.grbKetNoiServer.Text = "Kết nối Server";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(299, 378);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(104, 32);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(172, 378);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 32);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grbChungThuc
            // 
            this.grbChungThuc.Controls.Add(this.txtPassword);
            this.grbChungThuc.Controls.Add(this.rbtnSSA);
            this.grbChungThuc.Controls.Add(this.txtUserName);
            this.grbChungThuc.Controls.Add(this.lbPassword);
            this.grbChungThuc.Controls.Add(this.rbtnWA);
            this.grbChungThuc.Controls.Add(this.lbUsername);
            this.grbChungThuc.Location = new System.Drawing.Point(27, 125);
            this.grbChungThuc.Name = "grbChungThuc";
            this.grbChungThuc.Size = new System.Drawing.Size(459, 232);
            this.grbChungThuc.TabIndex = 4;
            this.grbChungThuc.TabStop = false;
            this.grbChungThuc.Text = "Chứng Thực";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 26);
            this.txtPassword.TabIndex = 10;
            // 
            // rbtnSSA
            // 
            this.rbtnSSA.AutoSize = true;
            this.rbtnSSA.Location = new System.Drawing.Point(24, 82);
            this.rbtnSSA.Name = "rbtnSSA";
            this.rbtnSSA.Size = new System.Drawing.Size(216, 24);
            this.rbtnSSA.TabIndex = 1;
            this.rbtnSSA.TabStop = true;
            this.rbtnSSA.Text = "SQL Server Authentication";
            this.rbtnSSA.UseVisualStyleBackColor = true;
            this.rbtnSSA.Click += new System.EventHandler(this.rbtnSSA_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(206, 131);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(170, 26);
            this.txtUserName.TabIndex = 9;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(57, 181);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(78, 20);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Password";
            // 
            // rbtnWA
            // 
            this.rbtnWA.AutoSize = true;
            this.rbtnWA.Location = new System.Drawing.Point(24, 38);
            this.rbtnWA.Name = "rbtnWA";
            this.rbtnWA.Size = new System.Drawing.Size(198, 24);
            this.rbtnWA.TabIndex = 0;
            this.rbtnWA.TabStop = true;
            this.rbtnWA.Text = "Windows Authentication";
            this.rbtnWA.UseVisualStyleBackColor = true;
            this.rbtnWA.Click += new System.EventHandler(this.rbtnWA_CheckedChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(57, 137);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(83, 20);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Username";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(172, 73);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(170, 26);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(172, 29);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(170, 26);
            this.txtServerName.TabIndex = 2;
            // 
            // lbDatabaseName
            // 
            this.lbDatabaseName.AutoSize = true;
            this.lbDatabaseName.Location = new System.Drawing.Point(23, 79);
            this.lbDatabaseName.Name = "lbDatabaseName";
            this.lbDatabaseName.Size = new System.Drawing.Size(125, 20);
            this.lbDatabaseName.TabIndex = 1;
            this.lbDatabaseName.Text = "Database Name";
            // 
            // lb_ServerName
            // 
            this.lb_ServerName.AutoSize = true;
            this.lb_ServerName.Location = new System.Drawing.Point(23, 35);
            this.lb_ServerName.Name = "lb_ServerName";
            this.lb_ServerName.Size = new System.Drawing.Size(101, 20);
            this.lb_ServerName.TabIndex = 0;
            this.lb_ServerName.Text = "Server Name";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.grbKetNoiServer);
            this.Name = "Bai01";
            this.Text = "Kết nối cơ sở dữ liệu";
            this.grbKetNoiServer.ResumeLayout(false);
            this.grbKetNoiServer.PerformLayout();
            this.grbChungThuc.ResumeLayout(false);
            this.grbChungThuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKetNoiServer;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grbChungThuc;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbtnSSA;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.RadioButton rbtnWA;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lbDatabaseName;
        private System.Windows.Forms.Label lb_ServerName;
    }
}

