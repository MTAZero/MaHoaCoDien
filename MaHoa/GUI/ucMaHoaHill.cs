using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaHoa.Crypto;
using CSML;

namespace MaHoa.GUI
{
    public partial class ucMaHoaHill : UserControl
    {
        Matrix mt;
        #region Hàm khởi tạo
        public ucMaHoaHill()
        {
            InitializeComponent();
        }

        #endregion

        #region Sự kiện
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            txtMHBanRo.Text = txtMHBanRo.Text.ToUpper();
            string tz = txtMHBanRo.Text;
            string kz = "";
            for(int iz = 0; iz<tz.Length; iz++)
            {
                if (tz[iz] < 'A' || tz[iz] > 'Z') continue;
                kz = kz + tz[iz]; 
            }
            txtMHBanRo.Text = kz;

            if (txtMHBanRo.Text == "")
            {
                MessageBox.Show("Bản rõ đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra khóa
            int k = (int)numRowCount.Value;

            Matrix mt = new Matrix(k, k);
            /// tính lại mt
            foreach (var item in panelGroupKhoa.Controls)
            {
                TextBox z = item as TextBox;

                Point pos = (Point)z.Tag;
                if (pos.X > k || pos.Y > k) continue;

                int gt = 0;
                try
                {
                    gt = Int32.Parse(z.Text);
                }
                catch
                {
                    gt = 0;
                }
                mt[pos.X, pos.Y] = new Complex(gt);

            }

            if (!MaHoa.Crypto.Hill.ok(mt))
            {
                MessageBox.Show("Key chưa thỏa mãn. Không tồn tại ma trận nghịch đảo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMHBanMa.Text = Hill.encrypt(txtMHBanRo.Text, mt);
        }

        private void btnMHSinhKhoaNgauNhien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int k = (int)numRowCount.Value;

            if (k > 5)
            {
                MessageBox.Show("Chỉ có thể sinh mã có độ dài <=5", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (true)
            {
                mt = new Matrix(k, k);

                for (int i = 1; i <= k; i++)
                    for (int j = 1; j <= k; j++)
                    {
                        
                        int gt = rd.Next(9) + 1;
                        mt[i, j] = new Complex(gt);
                    }
                //break;
                if (MaHoa.Crypto.Hill.ok(mt) && MaHoa.Crypto.Hill.ok(mt.Inverse())) break;


            }

            /// cập nhật giá trị mã sinh ra
            foreach (var item in panelGroupKhoa.Controls)
            {
                TextBox z = item as TextBox;
                
                Point pos = (Point)z.Tag;
                if (pos.X > k || pos.Y > k) continue;
                z.Text = mt[pos.X, pos.Y].Re.ToString();
            }

            
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            txtMHBanMa.Text = txtMHBanMa.Text.Trim();
            if (txtMHBanMa.Text == "")
            {
                MessageBox.Show("Bản mã đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /// Kiểm tra khóa
            int k = (int)numRowCount.Value;

            Matrix mt = new Matrix(k, k);
            /// tính lại mt
            foreach (var item in panelGroupKhoa.Controls)
            {
                TextBox z = item as TextBox;

                Point pos = (Point)z.Tag;
                if (pos.X > k || pos.Y > k) continue;

                int gt = 0;
                try
                {
                    gt = Int32.Parse(z.Text);
                }
                catch
                {
                    gt = 0;
                }
                mt[pos.X, pos.Y] = new Complex(gt);

            }

            if (!MaHoa.Crypto.Hill.ok(mt))
            {
                MessageBox.Show("Key chưa thỏa mãn. Không tồn tại ma trận nghịch đảo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtBanGiaiMa.Text = Hill.decrypt(txtMHBanMa.Text, mt);
        }
        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            /// ma trận khóa
            int k = (int)numRowCount.Value;
            panelGroupKhoa.Controls.Clear();
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Tag = new Point(i, j);
                    txt.Width = 40;

                    if (i > k || j > k) txt.Enabled = false;
                    panelGroupKhoa.Controls.Add(txt);

                }
            }

            // ma trận nghịch đảo
            panelGroupNghichDaoKhoa.Controls.Clear();
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Tag = new Point(i, j);
                    txt.Width = 40;

                    if (i > k || j > k) txt.Enabled = false;
                    panelGroupNghichDaoKhoa.Controls.Add(txt);

                }
            }
        }

        private void ucMaHoaHill_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadMaTran();
        }
        #endregion

        #region Hàm chức năng
        private void LoadMaTran()
        {
            int k = (int) numRowCount.Value;

            /// ma trận khóa
            foreach(var item in panelGroupKhoa.Controls)
            {
                TextBox z = item as TextBox;
                z.Text = "0";
                Point pos = (Point)z.Tag;
                if (pos.X > k || pos.Y > k) z.Enabled = false; else z.Enabled = true;

                if (pos.X == pos.Y) z.Text = "1";
            }


            /// ma trận nghịch đảo
            foreach(var item in panelGroupNghichDaoKhoa.Controls)
            {
                TextBox z = item as TextBox;
                z.Text = "0";
                Point pos = (Point)z.Tag;
                if (pos.X > k || pos.Y > k) z.Enabled = false; else z.Enabled = true;

                if (pos.X == pos.Y) z.Text = "1";
            }
        }
        #endregion

        #region Sự kiện ngầm
        private void numRowCount_ValueChanged(object sender, EventArgs e)
        {
            LoadMaTran();
        }
        #endregion

        private void btnTinhMaTranNghichDao_Click(object sender, EventArgs e)
        {
            int k = (int) numRowCount.Value;

            /// ma trận nghịch đảo
            try
            {
                Matrix nd = mt.Inverse();
                foreach (var item in panelGroupNghichDaoKhoa.Controls)
                {
                    TextBox z = item as TextBox;

                    Point pos = (Point)z.Tag;
                    if (pos.X > k || pos.Y > k) continue;
                    z.Text = Math.Round(nd[pos.X, pos.Y].Re).ToString();
                }
            }
            catch { }
        }

        private void btnThamMa_Click(object sender, EventArgs e)
        {
            txtMHBanMa.Text = txtMHBanMa.Text.Trim();
            if (txtMHBanMa.Text == "")
            {
                MessageBox.Show("Bản mã đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtBanGiaiMa.Text = Hill.decrypt(txtMHBanMa.Text, "VJHACFCAVMUQBEQNDBPSKCDBIBWJAENNDYYGBEKWXXYOZAPMEVCFRJEWOMAN", "THEFREQUENCYOFLETTERSATTHEBEGINNINGSOFWORDSISDIFFERENTAGAINA");
        }
    }
}
