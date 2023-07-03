using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_HotelManagement;
using DAO_HotelManagement;
using BUS_HotelManagement;

namespace GUI_HotelManagement
{

    public partial class RoomList : Form
    {
        Room_BUS busRoom = new Room_BUS();
        public RoomList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void GUI_RoomList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busRoom.getRoom();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
