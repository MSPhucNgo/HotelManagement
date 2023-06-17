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
        //public List<Room_DTO> idRoom = new List<Room_DTO>();
        public MultiRoom_Form()
        {
            InitializeComponent();
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
            public List<Room_DTO> idRoom = new List<Room_DTO>();
            List<string> name = new List<string>();
            foreach (DataGridViewRow row in bookingRoom_DataGrid.Rows)
            {
                idRoom
                //Add(row.Cells[0].Value.ToString());

                //room.Add(a);
                //room.IdRoom = dr[0].ToString();
                //}

                //MessageBox.Show(name[0]);



            }
        }
    }
}
