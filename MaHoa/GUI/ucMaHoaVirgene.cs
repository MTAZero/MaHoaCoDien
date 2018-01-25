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
    public partial class ucMaHoaVirgene : UserControl
    {

        #region Hàm khởi tạo
        public ucMaHoaVirgene()
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

            txtMHBanMa.Text = Virgene.encrypt(txtMHBanRo.Text, txtMHKey.Text);
            MessageBox.Show("Mã hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMHSinhKhoaNgauNhien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int key = rd.Next(10) + 1;
            string ans = "";
            for(int i=1; i<=key; i++)
            {
                int z = rd.Next(26);
                ans = ans + (char)('A' + z);
            }

            txtMHKey.Text = ans;
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

            txtGMBanRo.Text = Virgene.decrypt(txtMHBanMa.Text, txtGMKhoa.Text);
            MessageBox.Show("Giải mã thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGMSinhKhoaNgauNhien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int key = rd.Next(10) + 1;
            string ans = "";
            for (int i = 1; i <= key; i++)
            {
                int z = rd.Next(26);
                ans = ans + (char)('A' + z);
            }

            txtGMKhoa.Text = ans;
        }
        #endregion
    }
}
