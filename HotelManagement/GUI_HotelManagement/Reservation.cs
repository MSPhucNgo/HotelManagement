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

namespace GUI_HotelManagement
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        public string selectedID;
        //private void dgv_Reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //        if (e.ColumnIndex == dgv_Reservation.Columns["ID_Service"].Index && e.RowIndex >= 0)
        //        {
        //            selectedID = dgv_Reservation.Rows[e.RowIndex].Cells["ID_Service"].Value.ToString();
        //            ShowlistOfReservation(selectedID);
        //        }
        //        else return;
        //}
        //public void ShowDiscountOfService(string selectedID)
        //{
        //    HotelService_DTO IdService = new HotelService_DTO(selectedID);
        //    if (HotelService_BUS.LoadDataDiscountService(IdService).Rows.Count <= 0)
        //    {
        //        MessageBox.Show("Dịch vụ không có chương trình khuyến mãi");
        //        Discount_DataGid.DataSource = null;
        //        return;
        //    }
        //    dgv_Reservation.DataSource = HotelService_BUS.LoadDataDiscountService(IdService);
        //}
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
    }
}
