namespace PTTK_ServicePart
{
    partial class Services_for_customer
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
            this.tabControl_services_for_customer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_room_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_room_search = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_tour_search = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lb_tour_search_tour_sort = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lb_tour_search_leaving_time = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lb_tour_search_des = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_tour_search_dep = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl_services_for_customer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_services_for_customer
            // 
            this.tabControl_services_for_customer.Controls.Add(this.tabPage1);
            this.tabControl_services_for_customer.Controls.Add(this.tabPage2);
            this.tabControl_services_for_customer.Controls.Add(this.tabPage3);
            this.tabControl_services_for_customer.Location = new System.Drawing.Point(12, 12);
            this.tabControl_services_for_customer.Name = "tabControl_services_for_customer";
            this.tabControl_services_for_customer.SelectedIndex = 0;
            this.tabControl_services_for_customer.Size = new System.Drawing.Size(1215, 732);
            this.tabControl_services_for_customer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1207, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Room Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(998, 633);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No.";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room ID";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone Num";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Coming Date";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Leaving Date";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_room_search);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lb_room_search);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 43);
            this.panel1.TabIndex = 0;
            // 
            // btn_room_search
            // 
            this.btn_room_search.Location = new System.Drawing.Point(485, 3);
            this.btn_room_search.Name = "btn_room_search";
            this.btn_room_search.Size = new System.Drawing.Size(112, 34);
            this.btn_room_search.TabIndex = 2;
            this.btn_room_search.Text = "Search";
            this.btn_room_search.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 31);
            this.textBox1.TabIndex = 1;
            // 
            // lb_room_search
            // 
            this.lb_room_search.AutoSize = true;
            this.lb_room_search.Location = new System.Drawing.Point(3, 9);
            this.lb_room_search.Name = "lb_room_search";
            this.lb_room_search.Size = new System.Drawing.Size(83, 25);
            this.lb_room_search.TabIndex = 0;
            this.lb_room_search.Text = "Room ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1207, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tour Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeight = 34;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Departure,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dataGridView2.Location = new System.Drawing.Point(6, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(1176, 225);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "No.";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tour Name";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 250;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.MinimumWidth = 8;
            this.Departure.Name = "Departure";
            this.Departure.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Destination";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Starting Time";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ending Time";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Partner";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Max of Participants";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_tour_search);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.lb_tour_search_tour_sort);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.lb_tour_search_leaving_time);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.lb_tour_search_des);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.lb_tour_search_dep);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 89);
            this.panel2.TabIndex = 0;
            // 
            // btn_tour_search
            // 
            this.btn_tour_search.Location = new System.Drawing.Point(833, 25);
            this.btn_tour_search.Name = "btn_tour_search";
            this.btn_tour_search.Size = new System.Drawing.Size(112, 34);
            this.btn_tour_search.TabIndex = 0;
            this.btn_tour_search.Text = "Search tour";
            this.btn_tour_search.UseVisualStyleBackColor = true;
            this.btn_tour_search.Click += new System.EventHandler(this.btn_tour_search_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(501, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 31);
            this.textBox5.TabIndex = 7;
            // 
            // lb_tour_search_tour_sort
            // 
            this.lb_tour_search_tour_sort.AutoSize = true;
            this.lb_tour_search_tour_sort.Location = new System.Drawing.Point(383, 49);
            this.lb_tour_search_tour_sort.Name = "lb_tour_search_tour_sort";
            this.lb_tour_search_tour_sort.Size = new System.Drawing.Size(88, 25);
            this.lb_tour_search_tour_sort.TabIndex = 6;
            this.lb_tour_search_tour_sort.Text = "Tour Sort:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 31);
            this.textBox4.TabIndex = 5;
            // 
            // lb_tour_search_leaving_time
            // 
            this.lb_tour_search_leaving_time.AutoSize = true;
            this.lb_tour_search_leaving_time.Location = new System.Drawing.Point(3, 46);
            this.lb_tour_search_leaving_time.Name = "lb_tour_search_leaving_time";
            this.lb_tour_search_leaving_time.Size = new System.Drawing.Size(119, 25);
            this.lb_tour_search_leaving_time.TabIndex = 4;
            this.lb_tour_search_leaving_time.Text = "Leaving Time:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(501, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 31);
            this.textBox3.TabIndex = 3;
            // 
            // lb_tour_search_des
            // 
            this.lb_tour_search_des.AutoSize = true;
            this.lb_tour_search_des.Location = new System.Drawing.Point(383, 9);
            this.lb_tour_search_des.Name = "lb_tour_search_des";
            this.lb_tour_search_des.Size = new System.Drawing.Size(106, 25);
            this.lb_tour_search_des.TabIndex = 2;
            this.lb_tour_search_des.Text = "Destination:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 31);
            this.textBox2.TabIndex = 1;
            // 
            // lb_tour_search_dep
            // 
            this.lb_tour_search_dep.AutoSize = true;
            this.lb_tour_search_dep.Location = new System.Drawing.Point(3, 9);
            this.lb_tour_search_dep.Name = "lb_tour_search_dep";
            this.lb_tour_search_dep.Size = new System.Drawing.Size(95, 25);
            this.lb_tour_search_dep.TabIndex = 0;
            this.lb_tour_search_dep.Text = "Departure:";
            this.lb_tour_search_dep.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1207, 694);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Service Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Services_for_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 724);
            this.Controls.Add(this.tabControl_services_for_customer);
            this.Name = "Services_for_customer";
            this.Text = "Services_for_customer";
            this.tabControl_services_for_customer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl_services_for_customer;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btn_room_search;
        private TextBox textBox1;
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
    }
}