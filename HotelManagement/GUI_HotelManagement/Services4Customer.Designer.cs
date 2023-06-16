namespace HotelManagement
{
    partial class Services4Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl_services_for_customer = new TabControl();
            tabPage1 = new TabPage();
            dtgvRoomList = new DataGridView();
            panel1 = new Panel();
            btn_room_search = new Button();
            txbRoomID = new TextBox();
            lb_room_search = new Label();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Departure = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btn_tour_search = new Button();
            textBox5 = new TextBox();
            lb_tour_search_tour_sort = new Label();
            textBox4 = new TextBox();
            lb_tour_search_leaving_time = new Label();
            textBox3 = new TextBox();
            lb_tour_search_des = new Label();
            textBox2 = new TextBox();
            lb_tour_search_dep = new Label();
            tabPage3 = new TabPage();
            tabControl_services_for_customer.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRoomList).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_services_for_customer
            // 
            tabControl_services_for_customer.Controls.Add(tabPage1);
            tabControl_services_for_customer.Controls.Add(tabPage2);
            tabControl_services_for_customer.Controls.Add(tabPage3);
            tabControl_services_for_customer.Location = new Point(9, 9);
            tabControl_services_for_customer.Margin = new Padding(2, 3, 2, 3);
            tabControl_services_for_customer.Name = "tabControl_services_for_customer";
            tabControl_services_for_customer.SelectedIndex = 0;
            tabControl_services_for_customer.Size = new Size(971, 585);
            tabControl_services_for_customer.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dtgvRoomList);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2, 3, 2, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 3, 2, 3);
            tabPage1.Size = new Size(963, 552);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Room Search";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgvRoomList
            // 
            dtgvRoomList.AllowUserToAddRows = false;
            dtgvRoomList.AllowUserToDeleteRows = false;
            dtgvRoomList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRoomList.Location = new Point(5, 44);
            dtgvRoomList.Margin = new Padding(2, 3, 2, 3);
            dtgvRoomList.Name = "dtgvRoomList";
            dtgvRoomList.ReadOnly = true;
            dtgvRoomList.RowHeadersWidth = 62;
            dtgvRoomList.RowTemplate.Height = 33;
            dtgvRoomList.Size = new Size(827, 507);
            dtgvRoomList.TabIndex = 1;
            dtgvRoomList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_room_search);
            panel1.Controls.Add(txbRoomID);
            panel1.Controls.Add(lb_room_search);
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 35);
            panel1.TabIndex = 0;
            // 
            // btn_room_search
            // 
            btn_room_search.Location = new Point(389, 3);
            btn_room_search.Margin = new Padding(2, 3, 2, 3);
            btn_room_search.Name = "btn_room_search";
            btn_room_search.Size = new Size(89, 27);
            btn_room_search.TabIndex = 2;
            btn_room_search.Text = "Search";
            btn_room_search.UseVisualStyleBackColor = true;
            btn_room_search.Click += btn_room_search_Click;
            // 
            // txbRoomID
            // 
            txbRoomID.Location = new Point(73, 5);
            txbRoomID.Margin = new Padding(2, 3, 2, 3);
            txbRoomID.Name = "txbRoomID";
            txbRoomID.Size = new Size(222, 27);
            txbRoomID.TabIndex = 1;
            txbRoomID.TextChanged += textBox1_TextChanged;
            // 
            // lb_room_search
            // 
            lb_room_search.AutoSize = true;
            lb_room_search.Location = new Point(2, 7);
            lb_room_search.Margin = new Padding(2, 0, 2, 0);
            lb_room_search.Name = "lb_room_search";
            lb_room_search.Size = new Size(68, 20);
            lb_room_search.TabIndex = 0;
            lb_room_search.Text = "Room ID";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2, 3, 2, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 3, 2, 3);
            tabPage2.Size = new Size(963, 552);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tour Search";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeight = 34;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Departure, Column9, Column10, Column11, Column12, Column13 });
            dataGridView2.Location = new Point(5, 79);
            dataGridView2.Margin = new Padding(2, 3, 2, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(941, 180);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // Column7
            // 
            Column7.HeaderText = "No.";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 50;
            // 
            // Column8
            // 
            Column8.HeaderText = "Tour Name";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 250;
            // 
            // Departure
            // 
            Departure.HeaderText = "Departure";
            Departure.MinimumWidth = 8;
            Departure.Name = "Departure";
            Departure.Width = 200;
            // 
            // Column9
            // 
            Column9.HeaderText = "Destination";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 200;
            // 
            // Column10
            // 
            Column10.HeaderText = "Starting Time";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Width = 150;
            // 
            // Column11
            // 
            Column11.HeaderText = "Ending Time";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.Width = 150;
            // 
            // Column12
            // 
            Column12.HeaderText = "Partner";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.Width = 150;
            // 
            // Column13
            // 
            Column13.HeaderText = "Max of Participants";
            Column13.MinimumWidth = 8;
            Column13.Name = "Column13";
            Column13.Width = 150;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_tour_search);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(lb_tour_search_tour_sort);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(lb_tour_search_leaving_time);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(lb_tour_search_des);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lb_tour_search_dep);
            panel2.Location = new Point(5, 3);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 71);
            panel2.TabIndex = 0;
            // 
            // btn_tour_search
            // 
            btn_tour_search.Location = new Point(666, 20);
            btn_tour_search.Margin = new Padding(2, 3, 2, 3);
            btn_tour_search.Name = "btn_tour_search";
            btn_tour_search.Size = new Size(89, 27);
            btn_tour_search.TabIndex = 0;
            btn_tour_search.Text = "Search tour";
            btn_tour_search.UseVisualStyleBackColor = true;
            btn_tour_search.Click += btn_tour_search_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(401, 37);
            textBox5.Margin = new Padding(2, 3, 2, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(169, 27);
            textBox5.TabIndex = 7;
            // 
            // lb_tour_search_tour_sort
            // 
            lb_tour_search_tour_sort.AutoSize = true;
            lb_tour_search_tour_sort.Location = new Point(306, 39);
            lb_tour_search_tour_sort.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_tour_sort.Name = "lb_tour_search_tour_sort";
            lb_tour_search_tour_sort.Size = new Size(72, 20);
            lb_tour_search_tour_sort.TabIndex = 6;
            lb_tour_search_tour_sort.Text = "Tour Sort:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(105, 37);
            textBox4.Margin = new Padding(2, 3, 2, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(169, 27);
            textBox4.TabIndex = 5;
            // 
            // lb_tour_search_leaving_time
            // 
            lb_tour_search_leaving_time.AutoSize = true;
            lb_tour_search_leaving_time.Location = new Point(2, 37);
            lb_tour_search_leaving_time.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_leaving_time.Name = "lb_tour_search_leaving_time";
            lb_tour_search_leaving_time.Size = new Size(100, 20);
            lb_tour_search_leaving_time.TabIndex = 4;
            lb_tour_search_leaving_time.Text = "Leaving Time:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(401, 5);
            textBox3.Margin = new Padding(2, 3, 2, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 3;
            // 
            // lb_tour_search_des
            // 
            lb_tour_search_des.AutoSize = true;
            lb_tour_search_des.Location = new Point(306, 7);
            lb_tour_search_des.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_des.Name = "lb_tour_search_des";
            lb_tour_search_des.Size = new Size(88, 20);
            lb_tour_search_des.TabIndex = 2;
            lb_tour_search_des.Text = "Destination:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 5);
            textBox2.Margin = new Padding(2, 3, 2, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 1;
            // 
            // lb_tour_search_dep
            // 
            lb_tour_search_dep.AutoSize = true;
            lb_tour_search_dep.Location = new Point(2, 7);
            lb_tour_search_dep.Margin = new Padding(2, 0, 2, 0);
            lb_tour_search_dep.Name = "lb_tour_search_dep";
            lb_tour_search_dep.Size = new Size(79, 20);
            lb_tour_search_dep.TabIndex = 0;
            lb_tour_search_dep.Text = "Departure:";
            lb_tour_search_dep.Click += label2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(2, 3, 2, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 3, 2, 3);
            tabPage3.Size = new Size(963, 552);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Service Search";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Services_for_customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 843);
            Controls.Add(tabControl_services_for_customer);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Services_for_customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Services_for_customer";
            tabControl_services_for_customer.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRoomList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_services_for_customer;
        private TabPage tabPage1;
        private DataGridView dtgvRoomList;
        private Panel panel1;
        private Button btn_room_search;
        private TextBox txbRoomID;
        private Label lb_room_search;
        private TabPage tabPage2;
        private Label lb_tour_search_dep;
        private Panel panel2;
        private TabPage tabPage3;
        private TextBox textBox5;
        private Label lb_tour_search_tour_sort;
        private TextBox textBox4;
        private Label lb_tour_search_leaving_time;
        private TextBox textBox3;
        private Label lb_tour_search_des;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Button btn_tour_search;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn ID_ROOM;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn STATUS;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewTextBoxColumn TYPE;
    }
}