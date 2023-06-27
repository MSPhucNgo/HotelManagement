﻿using BUS_HotelManagement;
using DTO_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            loadlistOfItems_Room();

		}
        
        private void lb_List_Of_Items_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void loadlistOfItems()
        {

            BookingForm_DTO booking = new BookingForm_DTO(null);
            dgv_List_Of_Items.DataSource = BookingForm_BUS.loadlistOfItems(booking);

        }
		public void loadlistOfItems_Room()
		{

			BookingForm_DTO booking = new BookingForm_DTO(null);
			dgv_List_Of_Items_Room.DataSource = BookingForm_BUS.loadlistOfItems_Room(booking);

		}
		private void dgv_List_Of_Items_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
