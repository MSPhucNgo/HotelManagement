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
            cb_RoomType.DataSource = BookingForm_BUS.cb_RoomType();

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

		private void button1_Click(object sender, EventArgs e)
		{
			loadlistOfReservation();
		}

		private void dgv_Reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

        private void cb_BookingID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*int index;

string procName = "QLCONGTY.USP_ADDEMPLOYEE";
string connectionString = DataProvider.Instance.getconnecStr();
using (OracleConnection connection = new OracleConnection(connectionString))
{
   connection.Open();
   using (OracleCommand command = new OracleCommand(procName, connection))
   {
       command.CommandType = CommandType.StoredProcedure;

       command.Parameters.Add("NAMEEMP", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(Name_Text.Text) ? (object)null : Name_Text.Text;
       command.Parameters.Add("GENDER", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(gender_ComboBox.Text) ? (object)null : gender_ComboBox.Text;
       command.Parameters.Add("BIRTHDAY", OracleDbType.Date).Value = birthday_Datetime.Value;
       command.Parameters.Add("ADDRESS", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(address_Text.Text) ? (object)null : address_Text.Text;
       command.Parameters.Add("PHONE", OracleDbType.Char).Value = string.IsNullOrEmpty(phone_Text.Text) ? (object)null : phone_Text.Text;
       command.Parameters.Add("SALARY", OracleDbType.Char).Value = string.IsNullOrEmpty(salary_Text.Text) ? (object)null : (salary_Text.Text);
       command.Parameters.Add("ALLOWANCE", OracleDbType.Char).Value = string.IsNullOrEmpty(allowance_Text.Text) ? (object)null : (allowance_Text.Text);
       //command.Parameters.Add("USERROLE", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(role_ComboBox.Text) ? (object)null : role_ComboBox.Text;
       if (role_ComboBox.Text == "QLTT") command.Parameters.Add("USERROLE", OracleDbType.NVarchar2).Value = "QL trực tiếp";
       else command.Parameters.Add("USERROLE", OracleDbType.NVarchar2).Value = string.IsNullOrEmpty(role_ComboBox.Text) ? (object)null : role_ComboBox.Text;

       if (manager_ComboBox.Text == "<None>") command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = null;
       else command.Parameters.Add("USERMANAGER", OracleDbType.Char).Value = manager_ComboBox.Text;

       if (room_ComboBox.Text == "<None>") command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = null;
       else command.Parameters.Add("PHGBAN", OracleDbType.Int32).Value = int.Parse(room_ComboBox.Text);

index = command.ExecuteNonQuery();
   }
}
setData();*/
    }
}
