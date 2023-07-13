using BUS_HotelManagement;
using DAO_HotelManagement;
using DTO_HotelManagement;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            loadlistOfReservation();
			cb_BookingID.DataSource = BookingForm_BUS.cb_BookingID();
            //cb_RoomType.DataSource = BookingForm_BUS.cb_RoomType();
			cb_BookingID_Edit.DataSource = BookingForm_BUS.cb_BookingID_Edit();


		}
        private void bt_Edit_Reservation_Click_1(object sender, EventArgs e)
        {
            string BookingId = cb_BookingID_Edit.Text.ToString();
            if (BookingId == "")
            {
                MessageBox.Show("The Booking_ID is not correct, please re-enter the Booking_ID!");
                return;
            }
            else if (BookingId == "0")
            {
                MessageBox.Show("The Booking_ID is not correct, please re-enter the Booking_ID!");
                return;
            }
            else if (BookingId == null)
            {
                MessageBox.Show("The Booking_ID is not correct, please re-enter the Booking_ID!");
                return;
            }
			//BookingForm_DTO booking = new BookingForm_DTO(BookingId);
			//Customer_DTO customer = new Customer_DTO();
			string booking = cb_BookingID_Edit.Text.ToString();
			//BookingForm_DTO cus_name = new BookingForm_DTO (tb_Customer_Name.ToString());
			string ar_date = date_Arrive.Text.ToString();
			string de_date = date_Departure.Text.ToString();
			string spec_re = tb_Special_Re.Text.ToString();
			
			BookingForm_DTO temp = new BookingForm_DTO(booking, ar_date, de_date,spec_re);
			bool flag = BookingForm_BUS.Update_BookingForm(temp);
			/*date_Arrive.Format = DateTimePickerFormat.Custom;
			date_Arrive.CustomFormat = "mm/dd/yyyy";
			date_Departure.Format = DateTimePickerFormat.Custom;
			date_Departure.CustomFormat = "dd/mm/yyyy hh:mm:ss";*/

			//dgv_Reservation.DataSource = BookingForm_BUS.update_Reservation(booking, ar_date, de_date, spec_re);
			//update_Reservation(booking, ar_date, de_date, spec_re);
			MessageBox.Show("Update successful!");
            /*Reservation r = new Reservation();
            r.Show();
            this.Hide();*/
        }
		public void loadlistOfReservation()
		{
			BookingForm_DTO booking = new BookingForm_DTO(null);
			dgv_Reservation.DataSource = BookingForm_BUS.loadlistOfReservation();
		}
		public void loadlistOfReservation(string idBooking)
		{
			BookingForm_DTO booking = new BookingForm_DTO(idBooking);
			dgv_Reservation.DataSource = BookingForm_BUS.loadlistOfReservation_Room(booking);
		}
        private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Show();
            this.Hide();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
			this.Close();
		}

		private void bt_Search_Reservation_Click_1(object sender, EventArgs e)
		{
			string BookingId = cb_BookingID.Text.ToString();
			if (BookingId == "")
			{
				MessageBox.Show("The Booking_ID is not correct, please re-enter the Booking_ID!");
				return;
			}
			else if (BookingId == "0")
			{
				MessageBox.Show("The Booking_ID is not correct, please re-enter the Booking_ID!");
				return;
			}
			else if (BookingId == null)
			{
				MessageBox.Show("The Booking_ID is not correct, please re-enter the Booking_ID!");
				return;
			}
			loadlistOfReservation(BookingId);
		}
		/*public void Edit_Reservation()
		{

			BookingForm_DTO booking = new BookingForm_DTO(null);
			dgv_Reservation.DataSource = BookingForm_BUS.Edit_Reservation();

		}*/
		private void button1_Click(object sender, EventArgs e)
		{
			loadlistOfReservation();
		}
    }
}
