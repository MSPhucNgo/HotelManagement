using BUS_HotelManagement;
using DTO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_HotelManagement
{
    public partial class Checkout_Form : Form
    { 
        public Checkout_Form()
        {
            InitializeComponent();
            
        }
        public void setData(string idBooking)
        {
            BookingForm_DTO bookingID = new BookingForm_DTO(idBooking);
            cusName_Text.Text = BookingForm_BUS.getGuestName(bookingID);
            Method_ComboBox.Text = BookingForm_BUS.getPaymenMethods(bookingID);
            listRoom_DataGrid.DataSource = BookingForm_BUS.getListRoom(bookingID);
            listService_DataGrid.DataSource = Customer_BUS.getUsedService(new Customer_DTO(cusName_Text.Text.ToString()));
            setPrice();

        }
        public void setPrice()
        {
            int roomFee = 0;
            int serviceFee = 0;
            foreach (DataGridViewRow row in listRoom_DataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    int price = int.Parse(row.Cells["Price"].Value.ToString());
                    roomFee += price;
                }
            }
            foreach (DataGridViewRow row in listService_DataGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    int price = int.Parse(row.Cells["Total_Price"].Value.ToString());
                    serviceFee += price;
                }
            }
            roomFee_Text.Text = roomFee.ToString(); 
            serviceFee_Text.Text = serviceFee.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            setData(idBooking_Text.Text);
        }
    }
}
