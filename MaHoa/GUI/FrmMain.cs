using MaHoa.Crypto;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoa.GUI
{
    public partial class FrmMain : MetroForm
    {
        private ucMaHoaDichVong dichvong = new ucMaHoaDichVong();
        private ucMaHoaVirgene virgene = new ucMaHoaVirgene();

        #region Hàm khởi tạo
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void FrmMain_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            dichvong.Dock = DockStyle.Fill;
            virgene.Dock = DockStyle.Fill;

            panelMain.Controls.Add(dichvong);
            panelMain.Controls.Add(virgene);

            CapNhatLoaiMaHoa();
        }
        #endregion

        #region Hàm chức năng
        private void CapNhatLoaiMaHoa()
        {
            dichvong.Visible = false;
            virgene.Visible = false;

            if (rdDichVong.Checked) dichvong.Visible = true;
            if (rdVirgene.Checked) virgene.Visible = true;
        }
        #endregion

        #region Chức năng ngầm
        private void rdDichVong_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatLoaiMaHoa();
        }
        #endregion
    }
}
