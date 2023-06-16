using DTO_HotelManagement;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Edit_Reservation_Click_1(object sender, EventArgs e)
        {
            /*string str = dtgvRoomList.Rows[e.RowIndex].Cells["ID_ROOM"].Value.ToString();
            string cusId = dtgvRoomList.Rows[e.RowIndex].Cells["ID_CUSTOMER"].Value.ToString();
            Room_DTO room = new Room_DTO(str);
            Service_Of_Room serviceOfRoomScreen = new Service_Of_Room(room);
            this.Hide();
            serviceOfRoomScreen.ShowDialog();*/
            Reservation r = new Reservation();
            r.Show();
            this.Hide();
        }

        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Show();
            this.Hide();
        }
    }
}
