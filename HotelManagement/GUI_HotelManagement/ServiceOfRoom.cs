using BUS_HotelManagement;
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

namespace HotelManagement
{
    public partial class Service_Of_Room : Form
    {
        public Room_DTO room = new Room_DTO();



        public Service_Of_Room()
        {
            InitializeComponent();
        }

        public Service_Of_Room(Room_DTO roomId)
        {
            InitializeComponent();
            // // set up dtgv
            dtgvServiceList.RowHeadersWidth = 50;


            dtgvOffer.RowHeadersWidth = 50;


            room = roomId;
            dtgvServiceList.DataSource = Services_for_customer_BUS.usp_getServicesOfRoom_svs(roomId);
            dtgvServiceList.Columns[0].Visible = false;
            for (int i = 0; i < dtgvServiceList.Rows.Count; i++)
            {
                dtgvServiceList.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtgvServiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string serviceId = dtgvServiceList.Rows[e.RowIndex].Cells["ID_SERVICE"].Value.ToString();
            HotelService_DTO hotelService = new HotelService_DTO(serviceId);
            hotelService = Services_for_customer_BUS.usp_getDetailOfService_svs(hotelService);
            txbName.Text = hotelService.name;
            txtDesc.Text = hotelService.description;
            txtUnit.Text = hotelService.unit;
            txtPrice.Text = hotelService.price.ToString();
            txbStatus.Text = hotelService.Status;
            dtgvOffer.DataSource = Services_for_customer_BUS.usp_getDiscountOfService_svs(hotelService);
            dtgvOffer.Columns[0].Visible = false;
            for (int i = 0; i < dtgvOffer.Rows.Count; i++)
            {
                dtgvOffer.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
