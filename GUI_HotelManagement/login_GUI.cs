using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace GUI_HotelManagement
{

    public partial class login_GUI : Form
    {
        
        public login_GUI()
        {
            InitializeComponent();
        }

        public static string name = "PROJECT";
        public static string pass = "DOAN";
        public static string id = "";

        private void btn_login_Click(object sender, EventArgs e)
        {
            /*
            if (String.IsNullOrWhiteSpace(tb_User.Text)
               || String.IsNullOrWhiteSpace(tb_Pass.Text))
            {
                MessageBox.Show("Tài khoản và mặt khẩu không được để trông!");
                return;
            }
            */

            //name = tb_User.Text.ToString();
            //pass = tb_Pass.Text.ToString();

            //if (flag == 1)
            if (true)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                //Đổi tên temp -> tên form của mấy người
                temp temp = new temp();
                temp.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }
        }
    }
}
