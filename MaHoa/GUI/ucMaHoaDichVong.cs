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

namespace MaHoa.GUI
{
    public partial class ucMaHoaDichVong : UserControl
    {

        #region Hàm khởi tạo
        public ucMaHoaDichVong()
        {
            InitializeComponent();
        }

        #endregion

        #region Sự kiện
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (txtMHBanRo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản rõ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMHKey.Text == "")
            {
                MessageBox.Show("Key không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int z = Int32.Parse(txtMHKey.Text);
            }
            catch
            {
                MessageBox.Show("Key phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtMHBanMa.Text = Ceasar.encrypt(txtMHBanRo.Text, Int32.Parse(txtMHKey.Text));
            MessageBox.Show("Mã hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMHSinhKhoaNgauNhien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int key = rd.Next(26) + 1;
            txtMHKey.Text = key.ToString();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (txtGMBanMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bản rõ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtGMKhoa.Text == "")
            {
                MessageBox.Show("Key không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int z = Int32.Parse(txtGMKhoa.Text);
            }
            catch
            {
                MessageBox.Show("Key phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtGMBanRo.Text = Ceasar.decrypt(txtMHBanMa.Text, Int32.Parse(txtGMKhoa.Text));
            MessageBox.Show("Giải mã thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGMSinhKhoaNgauNhien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int key = rd.Next(26) + 1;
            txtGMKhoa.Text = key.ToString();
        }
        #endregion
    }
}
