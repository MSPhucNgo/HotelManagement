namespace GUI_HotelManagement
{
    partial class Reservation
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.bt_Check_Out = new System.Windows.Forms.Button();
			this.bt_Check_In = new System.Windows.Forms.Button();
			this.bt_Exit = new System.Windows.Forms.Button();
			this.bt_Edit_Reservation = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dgv_Reservation = new System.Windows.Forms.DataGridView();
			this.lb_List_Of_Reservation = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cb_BookingID = new System.Windows.Forms.ComboBox();
			this.bt_Search_Reservation = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_List_Of_Items = new System.Windows.Forms.Label();
			this.bookingFormBUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Reservation)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bookingFormBUSBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.lb_List_Of_Items);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1093, 599);
			this.panel1.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.LightGray;
			this.panel3.Controls.Add(this.bt_Exit);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Location = new System.Drawing.Point(0, 39);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1093, 560);
			this.panel3.TabIndex = 2;
			// 
			// bt_Check_Out
			// 
			this.bt_Check_Out.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Check_Out.Location = new System.Drawing.Point(843, 28);
			this.bt_Check_Out.Name = "bt_Check_Out";
			this.bt_Check_Out.Size = new System.Drawing.Size(100, 29);
			this.bt_Check_Out.TabIndex = 5;
			this.bt_Check_Out.Text = "CHECKOUT";
			this.bt_Check_Out.UseVisualStyleBackColor = false;
			this.bt_Check_Out.Click += new System.EventHandler(this.bt_Check_Out_Click);
			// 
			// bt_Check_In
			// 
			this.bt_Check_In.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Check_In.Location = new System.Drawing.Point(706, 28);
			this.bt_Check_In.Name = "bt_Check_In";
			this.bt_Check_In.Size = new System.Drawing.Size(100, 29);
			this.bt_Check_In.TabIndex = 4;
			this.bt_Check_In.Text = "CHECKIN";
			this.bt_Check_In.UseVisualStyleBackColor = false;
			this.bt_Check_In.Click += new System.EventHandler(this.button1_Click);
			// 
			// bt_Exit
			// 
			this.bt_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Exit.Location = new System.Drawing.Point(887, 516);
			this.bt_Exit.Name = "bt_Exit";
			this.bt_Exit.Size = new System.Drawing.Size(75, 29);
			this.bt_Exit.TabIndex = 3;
			this.bt_Exit.Text = "EXIT";
			this.bt_Exit.UseVisualStyleBackColor = false;
			this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
			// 
			// bt_Edit_Reservation
			// 
			this.bt_Edit_Reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Edit_Reservation.Location = new System.Drawing.Point(517, 28);
			this.bt_Edit_Reservation.Name = "bt_Edit_Reservation";
			this.bt_Edit_Reservation.Size = new System.Drawing.Size(150, 29);
			this.bt_Edit_Reservation.TabIndex = 2;
			this.bt_Edit_Reservation.Text = "EDIT RESERVATION";
			this.bt_Edit_Reservation.UseVisualStyleBackColor = false;
			this.bt_Edit_Reservation.Click += new System.EventHandler(this.bt_Edit_Reservation_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Gainsboro;
			this.panel5.Controls.Add(this.dgv_Reservation);
			this.panel5.Controls.Add(this.lb_List_Of_Reservation);
			this.panel5.ForeColor = System.Drawing.Color.Silver;
			this.panel5.Location = new System.Drawing.Point(18, 111);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1054, 387);
			this.panel5.TabIndex = 1;
			// 
			// dgv_Reservation
			// 
			this.dgv_Reservation.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dgv_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Reservation.Location = new System.Drawing.Point(0, 42);
			this.dgv_Reservation.Name = "dgv_Reservation";
			this.dgv_Reservation.RowHeadersWidth = 51;
			this.dgv_Reservation.RowTemplate.Height = 29;
			this.dgv_Reservation.Size = new System.Drawing.Size(1054, 345);
			this.dgv_Reservation.TabIndex = 6;
			this.dgv_Reservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Reservation_CellContentClick);
			// 
			// lb_List_Of_Reservation
			// 
			this.lb_List_Of_Reservation.AutoSize = true;
			this.lb_List_Of_Reservation.BackColor = System.Drawing.Color.Transparent;
			this.lb_List_Of_Reservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lb_List_Of_Reservation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lb_List_Of_Reservation.ForeColor = System.Drawing.Color.Black;
			this.lb_List_Of_Reservation.Location = new System.Drawing.Point(0, 0);
			this.lb_List_Of_Reservation.Name = "lb_List_Of_Reservation";
			this.lb_List_Of_Reservation.Size = new System.Drawing.Size(244, 40);
			this.lb_List_Of_Reservation.TabIndex = 4;
			this.lb_List_Of_Reservation.Text = "LIST OF RESERVATION";
			this.lb_List_Of_Reservation.UseCompatibleTextRendering = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkGray;
			this.panel4.Controls.Add(this.bt_Check_Out);
			this.panel4.Controls.Add(this.cb_BookingID);
			this.panel4.Controls.Add(this.bt_Check_In);
			this.panel4.Controls.Add(this.bt_Search_Reservation);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.bt_Edit_Reservation);
			this.panel4.Location = new System.Drawing.Point(19, 21);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1053, 84);
			this.panel4.TabIndex = 0;
			this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			// 
			// cb_BookingID
			// 
			this.cb_BookingID.FormattingEnabled = true;
			this.cb_BookingID.Location = new System.Drawing.Point(159, 28);
			this.cb_BookingID.Name = "cb_BookingID";
			this.cb_BookingID.Size = new System.Drawing.Size(199, 28);
			this.cb_BookingID.TabIndex = 36;
			this.cb_BookingID.SelectedIndexChanged += new System.EventHandler(this.cb_BookingID_SelectedIndexChanged);
			// 
			// bt_Search_Reservation
			// 
			this.bt_Search_Reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Search_Reservation.Location = new System.Drawing.Point(401, 28);
			this.bt_Search_Reservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bt_Search_Reservation.Name = "bt_Search_Reservation";
			this.bt_Search_Reservation.Size = new System.Drawing.Size(75, 29);
			this.bt_Search_Reservation.TabIndex = 35;
			this.bt_Search_Reservation.Text = "SEARCH";
			this.bt_Search_Reservation.UseVisualStyleBackColor = false;
			this.bt_Search_Reservation.Click += new System.EventHandler(this.bt_Search_Reservation_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 33;
			this.label1.Text = "BOOKING ID:";
			// 
			// lb_List_Of_Items
			// 
			this.lb_List_Of_Items.AutoSize = true;
			this.lb_List_Of_Items.BackColor = System.Drawing.Color.Transparent;
			this.lb_List_Of_Items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lb_List_Of_Items.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lb_List_Of_Items.Location = new System.Drawing.Point(0, 0);
			this.lb_List_Of_Items.Name = "lb_List_Of_Items";
			this.lb_List_Of_Items.Size = new System.Drawing.Size(179, 40);
			this.lb_List_Of_Items.TabIndex = 1;
			this.lb_List_Of_Items.Text = "RESERVATION\r\n";
			this.lb_List_Of_Items.UseCompatibleTextRendering = true;
			// 
			// bookingFormBUSBindingSource
			// 
			this.bookingFormBUSBindingSource.DataSource = typeof(BUS_HotelManagement.BookingForm_BUS);
			// 
			// Reservation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1117, 623);
			this.Controls.Add(this.panel1);
			this.Name = "Reservation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reservation";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Reservation)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bookingFormBUSBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Label lb_List_Of_Reservation;
        private Panel panel4;
        private Button bt_Search_Reservation;
        private Label label1;
        private Label lb_List_Of_Items;
        private Button bt_Edit_Reservation;
        private DataGridView dgv_Reservation;
        private Button bt_Exit;
        private Button bt_Check_In;
        private ComboBox cb_BookingID;
        private BindingSource bookingFormBUSBindingSource;
        private Button bt_Check_Out;
	}
}