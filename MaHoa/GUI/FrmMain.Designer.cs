namespace MaHoa.GUI
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHill = new System.Windows.Forms.RadioButton();
            this.rdVirgene = new System.Windows.Forms.RadioButton();
            this.rdDichVong = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 670);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(312, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(986, 668);
            this.panelMain.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHill);
            this.groupBox1.Controls.Add(this.rdVirgene);
            this.groupBox1.Controls.Add(this.rdDichVong);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại mã hóa";
            // 
            // rdHill
            // 
            this.rdHill.AutoSize = true;
            this.rdHill.Location = new System.Drawing.Point(44, 123);
            this.rdHill.Name = "rdHill";
            this.rdHill.Size = new System.Drawing.Size(95, 21);
            this.rdHill.TabIndex = 2;
            this.rdHill.TabStop = true;
            this.rdHill.Text = "Mã hóa Hill";
            this.rdHill.UseVisualStyleBackColor = true;
            this.rdHill.CheckedChanged += new System.EventHandler(this.rdDichVong_CheckedChanged);
            // 
            // rdVirgene
            // 
            this.rdVirgene.AutoSize = true;
            this.rdVirgene.Location = new System.Drawing.Point(44, 81);
            this.rdVirgene.Name = "rdVirgene";
            this.rdVirgene.Size = new System.Drawing.Size(121, 21);
            this.rdVirgene.TabIndex = 1;
            this.rdVirgene.TabStop = true;
            this.rdVirgene.Text = "Mã hóa Virgene";
            this.rdVirgene.UseVisualStyleBackColor = true;
            this.rdVirgene.CheckedChanged += new System.EventHandler(this.rdDichVong_CheckedChanged);
            // 
            // rdDichVong
            // 
            this.rdDichVong.AutoSize = true;
            this.rdDichVong.Location = new System.Drawing.Point(44, 39);
            this.rdDichVong.Name = "rdDichVong";
            this.rdDichVong.Size = new System.Drawing.Size(131, 21);
            this.rdDichVong.TabIndex = 0;
            this.rdDichVong.TabStop = true;
            this.rdDichVong.Text = "Mã hóa dịch vòng";
            this.rdDichVong.UseVisualStyleBackColor = true;
            this.rdDichVong.CheckedChanged += new System.EventHandler(this.rdDichVong_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 750);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Resizable = false;
            this.Text = "MÃ HÓA CỔ ĐIỂN";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDichVong;
        private System.Windows.Forms.RadioButton rdHill;
        private System.Windows.Forms.RadioButton rdVirgene;
        private System.Windows.Forms.Panel panelMain;
    }
}