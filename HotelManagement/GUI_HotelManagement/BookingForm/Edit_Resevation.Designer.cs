namespace GUI_HotelManagement
{
    partial class Edit_Resevation
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cb_BookingID_Edit = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cb_RoomType = new System.Windows.Forms.ComboBox();
			this.date_Departure = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.date_Arrive = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_Special_Re = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tb_Amount = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_Customer_Name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.bt_Exit = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dgv_Reservation = new System.Windows.Forms.DataGridView();
			this.lb_List_Of_Reservation = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.cb_BookingID = new System.Windows.Forms.ComboBox();
			this.bt_Search_Reservation = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.bt_Cancel = new System.Windows.Forms.Button();
			this.bt_Edit_Reservation = new System.Windows.Forms.Button();
			this.lb_Edit_Reservation = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Reservation)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.lb_Edit_Reservation);
			this.panel1.Location = new System.Drawing.Point(10, 9);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(956, 442);
			this.panel1.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Silver;
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Controls.Add(this.bt_Exit);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel2);
			this.panel3.Controls.Add(this.bt_Cancel);
			this.panel3.Controls.Add(this.bt_Edit_Reservation);
			this.panel3.Location = new System.Drawing.Point(0, 29);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(956, 413);
			this.panel3.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Gainsboro;
			this.panel4.Controls.Add(this.cb_BookingID_Edit);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.cb_RoomType);
			this.panel4.Controls.Add(this.date_Departure);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.date_Arrive);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.tb_Special_Re);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.tb_Amount);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.tb_Customer_Name);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(17, 58);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(429, 318);
			this.panel4.TabIndex = 54;
			// 
			// cb_BookingID_Edit
			// 
			this.cb_BookingID_Edit.FormattingEnabled = true;
			this.cb_BookingID_Edit.Location = new System.Drawing.Point(182, 12);
			this.cb_BookingID_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cb_BookingID_Edit.Name = "cb_BookingID_Edit";
			this.cb_BookingID_Edit.Size = new System.Drawing.Size(219, 23);
			this.cb_BookingID_Edit.TabIndex = 51;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 15);
			this.label6.TabIndex = 50;
			this.label6.Text = "BOOKING ID:";
			// 
			// cb_RoomType
			// 
			this.cb_RoomType.FormattingEnabled = true;
			this.cb_RoomType.Location = new System.Drawing.Point(182, 275);
			this.cb_RoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cb_RoomType.Name = "cb_RoomType";
			this.cb_RoomType.Size = new System.Drawing.Size(219, 23);
			this.cb_RoomType.TabIndex = 49;
			// 
			// date_Departure
			// 
			this.date_Departure.Location = new System.Drawing.Point(182, 137);
			this.date_Departure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.date_Departure.Name = "date_Departure";
			this.date_Departure.Size = new System.Drawing.Size(219, 23);
			this.date_Departure.TabIndex = 48;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 15);
			this.label1.TabIndex = 47;
			this.label1.Text = "DAY OF LEAVING:";
			// 
			// date_Arrive
			// 
			this.date_Arrive.Location = new System.Drawing.Point(182, 95);
			this.date_Arrive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.date_Arrive.Name = "date_Arrive";
			this.date_Arrive.Size = new System.Drawing.Size(219, 23);
			this.date_Arrive.TabIndex = 46;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(22, 278);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 15);
			this.label8.TabIndex = 44;
			this.label8.Text = "ROOM TYPE:";
			// 
			// tb_Special_Re
			// 
			this.tb_Special_Re.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_Special_Re.Location = new System.Drawing.Point(182, 231);
			this.tb_Special_Re.Name = "tb_Special_Re";
			this.tb_Special_Re.Size = new System.Drawing.Size(219, 23);
			this.tb_Special_Re.TabIndex = 43;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 233);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(141, 15);
			this.label9.TabIndex = 42;
			this.label9.Text = "SPECIAL REQUIREMENTS:";
			// 
			// tb_Amount
			// 
			this.tb_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_Amount.Location = new System.Drawing.Point(182, 183);
			this.tb_Amount.Name = "tb_Amount";
			this.tb_Amount.Size = new System.Drawing.Size(219, 23);
			this.tb_Amount.TabIndex = 41;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(22, 185);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(120, 15);
			this.label10.TabIndex = 40;
			this.label10.Text = "NUMBER OF PEOPLE:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 15);
			this.label5.TabIndex = 38;
			this.label5.Text = "DATE OF ARRIVE:";
			// 
			// tb_Customer_Name
			// 
			this.tb_Customer_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_Customer_Name.Location = new System.Drawing.Point(182, 52);
			this.tb_Customer_Name.Name = "tb_Customer_Name";
			this.tb_Customer_Name.Size = new System.Drawing.Size(219, 23);
			this.tb_Customer_Name.TabIndex = 37;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 15);
			this.label4.TabIndex = 36;
			this.label4.Text = "CUSTOMER NAME:";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Controls.Add(this.label3);
			this.panel6.Location = new System.Drawing.Point(17, 17);
			this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(429, 358);
			this.panel6.TabIndex = 51;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(116, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(169, 30);
			this.label3.TabIndex = 52;
			this.label3.Text = "EDIT RESERVATION";
			this.label3.UseCompatibleTextRendering = true;
			// 
			// bt_Exit
			// 
			this.bt_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Exit.Location = new System.Drawing.Point(835, 380);
			this.bt_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_Exit.Name = "bt_Exit";
			this.bt_Exit.Size = new System.Drawing.Size(66, 22);
			this.bt_Exit.TabIndex = 9;
			this.bt_Exit.Text = "EXIT";
			this.bt_Exit.UseVisualStyleBackColor = false;
			this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Gainsboro;
			this.panel5.Controls.Add(this.dgv_Reservation);
			this.panel5.Controls.Add(this.lb_List_Of_Reservation);
			this.panel5.ForeColor = System.Drawing.Color.Silver;
			this.panel5.Location = new System.Drawing.Point(451, 90);
			this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(489, 286);
			this.panel5.TabIndex = 8;
			// 
			// dgv_Reservation
			// 
			this.dgv_Reservation.BackgroundColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Reservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Reservation.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_Reservation.GridColor = System.Drawing.SystemColors.ControlText;
			this.dgv_Reservation.Location = new System.Drawing.Point(0, 32);
			this.dgv_Reservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgv_Reservation.Name = "dgv_Reservation";
			this.dgv_Reservation.RowHeadersWidth = 51;
			this.dgv_Reservation.RowTemplate.Height = 29;
			this.dgv_Reservation.Size = new System.Drawing.Size(489, 254);
			this.dgv_Reservation.TabIndex = 7;
			// 
			// lb_List_Of_Reservation
			// 
			this.lb_List_Of_Reservation.AutoSize = true;
			this.lb_List_Of_Reservation.BackColor = System.Drawing.Color.Transparent;
			this.lb_List_Of_Reservation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lb_List_Of_Reservation.ForeColor = System.Drawing.Color.Black;
			this.lb_List_Of_Reservation.Location = new System.Drawing.Point(128, 4);
			this.lb_List_Of_Reservation.Name = "lb_List_Of_Reservation";
			this.lb_List_Of_Reservation.Size = new System.Drawing.Size(194, 30);
			this.lb_List_Of_Reservation.TabIndex = 4;
			this.lb_List_Of_Reservation.Text = "LIST OF RESERVATION";
			this.lb_List_Of_Reservation.UseCompatibleTextRendering = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGray;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.cb_BookingID);
			this.panel2.Controls.Add(this.bt_Search_Reservation);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(451, 17);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(489, 63);
			this.panel2.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(402, 20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(66, 22);
			this.button1.TabIndex = 37;
			this.button1.Text = "ALL";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cb_BookingID
			// 
			this.cb_BookingID.FormattingEnabled = true;
			this.cb_BookingID.Location = new System.Drawing.Point(114, 20);
			this.cb_BookingID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cb_BookingID.Name = "cb_BookingID";
			this.cb_BookingID.Size = new System.Drawing.Size(175, 23);
			this.cb_BookingID.TabIndex = 36;
			// 
			// bt_Search_Reservation
			// 
			this.bt_Search_Reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Search_Reservation.Location = new System.Drawing.Point(316, 20);
			this.bt_Search_Reservation.Name = "bt_Search_Reservation";
			this.bt_Search_Reservation.Size = new System.Drawing.Size(66, 22);
			this.bt_Search_Reservation.TabIndex = 35;
			this.bt_Search_Reservation.Text = "SEARCH";
			this.bt_Search_Reservation.UseVisualStyleBackColor = false;
			this.bt_Search_Reservation.Click += new System.EventHandler(this.bt_Search_Reservation_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 15);
			this.label2.TabIndex = 33;
			this.label2.Text = "BOOKING ID:";
			// 
			// bt_Cancel
			// 
			this.bt_Cancel.Location = new System.Drawing.Point(516, 380);
			this.bt_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_Cancel.Name = "bt_Cancel";
			this.bt_Cancel.Size = new System.Drawing.Size(82, 22);
			this.bt_Cancel.TabIndex = 5;
			this.bt_Cancel.Text = "CANCEL";
			this.bt_Cancel.UseVisualStyleBackColor = true;
			this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click_1);
			// 
			// bt_Edit_Reservation
			// 
			this.bt_Edit_Reservation.Location = new System.Drawing.Point(176, 380);
			this.bt_Edit_Reservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_Edit_Reservation.Name = "bt_Edit_Reservation";
			this.bt_Edit_Reservation.Size = new System.Drawing.Size(82, 22);
			this.bt_Edit_Reservation.TabIndex = 4;
			this.bt_Edit_Reservation.Text = "EDIT";
			this.bt_Edit_Reservation.UseVisualStyleBackColor = true;
			this.bt_Edit_Reservation.Click += new System.EventHandler(this.bt_Edit_Reservation_Click_1);
			// 
			// lb_Edit_Reservation
			// 
			this.lb_Edit_Reservation.AutoSize = true;
			this.lb_Edit_Reservation.BackColor = System.Drawing.Color.Transparent;
			this.lb_Edit_Reservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lb_Edit_Reservation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lb_Edit_Reservation.Location = new System.Drawing.Point(0, 0);
			this.lb_Edit_Reservation.Name = "lb_Edit_Reservation";
			this.lb_Edit_Reservation.Size = new System.Drawing.Size(183, 33);
			this.lb_Edit_Reservation.TabIndex = 1;
			this.lb_Edit_Reservation.Text = "EDIT RESERVATION";
			this.lb_Edit_Reservation.UseCompatibleTextRendering = true;
			// 
			// Edit_Resevation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(977, 460);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Edit_Resevation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit_Resevation";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Reservation)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label lb_Edit_Reservation;
        private Button bt_Cancel;
        private Button bt_Edit_Reservation;
		private Panel panel2;
		private ComboBox cb_BookingID;
		private Button bt_Search_Reservation;
		private Label label2;
		private Panel panel5;
		private DataGridView dgv_Reservation;
		private Label lb_List_Of_Reservation;
		private Button bt_Exit;
		private Button button1;
		private Panel panel4;
		private ComboBox cb_RoomType;
		private DateTimePicker date_Departure;
		private Label label1;
		private DateTimePicker date_Arrive;
		private Label label8;
		private TextBox tb_Special_Re;
		private Label label9;
		private TextBox tb_Amount;
		private Label label10;
		private Label label5;
		private TextBox tb_Customer_Name;
		private Label label4;
		private Panel panel6;
		private Label label3;
		private ComboBox cb_BookingID_Edit;
		private Label label6;
	}
}