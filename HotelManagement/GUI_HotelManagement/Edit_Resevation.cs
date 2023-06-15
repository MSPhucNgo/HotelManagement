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
    public partial class Edit_Resevation : Form
    {
        public Edit_Resevation()
        {
            InitializeComponent();
        }

        private void bt_Edit_Reservation_Click(object sender, EventArgs e)
        {

            Reservation r = new Reservation();
            r.Show();
            this.Hide();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Show();
            this.Hide();
        }
    }
}
