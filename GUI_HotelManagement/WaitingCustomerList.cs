using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_HotelManagement;
using DAO_HotelManagement;
using BUS_HotelManagement;

namespace GUI_HotelManagement
{
    public partial class WaitingCustomerList : Form
    {
        Waiting_BUS busWaiting = new Waiting_BUS();
        public WaitingCustomerList()
        {
            InitializeComponent();
        }

        private void GUI_WaitingList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busWaiting.getWaiting(); 
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
