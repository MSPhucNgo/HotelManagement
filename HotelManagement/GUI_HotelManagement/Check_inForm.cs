using BUS_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Check_inForm : Form
    {
        public Check_inForm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string BookingId = BookID_Text.Text.ToString();
            BookingForm_DTO IdBooking = new BookingForm_DTO(BookingId);
            bool flag = BookingForm_BUS.check_Booking(IdBooking);
            if (flag)
            {
                Booking_Grid.DataSource = BookingForm_BUS.LoadData(IdBooking);
                Name_Text.Text = BookingForm_BUS.getGuestName(IdBooking);
                NoRooms_Text.Text = BookingForm_BUS.getNumberofrooms(IdBooking);
                //
                //NoCustomers_Text.Text = BookingForm_BUS.getNumberofcustomers(IdBooking);
                IdentityNo_Text.Text = BookingForm_BUS.getNoIdentity(IdBooking);
                SPRequiments_Text.Text = BookingForm_BUS.getSPRequires(IdBooking);
                Price_Text.Text = BookingForm_BUS.getPrice(IdBooking);
                Edit_Requiment_Button.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tồn tại!");
                Booking_Grid.DataSource = null;
                Name_Text.Text = "";
                NoRooms_Text.Text = "";
                NoCustomers_Text.Text = "";
                IdentityNo_Text.Text = "";
                SPRequiments_Text.Text = "";
                Price_Text.Text = "";
                Edit_Requiment_Button.Enabled = false;
                
            }
            //List<string> selectedItems = new List<string>();
            //for (int i = 0; i < Own_CheckList.Items.Count; i++)
            //{
            //    if (Own_CheckList.GetItemChecked(i))
            //    {
            //        string item = Own_CheckList.Items[i].ToString();
            //        selectedItems.Add(item);
            //    }
            //}

            //// In ra các mục đã được chọn
            //foreach (string item in selectedItems)
            //{
            //    NoRooms_Text.Text += item;
            //}
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public bool isEditing = true;
        private void Edit_Requiment_Button_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Edit_Requiment_Button.Text = "Confirm";
                SPRequiments_Text.Enabled = true;
                SPRequiments_Text.ReadOnly = false;
            }
            else
            {
                Edit_Requiment_Button.Text = "Edit";
                SPRequiments_Text.Enabled = false;
                SPRequiments_Text.ReadOnly = true;
            }
            isEditing = !isEditing;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
