using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void dgv_Reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_Edit_Reservation_Click(object sender, EventArgs e)
        {
            Edit_Resevation er = new Edit_Resevation();
            er.Show();
            this.Hide();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
