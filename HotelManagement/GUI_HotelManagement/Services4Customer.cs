using BUS_HotelManagement;
using DAO_HotelManagement;
using DTO_HotelManagement;
using HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Services4Customer : Form
    {

        public Services4Customer()
        {
            InitializeComponent();


            // set up dtgv
            dtgvRoomList.RowHeadersWidth = 50;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dtgvRoomList.Rows[e.RowIndex].Cells["ID_ROOM"].Value.ToString();
            string cusId = dtgvRoomList.Rows[e.RowIndex].Cells["ID_CUSTOMER"].Value.ToString();
            string cusName = dtgvRoomList.Rows[e.RowIndex].Cells["NAME"].Value.ToString();
            string phone = dtgvRoomList.Rows[e.RowIndex].Cells["PHONE"].Value.ToString();
            string bfId= dtgvRoomList.Rows[e.RowIndex].Cells["ID_BOOKING"].Value.ToString();
            Room_DTO room = new Room_DTO(str);
            Customer_DTO cus = new Customer_DTO(cusId, cusName, "", "", "", phone, "");
            BookingForm_DTO bookingForm = new BookingForm_DTO(bfId);
            Service_Of_Room serviceOfRoomScreen = new Service_Of_Room(bookingForm, room, cus);
            this.Hide();
            serviceOfRoomScreen.ShowDialog();
            //this.Hide();

        }

        private void btn_tour_search_Click(object sender, EventArgs e)
        {
            //string roomId = txbRoomID.Text;
            string roomId = "1002";
            Room_DTO room = new Room_DTO(roomId);

            dtgvRoomList.DataSource = Services_for_customer_BUS.usp_SearchRoomByID_svs(room);
           // dtgvRoomList.Columns[0].Visible = false;
            for (int i = 0; i < dtgvRoomList.Rows.Count; i++)
            {
                dtgvRoomList.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_room_search_Click(object sender, EventArgs e)
        {
            //string roomId = txbRoomID.Text;
            string roomId = "1002";
            Room_DTO room = new Room_DTO(roomId);

            dtgvRoomList.DataSource = Services_for_customer_BUS.usp_SearchRoomByID_svs(room);
            //dtgvRoomList.Columns[0].Visible = false;
            for (int i = 0; i < dtgvRoomList.Rows.Count; i++)
            {
                dtgvRoomList.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
    }
}
