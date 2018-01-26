namespace MaHoa.GUI
{
    partial class ucMaHoaDichVong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMaHoaDichVong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGMSinhKhoaNgauNhien = new DevExpress.XtraEditors.SimpleButton();
            this.txtGMBanRo = new System.Windows.Forms.TextBox();
            this.txtGMBanMa = new System.Windows.Forms.TextBox();
            this.txtGMKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGiaiMa = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMHSinhKhoaNgauNhien = new DevExpress.XtraEditors.SimpleButton();
            this.txtMHBanMa = new System.Windows.Forms.TextBox();
            this.txtMHBanRo = new System.Windows.Forms.TextBox();
            this.txtMHKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaHoa = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGMThamMa = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 668);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGMThamMa);
            this.groupBox2.Controls.Add(this.btnGMSinhKhoaNgauNhien);
            this.groupBox2.Controls.Add(this.txtGMBanRo);
            this.groupBox2.Controls.Add(this.txtGMBanMa);
            this.groupBox2.Controls.Add(this.txtGMKhoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnGiaiMa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(24, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 302);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giải mã";
            // 
            // btnGMSinhKhoaNgauNhien
            // 
            this.btnGMSinhKhoaNgauNhien.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGMSinhKhoaNgauNhien.Appearance.Options.UseFont = true;
            this.btnGMSinhKhoaNgauNhien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnGMSinhKhoaNgauNhien.Image = ((System.Drawing.Image)(resources.GetObject("btnGMSinhKhoaNgauNhien.Image")));
            this.btnGMSinhKhoaNgauNhien.Location = new System.Drawing.Point(750, 63);
            this.btnGMSinhKhoaNgauNhien.Name = "btnGMSinhKhoaNgauNhien";
            this.btnGMSinhKhoaNgauNhien.Size = new System.Drawing.Size(178, 38);
            this.btnGMSinhKhoaNgauNhien.TabIndex = 12;
            this.btnGMSinhKhoaNgauNhien.Text = "Sinh khóa ngẫu nhiên";
            this.btnGMSinhKhoaNgauNhien.Click += new System.EventHandler(this.btnGMSinhKhoaNgauNhien_Click);
            // 
            // txtGMBanRo
            // 
            this.txtGMBanRo.Location = new System.Drawing.Point(128, 181);
            this.txtGMBanRo.Multiline = true;
            this.txtGMBanRo.Name = "txtGMBanRo";
            this.txtGMBanRo.Size = new System.Drawing.Size(596, 87);
            this.txtGMBanRo.TabIndex = 11;
            // 
            // txtGMBanMa
            // 
            this.txtGMBanMa.Location = new System.Drawing.Point(128, 92);
            this.txtGMBanMa.Multiline = true;
            this.txtGMBanMa.Name = "txtGMBanMa";
            this.txtGMBanMa.Size = new System.Drawing.Size(596, 66);
            this.txtGMBanMa.TabIndex = 10;
            // 
            // txtGMKhoa
            // 
            this.txtGMKhoa.Location = new System.Drawing.Point(128, 37);
            this.txtGMKhoa.Name = "txtGMKhoa";
            this.txtGMKhoa.Size = new System.Drawing.Size(269, 24);
            this.txtGMKhoa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bản mã :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Khóa :";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiMa.Appearance.Options.UseFont = true;
            this.btnGiaiMa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnGiaiMa.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaiMa.Image")));
            this.btnGiaiMa.Location = new System.Drawing.Point(750, 19);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(178, 38);
            this.btnGiaiMa.TabIndex = 6;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bản rõ :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMHSinhKhoaNgauNhien);
            this.groupBox1.Controls.Add(this.txtMHBanMa);
            this.groupBox1.Controls.Add(this.txtMHBanRo);
            this.groupBox1.Controls.Add(this.txtMHKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMaHoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 282);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hóa dịch Vòng";
            // 
            // btnMHSinhKhoaNgauNhien
            // 
            this.btnMHSinhKhoaNgauNhien.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMHSinhKhoaNgauNhien.Appearance.Options.UseFont = true;
            this.btnMHSinhKhoaNgauNhien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnMHSinhKhoaNgauNhien.Image = ((System.Drawing.Image)(resources.GetObject("btnMHSinhKhoaNgauNhien.Image")));
            this.btnMHSinhKhoaNgauNhien.Location = new System.Drawing.Point(750, 63);
            this.btnMHSinhKhoaNgauNhien.Name = "btnMHSinhKhoaNgauNhien";
            this.btnMHSinhKhoaNgauNhien.Size = new System.Drawing.Size(178, 38);
            this.btnMHSinhKhoaNgauNhien.TabIndex = 9;
            this.btnMHSinhKhoaNgauNhien.Text = "Sinh khóa ngẫu nhiên";
            this.btnMHSinhKhoaNgauNhien.Click += new System.EventHandler(this.btnMHSinhKhoaNgauNhien_Click);
            // 
            // txtMHBanMa
            // 
            this.txtMHBanMa.Location = new System.Drawing.Point(128, 181);
            this.txtMHBanMa.Multiline = true;
            this.txtMHBanMa.Name = "txtMHBanMa";
            this.txtMHBanMa.Size = new System.Drawing.Size(596, 76);
            this.txtMHBanMa.TabIndex = 8;
            // 
            // txtMHBanRo
            // 
            this.txtMHBanRo.Location = new System.Drawing.Point(128, 92);
            this.txtMHBanRo.Multiline = true;
            this.txtMHBanRo.Name = "txtMHBanRo";
            this.txtMHBanRo.Size = new System.Drawing.Size(596, 66);
            this.txtMHBanRo.TabIndex = 7;
            // 
            // txtMHKey
            // 
            this.txtMHKey.Location = new System.Drawing.Point(128, 37);
            this.txtMHKey.Name = "txtMHKey";
            this.txtMHKey.Size = new System.Drawing.Size(269, 24);
            this.txtMHKey.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bản rõ :";
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoa.Appearance.Options.UseFont = true;
            this.btnMaHoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnMaHoa.Image = ((System.Drawing.Image)(resources.GetObject("btnMaHoa.Image")));
            this.btnMaHoa.Location = new System.Drawing.Point(750, 19);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(178, 38);
            this.btnMaHoa.TabIndex = 5;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khóa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bản mã :";
            // 
            // btnGMThamMa
            // 
            this.btnGMThamMa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGMThamMa.Appearance.Options.UseFont = true;
            this.btnGMThamMa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnGMThamMa.Image = ((System.Drawing.Image)(resources.GetObject("btnGMThamMa.Image")));
            this.btnGMThamMa.Location = new System.Drawing.Point(750, 107);
            this.btnGMThamMa.Name = "btnGMThamMa";
            this.btnGMThamMa.Size = new System.Drawing.Size(178, 38);
            this.btnGMThamMa.TabIndex = 13;
            this.btnGMThamMa.Text = "Thám mã";
            this.btnGMThamMa.Click += new System.EventHandler(this.btnGMThamMa_Click);
            // 
            // ucMaHoaDichVong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMaHoaDichVong";
            this.Size = new System.Drawing.Size(986, 668);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnGiaiMa;
        private DevExpress.XtraEditors.SimpleButton btnMaHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGMBanRo;
        private System.Windows.Forms.TextBox txtGMBanMa;
        private System.Windows.Forms.TextBox txtGMKhoa;
        private DevExpress.XtraEditors.SimpleButton btnMHSinhKhoaNgauNhien;
        private System.Windows.Forms.TextBox txtMHBanMa;
        private System.Windows.Forms.TextBox txtMHBanRo;
        private System.Windows.Forms.TextBox txtMHKey;
        private DevExpress.XtraEditors.SimpleButton btnGMSinhKhoaNgauNhien;
        private DevExpress.XtraEditors.SimpleButton btnGMThamMa;
    }
}
