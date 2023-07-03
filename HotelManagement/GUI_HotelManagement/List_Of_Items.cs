﻿using BUS_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_HotelManagement
{
    public partial class List_Of_Items : Form
    {
		public List_Of_Items()
        {

			InitializeComponent();
            loadlistOfItems();
			cb_RoomID.DataSource = BookingForm_BUS.cb_RoomID();

		}

		private void lb_List_Of_Items_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Search
        {

			string BookingId = cb_RoomID.Text.ToString();
			if (BookingId == "")
			{
				MessageBox.Show("The Room_ID is not correct, please re-enter the Room_ID!");
				return;
			}
			else if (BookingId == "0")
			{
				MessageBox.Show("The Room_ID is not correct, please re-enter the Room_ID!");
				return;
			}
			else if (BookingId == null)
			{
				MessageBox.Show("The Room_ID is not correct, please re-enter the Room_ID!");
				return;
			}
			loadlistOfItems(BookingId);

		}

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void loadlistOfItems() // Load List of items (all)
        {

            BookingForm_DTO booking = new BookingForm_DTO(null);
            dgv_List_Of_Items.DataSource = BookingForm_BUS.loadlistOfItems();
        }
		public void loadlistOfItems(string idBooking) //Load List of items theo Room_ID
		{

			BookingForm_DTO bookingID = new BookingForm_DTO(idBooking);
			dgv_List_Of_Items_Room.DataSource = BookingForm_BUS.loadlistOfItems_Room(bookingID);

		}
		private void dgv_List_Of_Items_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgv_List_Of_Items_Room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
			string BookingId = cb_RoomID.Text.ToString();
			loadlistOfItems();
		}
		private void dgv_List_Of_Items_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void cb_RoomID_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
