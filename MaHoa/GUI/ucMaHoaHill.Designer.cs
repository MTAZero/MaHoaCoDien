namespace MaHoa.GUI
{
    partial class ucMaHoaHill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMaHoaHill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGiaiMa = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMHSinhKhoaNgauNhien = new DevExpress.XtraEditors.SimpleButton();
            this.txtMHBanMa = new System.Windows.Forms.TextBox();
            this.txtMHBanRo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaHoa = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupKhoa = new System.Windows.Forms.GroupBox();
            this.groupNghichDao = new System.Windows.Forms.GroupBox();
            this.txtBanGiaiMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhMaTranNghichDao = new DevExpress.XtraEditors.SimpleButton();
            this.panelGroupKhoa = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGroupNghichDaoKhoa = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.numRowCount = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupKhoa.SuspendLayout();
            this.groupNghichDao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRowCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 668);
            this.panel1.TabIndex = 0;
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiMa.Appearance.Options.UseFont = true;
            this.btnGiaiMa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnGiaiMa.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaiMa.Image")));
            this.btnGiaiMa.Location = new System.Drawing.Point(750, 73);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(178, 38);
            this.btnGiaiMa.TabIndex = 6;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numRowCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTinhMaTranNghichDao);
            this.groupBox1.Controls.Add(this.txtBanGiaiMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupNghichDao);
            this.groupBox1.Controls.Add(this.groupKhoa);
            this.groupBox1.Controls.Add(this.btnMHSinhKhoaNgauNhien);
            this.groupBox1.Controls.Add(this.txtMHBanMa);
            this.groupBox1.Controls.Add(this.txtMHBanRo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMaHoa);
            this.groupBox1.Controls.Add(this.btnGiaiMa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 633);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hóa dịch Hill";
            // 
            // btnMHSinhKhoaNgauNhien
            // 
            this.btnMHSinhKhoaNgauNhien.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMHSinhKhoaNgauNhien.Appearance.Options.UseFont = true;
            this.btnMHSinhKhoaNgauNhien.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnMHSinhKhoaNgauNhien.Image = ((System.Drawing.Image)(resources.GetObject("btnMHSinhKhoaNgauNhien.Image")));
            this.btnMHSinhKhoaNgauNhien.Location = new System.Drawing.Point(750, 123);
            this.btnMHSinhKhoaNgauNhien.Name = "btnMHSinhKhoaNgauNhien";
            this.btnMHSinhKhoaNgauNhien.Size = new System.Drawing.Size(178, 38);
            this.btnMHSinhKhoaNgauNhien.TabIndex = 9;
            this.btnMHSinhKhoaNgauNhien.Text = "Sinh khóa ngẫu nhiên";
            this.btnMHSinhKhoaNgauNhien.Click += new System.EventHandler(this.btnMHSinhKhoaNgauNhien_Click);
            // 
            // txtMHBanMa
            // 
            this.txtMHBanMa.Location = new System.Drawing.Point(183, 96);
            this.txtMHBanMa.Multiline = true;
            this.txtMHBanMa.Name = "txtMHBanMa";
            this.txtMHBanMa.Size = new System.Drawing.Size(548, 63);
            this.txtMHBanMa.TabIndex = 8;
            // 
            // txtMHBanRo
            // 
            this.txtMHBanRo.Location = new System.Drawing.Point(183, 27);
            this.txtMHBanRo.Multiline = true;
            this.txtMHBanRo.Name = "txtMHBanRo";
            this.txtMHBanRo.Size = new System.Drawing.Size(548, 56);
            this.txtMHBanRo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
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
            this.btnMaHoa.Location = new System.Drawing.Point(750, 27);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(178, 38);
            this.btnMaHoa.TabIndex = 5;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bản mã :";
            // 
            // groupKhoa
            // 
            this.groupKhoa.Controls.Add(this.panelGroupKhoa);
            this.groupKhoa.Location = new System.Drawing.Point(32, 312);
            this.groupKhoa.Name = "groupKhoa";
            this.groupKhoa.Size = new System.Drawing.Size(424, 306);
            this.groupKhoa.TabIndex = 10;
            this.groupKhoa.TabStop = false;
            this.groupKhoa.Text = "Khóa ";
            // 
            // groupNghichDao
            // 
            this.groupNghichDao.Controls.Add(this.panelGroupNghichDaoKhoa);
            this.groupNghichDao.Location = new System.Drawing.Point(476, 312);
            this.groupNghichDao.Name = "groupNghichDao";
            this.groupNghichDao.Size = new System.Drawing.Size(430, 306);
            this.groupNghichDao.TabIndex = 11;
            this.groupNghichDao.TabStop = false;
            this.groupNghichDao.Text = "Khóa nghịch đảo";
            // 
            // txtBanGiaiMa
            // 
            this.txtBanGiaiMa.Location = new System.Drawing.Point(183, 172);
            this.txtBanGiaiMa.Multiline = true;
            this.txtBanGiaiMa.Name = "txtBanGiaiMa";
            this.txtBanGiaiMa.Size = new System.Drawing.Size(548, 76);
            this.txtBanGiaiMa.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bản rõ sau khi giải mã :";
            // 
            // btnTinhMaTranNghichDao
            // 
            this.btnTinhMaTranNghichDao.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhMaTranNghichDao.Appearance.Options.UseFont = true;
            this.btnTinhMaTranNghichDao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnTinhMaTranNghichDao.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhMaTranNghichDao.Image")));
            this.btnTinhMaTranNghichDao.Location = new System.Drawing.Point(750, 172);
            this.btnTinhMaTranNghichDao.Name = "btnTinhMaTranNghichDao";
            this.btnTinhMaTranNghichDao.Size = new System.Drawing.Size(178, 38);
            this.btnTinhMaTranNghichDao.TabIndex = 14;
            this.btnTinhMaTranNghichDao.Text = "Tính ma trận nghịch đảo";
            this.btnTinhMaTranNghichDao.Click += new System.EventHandler(this.btnTinhMaTranNghichDao_Click);
            // 
            // panelGroupKhoa
            // 
            this.panelGroupKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGroupKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroupKhoa.Location = new System.Drawing.Point(3, 20);
            this.panelGroupKhoa.Name = "panelGroupKhoa";
            this.panelGroupKhoa.Size = new System.Drawing.Size(418, 283);
            this.panelGroupKhoa.TabIndex = 0;
            // 
            // panelGroupNghichDaoKhoa
            // 
            this.panelGroupNghichDaoKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGroupNghichDaoKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroupNghichDaoKhoa.Location = new System.Drawing.Point(3, 20);
            this.panelGroupNghichDaoKhoa.Name = "panelGroupNghichDaoKhoa";
            this.panelGroupNghichDaoKhoa.Size = new System.Drawing.Size(424, 283);
            this.panelGroupNghichDaoKhoa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số cột của khóa :";
            // 
            // numRowCount
            // 
            this.numRowCount.Location = new System.Drawing.Point(183, 272);
            this.numRowCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numRowCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRowCount.Name = "numRowCount";
            this.numRowCount.Size = new System.Drawing.Size(120, 24);
            this.numRowCount.TabIndex = 16;
            this.numRowCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRowCount.ValueChanged += new System.EventHandler(this.numRowCount_ValueChanged);
            // 
            // ucMaHoaHill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMaHoaHill";
            this.Size = new System.Drawing.Size(986, 668);
            this.Load += new System.EventHandler(this.ucMaHoaHill_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupKhoa.ResumeLayout(false);
            this.groupNghichDao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRowCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnGiaiMa;
        private DevExpress.XtraEditors.SimpleButton btnMaHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnMHSinhKhoaNgauNhien;
        private System.Windows.Forms.TextBox txtMHBanMa;
        private System.Windows.Forms.TextBox txtMHBanRo;
        private System.Windows.Forms.GroupBox groupNghichDao;
        private System.Windows.Forms.GroupBox groupKhoa;
        private System.Windows.Forms.TextBox txtBanGiaiMa;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnTinhMaTranNghichDao;
        private System.Windows.Forms.FlowLayoutPanel panelGroupKhoa;
        private System.Windows.Forms.FlowLayoutPanel panelGroupNghichDaoKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRowCount;
    }
}
