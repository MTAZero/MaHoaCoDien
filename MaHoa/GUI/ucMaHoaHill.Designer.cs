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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnGiaiMa.Location = new System.Drawing.Point(750, 154);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(178, 38);
            this.btnGiaiMa.TabIndex = 6;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnMHSinhKhoaNgauNhien);
            this.groupBox1.Controls.Add(this.txtMHBanMa);
            this.groupBox1.Controls.Add(this.txtMHBanRo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMaHoa);
            this.groupBox1.Controls.Add(this.btnGiaiMa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 613);
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
            this.btnMHSinhKhoaNgauNhien.Location = new System.Drawing.Point(750, 204);
            this.btnMHSinhKhoaNgauNhien.Name = "btnMHSinhKhoaNgauNhien";
            this.btnMHSinhKhoaNgauNhien.Size = new System.Drawing.Size(178, 38);
            this.btnMHSinhKhoaNgauNhien.TabIndex = 9;
            this.btnMHSinhKhoaNgauNhien.Text = "Sinh khóa ngẫu nhiên";
            this.btnMHSinhKhoaNgauNhien.Click += new System.EventHandler(this.btnMHSinhKhoaNgauNhien_Click);
            // 
            // txtMHBanMa
            // 
            this.txtMHBanMa.Location = new System.Drawing.Point(183, 116);
            this.txtMHBanMa.Multiline = true;
            this.txtMHBanMa.Name = "txtMHBanMa";
            this.txtMHBanMa.Size = new System.Drawing.Size(548, 76);
            this.txtMHBanMa.TabIndex = 8;
            // 
            // txtMHBanRo
            // 
            this.txtMHBanRo.Location = new System.Drawing.Point(183, 27);
            this.txtMHBanRo.Multiline = true;
            this.txtMHBanRo.Name = "txtMHBanRo";
            this.txtMHBanRo.Size = new System.Drawing.Size(548, 66);
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
            this.btnMaHoa.Location = new System.Drawing.Point(750, 108);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(178, 38);
            this.btnMaHoa.TabIndex = 5;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bản mã :";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(29, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 262);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khóa ";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(480, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 262);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khóa nghịch đảo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 76);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bản rõ sau khi giải mã :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(750, 253);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(178, 38);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Tính ma trận nghịch đảo";
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
