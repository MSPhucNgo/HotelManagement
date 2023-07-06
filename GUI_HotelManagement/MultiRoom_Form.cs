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
    public partial class MultiRoom_Form : Form
    {
        public List<Room_DTO> roomInfor = new List<Room_DTO>();
        public BookingForm_DTO inforBooking = new BookingForm_DTO();
        public Customer_DTO inforCTM = new Customer_DTO();
        public Infomation_Form_DTO inforForm = new Infomation_Form_DTO();
        public Supply_Form_DTO supInfo = new Supply_Form_DTO();
        public Bill_DTO inforBill = new Bill_DTO();
        //public List<Room_DTO> idRoom = new List<Room_DTO>();
        public MultiRoom_Form()
        {
            InitializeComponent();
            bookingRoom_DataGrid.Columns.Add("NameRoom", "Name");
            bookingRoom_DataGrid.Columns.Add("PriceRoom", "Price");
            bookingRoom_DataGrid.Columns.Add("TypeRoom", "Type");
            setData_FilterType();

        }
        public MultiRoom_Form(ref Customer_DTO _inforCTM, ref BookingForm_DTO _inforBooking, ref Infomation_Form_DTO _inforForm, ref Supply_Form_DTO _supInfo, ref Bill_DTO _inforBill)
        {
            InitializeComponent();
            this.inforBooking = _inforBooking;
            this.inforCTM = _inforCTM;
            this.inforForm = _inforForm;
            this.supInfo = _supInfo;
            this.inforBill = _inforBill;
            bookingRoom_DataGrid.Columns.Add("NameRoom", "Name");
            bookingRoom_DataGrid.Columns.Add("PriceRoom", "Price");
            bookingRoom_DataGrid.Columns.Add("TypeRoom", "Type");
            setData_FilterType();

        }
        void setData_FilterType()
        {
            List<string> ListRoomName = Room_BUS.getListRoom_Type("Trống", "All");
            foreach (string roomName in ListRoomName)
            {
                createButton(roomName);
            }
        }
        public void createButton(string roomName)
        {
            Button roundedButton = new Button();
            roundedButton.Text = roomName;
            roundedButton.Font = new Font(roundedButton.Font.FontFamily, 12, roundedButton.Font.Style);
            // ddoanj nay
            string statusRoom = Room_BUS.getRoomStatus(new Room_DTO(roomName.Split('\n')[0]));
            if (statusRoom == null) { return; }
            else if (statusRoom == "Trống")
            {
                roundedButton.BackColor = Color.FromArgb(0, 193, 138);
                roundedButton.Size = new Size(135, 103);
            }
            else if (statusRoom == "Đang sử dụng")
            {
                roundedButton.BackColor = ColorTranslator.FromHtml("#EF3B2C"); ;
                roundedButton.Size = new Size(135, 103);
            }
            else if (statusRoom == "Được đặt trước")
            {
                roundedButton.BackColor = Color.FromArgb(44, 121, 195);
                roundedButton.Size = new Size(135, 103);
            }
            roundedButton.FlatStyle = FlatStyle.Flat;
            roundedButton.FlatAppearance.BorderSize = 0;
            roundedButton.Cursor = Cursors.Hand;
            roundedButton.Click += Show_Click;
            ListRoom_FlowLayout.Controls.Add(roundedButton);
        }
        private void Show_Click(object sender, EventArgs e)
        {
            //Thêm vào DataGrid
            string roomname = (sender as Button).Text.Split('\n')[0];
            string price = Room_BUS.getRoomPrice(new Room_DTO(roomname));
            string type = (sender as Button).Text.Split('\n')[1];
            //string idRoom = (sender as Button).Text.Split('\n')[];
            bookingRoom_DataGrid.Rows.Add(roomname, price, type);

            //Ẩn khỏi layoutPanel
            ListRoom_FlowLayout.Controls.Remove(sender as Button);
        }

        private void bookingRoom_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bookingRoom_DataGrid.Columns["NameRoom"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = bookingRoom_DataGrid.Rows[e.RowIndex];
                string roomname = selectedRow.Cells["NameRoom"].Value.ToString() + '\n' + selectedRow.Cells["TypeRoom"].Value.ToString();
                bookingRoom_DataGrid.Rows.Remove(selectedRow);
                createButton(roomname);
            }
            else return;
        }

        //public void loadIdRoomList(string roomName)
        //{
        //    //Button roundedButton = new Button();
        //    //roundedButton.Text = roomName;
        //    //roundedButton.Font = new Font(roundedButton.Font.FontFamily, 12, roundedButton.Font.Style);
        //    // ddoanj nay
        //    string idRoom = Room_BUS.getRoomId(new Room_DTO(roomName.Split('\n')[0]));
        //    if (idRoom == null) { return; }
        //    else if (statusRoom == "Trống")
        //    {
        //        roundedButton.BackColor = Color.FromArgb(0, 193, 138);
        //        roundedButton.Size = new Size(135, 103);
        //    }
        //    else if (statusRoom == "Đang sử dụng")
        //    {
        //        roundedButton.BackColor = ColorTranslator.FromHtml("#EF3B2C"); ;
        //        roundedButton.Size = new Size(135, 103);
        //    }
        //    else if (statusRoom == "Được đặt trước")
        //    {
        //        roundedButton.BackColor = Color.FromArgb(44, 121, 195);
        //        roundedButton.Size = new Size(135, 103);
        //    }
        //    roundedButton.FlatStyle = FlatStyle.Flat;
        //    roundedButton.FlatAppearance.BorderSize = 0;
        //    roundedButton.Cursor = Cursors.Hand;
        //    roundedButton.Click += Show_Click;
        //    ListRoom_FlowLayout.Controls.Add(roundedButton);
        //}
        
        private void button1_Click(object sender, EventArgs e)
        {
            //string a = "";
            //List<Room_DTO> idRoom = new List<Room_DTO>();
            //Room_BUS busroom= new Room_BUS();
           
            //List<Room_DTO> idRoom = new List<string>();
            foreach (DataGridViewRow row in bookingRoom_DataGrid.Rows)
            {

                string temp = row.Cells["NameRoom"].Value.ToString();
                //Room_DTO room = new Room_DTO();
                //roomInfor.Add(room);
                string idRoom = Room_BUS.getRoomId(new Room_DTO(null, temp, 0));
                roomInfor.Add(new Room_DTO(idRoom, null, 0));
                //Room_DTO idtemp = busroom.getRoomId(roomInfor[0]);
                //idRoom.Add((busroom.getRoomId(temp)).ToString());
                //idRoom.Add(temp);
                //Add(row.Cells[0].Value.ToString());

                //room.Add(a);
                //room.IdRoom = dr[0].ToString();
                //}
            }
            //string a = roomInfor[0].IdRoom;
            //string b = roomInfor[1].IdRoom;
            //string c = roomInfor[2].IdRoom;
            //MessageBox.Show(a);
            //MessageBox.Show(b);
            //MessageBox.Show(c);
            this.Hide();
            //this.Close();
            inforBooking.Price = Room_BUS.totalRoomFee(ref roomInfor);
            inforBill.Room_Fee = inforBooking.Price.ToString();
            inforBill.Deposit_price = (float.Parse(inforBill.Room_Fee) * 30 / 100).ToString();
            Booking_Form bkf = new Booking_Form(ref inforCTM, ref inforBooking, ref roomInfor, ref inforForm, ref supInfo, ref inforBill);
            bkf.ShowDialog();
            //this.Hide();

            //bkf.ShowDialog();
            //this.Show();
            //this.Close();
        }
    }
}
