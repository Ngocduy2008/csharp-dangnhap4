using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_dangnhap4
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txtdangnhap.Text == "Ngọc Duy" && txtmatkhau.Text == "176208")
            {
                frmmain frmmain = new frmmain();
                this.Hide();
                frmmain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu","lỗi" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
