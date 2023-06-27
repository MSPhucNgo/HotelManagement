using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_HotelManagement;
using DTO_HotelManagement;
namespace GUI_HotelManagement
{
    public partial class Booking_Form : Form
    {
        public DataGridView bookingroom = new DataGridView();
        public List<Room_DTO> roomInfor = new List<Room_DTO>();
        public Booking_Form()
        {
            InitializeComponent();
        }
        public Booking_Form(ref List<Room_DTO> roomInfor)
        {
            InitializeComponent();
            this.roomInfor = roomInfor;
        }

        private void checkBoxGroup_CheckedChanged(object sender, EventArgs e)
        {
            this.labelNumberStay.Visible = true;
            this.labelNameGroup.Visible = true;
            this.txtNameGroup.Visible = true;
            this.txtNumberStay.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            BookingForm_BUS bf = new BookingForm_BUS();
            //MessageBox.Show(bf.checkExistedCTM(txtIdentify.Text.ToString()).ToString());
            if (bf.checkExistedCTM(txtIdentify.Text.ToString()) == true)
            {
                MessageBox.Show("Customer is exist!");

            }
            else
            {
                MessageBox.Show(txtIdentify.Text);
                MessageBox.Show("Customer is not exist!");
            }
            Load_ExistedCustomer(sender, e);
        }

        private void Load_ExistedCustomer(object sender, EventArgs e)
        {
            BookingForm_BUS busbf = new BookingForm_BUS();
            Customer_DTO dtoctm;
            DataTable dt = new DataTable();
            dt = busbf.getInforExistedCTM(txtIdentify.Text.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                string idCTM = dr["ID_CUSTOMER"].ToString();
                string name = dr["NAME"].ToString();
                string idCard = dr["IDENTIFY_CARD"].ToString();
                string phone = dr["PHONE"].ToString();
                string email = dr["EMAIL"].ToString();
                string gender = dr["GENDER"].ToString();
                string birthDay = dr["BIRTHDAY"].ToString();

                dtoctm = new Customer_DTO(idCTM, name, gender, birthDay, email, phone, idCard);
                txtName.Text = dtoctm.Name;
                txtIdentify.Text = dtoctm.Identify_Card;
                txtPhone.Text = dtoctm.Phone;
                txtEmail.Text = dtoctm.Email;
                txtGender.Text = dtoctm.Gender;
                txtBirthday.Text = dtoctm.Birthday;
            }
        }
        private void txtIdentity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseRoom_Click(object sender, EventArgs e)
        {
            MultiRoom_Form mrf = new MultiRoom_Form();
            this.Hide();
            mrf.ShowDialog();
            //this.Close();
            this.ShowDialog();
            //this.Hide();
            //this.Show();

            //this.Close();
            //this.Close();
            //mrf.Show();

        }

        private void Booking_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            Booking_Form bf = new Booking_Form(ref roomInfor);
            MessageBox.Show(roomInfor[0].IdRoom);
        }

        private void panelBooking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBooking_Paint_1(object sender, PaintEventArgs e)
        {
        }
    }
}
