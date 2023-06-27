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

namespace GUI_HotelManagement
{
    public partial class Edit_Resevation : Form
    {
        public Edit_Resevation()
        {
			InitializeComponent();
            loadlistOfReservation();
			cb_BookingID.DataSource = BookingForm_BUS.cb_BookingID();

		}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Edit_Reservation_Click_1(object sender, EventArgs e)
        {
            /*string BookingId = cb_BookingID.Text.ToString();
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
            //Edit_Reservation(BookingId);
            MessageBox.Show("Update successful!");
			Reservation r = new Reservation();
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
		/*public void loadlistOfReservation_Edit(string idBooking)
		{

			BookingForm_DTO booking = new BookingForm_DTO(idBooking);
			dgv_Reservation.DataSource = BookingForm_BUS.loadlistOfReservation_Edit(booking);

		}*/
		private void bt_Cancel_Click_1(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Show();
            this.Hide();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
			Application.Exit();
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
	}
}
