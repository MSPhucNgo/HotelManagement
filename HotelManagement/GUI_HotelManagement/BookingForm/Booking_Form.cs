using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BUS_HotelManagement;
using DTO_HotelManagement;
using DTO_HotelManagement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI_HotelManagement
{
    public partial class Booking_Form : Form
    {
        public DataGridView bookingroom = new DataGridView();
        public BookingForm_DTO inforBooking = new BookingForm_DTO();
        public Customer_DTO inforCTM = new Customer_DTO();
        public List<Room_DTO> roomInfor = new List<Room_DTO>();
        public Infomation_Form_DTO inforForm = new Infomation_Form_DTO();
        public Supply_Form_DTO supInfo = new Supply_Form_DTO();
        public Bill_DTO inforBill = new Bill_DTO();       
        public Booking_Form()
        {
            InitializeComponent();
        }
        public Booking_Form(Room_DTO roomInfp) 
        {
            InitializeComponent();
            roomInfor.Add(roomInfp);
        }
        public Booking_Form(ref Customer_DTO _inforCTM, ref BookingForm_DTO _inforBooking, ref List<Room_DTO> _roomInfor, ref Infomation_Form_DTO _inforForm, ref Supply_Form_DTO _supInfo, ref Bill_DTO _inforBill)
        {
            InitializeComponent();
            //txtName.Text = _inforCTM.Name.ToString();
            this.inforCTM = _inforCTM;
            this.inforBooking = _inforBooking;
            this.roomInfor = _roomInfor;
            this.inforForm = _inforForm;
            this.supInfo = _supInfo;
            this.inforBill = _inforBill;
            //this.txtName.Text = this.inforCTM.Name.ToString();
        }

        private void checkBoxGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxGroup.Checked == true)
            {
                this.labelNumberStay.Visible = true;
                this.labelNameGroup.Visible = true;
                this.txtNameGroup.Visible = true;
                this.txtNumberStay.Visible = true;
            }
            else
            {
                this.labelNumberStay.Visible = false;
                this.labelNameGroup.Visible = false;
                this.txtNameGroup.Visible = false;
                this.txtNumberStay.Visible = false;
            }
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
            //inforCTM = new Customer_DTO("null", "null", "null", "null", "null", "null", "null");
            DataTable dt = new DataTable();
            dt = busbf.getInforExistedCTM(txtIdentify.Text.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                inforCTM.IdCustomer = dr["ID_CUSTOMER"].ToString();
                inforCTM.Name = dr["NAME"].ToString();
                inforCTM.Identify_Card = dr["IDENTIFY_CARD"].ToString();
                inforCTM.Phone = dr["PHONE"].ToString();
                inforCTM.Email = dr["EMAIL"].ToString();
                inforCTM.Gender = dr["GENDER"].ToString();
                inforCTM.Birthday = dr["BIRTHDAY"].ToString();

                txtName.Text = inforCTM.Name;
                txtIdentify.Text = inforCTM.Identify_Card;
                txtPhone.Text = inforCTM.Phone;
                txtEmail.Text = inforCTM.Email;
                txtGender.Text = inforCTM.Gender;
                txtBirthday.Text = inforCTM.Birthday;
            }
        }

        private void Load_BookingForm(object sender, EventArgs e)
        {
            txtName.Text = inforCTM.Name;
            txtIdentify.Text = inforCTM.Identify_Card;
            txtPhone.Text = inforCTM.Phone;
            txtEmail.Text = inforCTM.Email;
            txtGender.Text = inforCTM.Gender;
            txtBirthday.Text = inforCTM.Birthday;
            txtArrivalDate.Text = inforBooking.ArrivalDate;
            txtDepartureDate.Text = inforBooking.DepartureDate;
            txtSpecialReq.Text = inforBooking.SpecialRequirement;
            inforForm.NumberRooms = roomInfor.Count();
            txtNumberRoom.Text = inforForm.NumberRooms.ToString();
            txtNumberStay.Text = inforForm.NumberStays.ToString();
            txtSpecialReq.Text = inforForm.SpecialRequirements;

            txtNameGroup.Text = supInfo.GroupName;
            supInfo.RegisteredName = inforCTM.Name;
            supInfo.GroupSize = inforBooking.Amount; 
            txtRoomFee.Text = inforBooking.Price.ToString();
            txtDepositFee.Text = inforBill.Deposit_price;
        }
        private void txtIdentity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseRoom_Click(object sender, EventArgs e)
        {
            //Gán data khách hàng trong textbox vào biến inforCTM
            this.inforCTM.Name = txtName.Text.ToString();
            this.inforCTM.Gender = txtGender.Text.ToString();
            this.inforCTM.Birthday = txtBirthday.Text.ToString();
            this.inforCTM.Email = txtEmail.Text.ToString();
            this.inforCTM.Phone = txtPhone.Text.ToString();
            this.inforCTM.Identify_Card = txtIdentify.Text.ToString();

            //Gàn data booking trong textbox vào biến 
            this.inforBooking.ArrivalDate = txtArrivalDate.Text.ToString();
            this.inforBooking.DepartureDate = txtDepartureDate.Text.ToString();
            this.inforBooking.SpecialRequirement = txtSpecialReq.Text.ToString();
            this.inforBooking.Amount = int.Parse(txtNumberStay.Text);
            this.inforBooking.IdBooking = "";
            //this.inforBooking.Price = 9999;
            //this.inforBooking.Status = "xONG";
            //this.inforBooking.Customer = "C4740"; //this.inforCTM.IdCustomer;

            // Gán vào data information_form
            this.inforForm.ArrivalDate = txtArrivalDate.Text.ToString();
            this.inforForm.NumberStays = 2;//int.Parse(txtNumberStay.Text);
            this.inforForm.NumberRooms = 2;//int.Parse(txtNumberRoom.Text);
            this.inforForm.SpecialRequirements = txtSpecialReq.Text.ToString();

            // Gán data vào supplyform
            this.supInfo.IdInformation = "I9800"; //this.inforBooking.IdBooking;
            this.supInfo.GroupName = txtNameGroup.Text.ToString();
            this.supInfo.RegisteredName = txtName.Text.ToString();
            this.supInfo.GroupSize = int.Parse(txtNumberStay.Text);

            MultiRoom_Form mrf = new MultiRoom_Form(ref this.inforCTM, ref this.inforBooking, ref this.inforForm, ref this.supInfo, ref this.inforBill);
            this.Hide();
            mrf.ShowDialog();
            this.Close();
            //this.ShowDialog();
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
            inforForm.NumberRooms = roomInfor.Count();
            inforBooking.Customer = Customer_BUS.insertCustomer(inforCTM, inforBill, inforForm, supInfo);
            BookingForm_BUS.insertBookingForm(inforBooking, inforBill);

            MessageBox.Show(inforBill.Payment_methods.ToString());
            //MessageBox.Show(inforBill.Status.ToString());

            //string id = Customer_BUS.insertCustomer(inforCTM, inforBill);
            //Update list room status;
            // MessageBox.Show(roomInfor[0].IdRoom);
            //MessageBox.Show(id);

            //MessageBox.Show(inforForm.NumberRooms.ToString());

            //MessageBox.Show(inforCTM.Name);
            //MessageBox.Show(roomInfor[0].IdRoom);
            //MessageBox.Show(roomInfor[1].IdRoom);


        }

        private void panelBooking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBooking_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void checkBoxDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeposit.Checked == true)
            {
                inforBill.Status = "Đã thanh toán tiền cọc";
                inforForm.Type = "Đảm bảo";
            }
            else
            {
                inforBill.Status = "Chưa thanh toán";
                inforForm.Type = "Không đảm bảo";
            }
        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            inforBill.Payment_methods = comboBoxPaymentMethod.SelectedItem.ToString();
        }
    }
}
