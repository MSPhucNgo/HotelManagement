using DTO_HotelManagement;
using BUS_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS;
using DAO_HotelManagement;

namespace GUI_HotelManagement
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            loadlistOfReservation();
        }

        private void bt_Edit_Reservation_Click(object sender, EventArgs e)
        {
            Edit_Resevation er = new Edit_Resevation();
            er.Show();
            this.Hide();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checkinform c = new Checkinform();
            //c.Show();
            //this.Hide();
        }
        public string selectedID;
        //DƯƠNG: BookingForm_DAO.cs
        private void dgv_Reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.ColumnIndex == dgv_Reservation.Columns["ID_Service"].Index && e.RowIndex >= 0)
            {
                selectedID = dgv_Reservation.Rows[e.RowIndex].Cells["ID_Service"].Value.ToString();
                loadlistOfReservation(selectedID);
            }
            else return;*/
        }
        public void loadlistOfReservation()
        {

            BookingForm_DTO booking = new BookingForm_DTO(null);
           /* if (BookingForm_DAO.loadlistOfReservation(booking).Rows.Count <= 0)
            {
                MessageBox.Show("Dịch vụ không có chương trình khuyến mãi");
                dgv_Reservation.DataSource = null;
                return;
            }*/
            dgv_Reservation.DataSource = BookingForm_BUS.loadlistOfReservation(booking);

        }
    }
}
