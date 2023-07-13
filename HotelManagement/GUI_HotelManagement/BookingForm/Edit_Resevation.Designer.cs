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
			this.date_Departure = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.date_Arrive = new System.Windows.Forms.DateTimePicker();
			this.tb_Special_Re = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
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
			this.panel1.Location = new System.Drawing.Point(11, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1093, 589);
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
			this.panel3.Location = new System.Drawing.Point(0, 39);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1093, 551);
			this.panel3.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Gainsboro;
			this.panel4.Controls.Add(this.cb_BookingID_Edit);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.date_Departure);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.date_Arrive);
			this.panel4.Controls.Add(this.tb_Special_Re);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.tb_Customer_Name);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(19, 77);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(490, 424);
			this.panel4.TabIndex = 54;
			// 
			// cb_BookingID_Edit
			// 
			this.cb_BookingID_Edit.FormattingEnabled = true;
			this.cb_BookingID_Edit.Location = new System.Drawing.Point(216, 38);
			this.cb_BookingID_Edit.Name = "cb_BookingID_Edit";
			this.cb_BookingID_Edit.Size = new System.Drawing.Size(250, 28);
			this.cb_BookingID_Edit.TabIndex = 51;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(33, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 20);
			this.label6.TabIndex = 50;
			this.label6.Text = "BOOKING ID:";
			// 
			// date_Departure
			// 
			this.date_Departure.Location = new System.Drawing.Point(216, 276);
			this.date_Departure.Name = "date_Departure";
			this.date_Departure.Size = new System.Drawing.Size(250, 27);
			this.date_Departure.TabIndex = 48;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 280);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 20);
			this.label1.TabIndex = 47;
			this.label1.Text = "DAY OF LEAVING:";
			// 
			// date_Arrive
			// 
			this.date_Arrive.Location = new System.Drawing.Point(216, 191);
			this.date_Arrive.Name = "date_Arrive";
			this.date_Arrive.Size = new System.Drawing.Size(250, 27);
			this.date_Arrive.TabIndex = 46;
			// 
			// tb_Special_Re
			// 
			this.tb_Special_Re.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_Special_Re.Location = new System.Drawing.Point(216, 357);
			this.tb_Special_Re.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_Special_Re.Name = "tb_Special_Re";
			this.tb_Special_Re.Size = new System.Drawing.Size(250, 27);
			this.tb_Special_Re.TabIndex = 43;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(33, 360);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(177, 20);
			this.label9.TabIndex = 42;
			this.label9.Text = "SPECIAL REQUIREMENTS:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 196);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 20);
			this.label5.TabIndex = 38;
			this.label5.Text = "DATE OF ARRIVE:";
			// 
			// tb_Customer_Name
			// 
			this.tb_Customer_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_Customer_Name.Location = new System.Drawing.Point(216, 108);
			this.tb_Customer_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tb_Customer_Name.Name = "tb_Customer_Name";
			this.tb_Customer_Name.Size = new System.Drawing.Size(250, 27);
			this.tb_Customer_Name.TabIndex = 37;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 20);
			this.label4.TabIndex = 36;
			this.label4.Text = "CUSTOMER NAME:";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Controls.Add(this.label3);
			this.panel6.Location = new System.Drawing.Point(19, 23);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(490, 477);
			this.panel6.TabIndex = 51;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(133, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(211, 37);
			this.label3.TabIndex = 52;
			this.label3.Text = "EDIT RESERVATION";
			this.label3.UseCompatibleTextRendering = true;
			// 
			// bt_Exit
			// 
			this.bt_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Exit.Location = new System.Drawing.Point(954, 507);
			this.bt_Exit.Name = "bt_Exit";
			this.bt_Exit.Size = new System.Drawing.Size(75, 29);
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
			this.panel5.Location = new System.Drawing.Point(515, 120);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(559, 381);
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
			this.dgv_Reservation.Location = new System.Drawing.Point(0, 43);
			this.dgv_Reservation.Name = "dgv_Reservation";
			this.dgv_Reservation.RowHeadersWidth = 51;
			this.dgv_Reservation.RowTemplate.Height = 29;
			this.dgv_Reservation.Size = new System.Drawing.Size(559, 338);
			this.dgv_Reservation.TabIndex = 7;
			// 
			// lb_List_Of_Reservation
			// 
			this.lb_List_Of_Reservation.AutoSize = true;
			this.lb_List_Of_Reservation.BackColor = System.Drawing.Color.Transparent;
			this.lb_List_Of_Reservation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lb_List_Of_Reservation.ForeColor = System.Drawing.Color.Black;
			this.lb_List_Of_Reservation.Location = new System.Drawing.Point(146, 5);
			this.lb_List_Of_Reservation.Name = "lb_List_Of_Reservation";
			this.lb_List_Of_Reservation.Size = new System.Drawing.Size(242, 37);
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
			this.panel2.Location = new System.Drawing.Point(515, 23);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(559, 84);
			this.panel2.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Location = new System.Drawing.Point(459, 27);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 29);
			this.button1.TabIndex = 37;
			this.button1.Text = "ALL";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cb_BookingID
			// 
			this.cb_BookingID.FormattingEnabled = true;
			this.cb_BookingID.Location = new System.Drawing.Point(130, 27);
			this.cb_BookingID.Name = "cb_BookingID";
			this.cb_BookingID.Size = new System.Drawing.Size(199, 28);
			this.cb_BookingID.TabIndex = 36;
			// 
			// bt_Search_Reservation
			// 
			this.bt_Search_Reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Search_Reservation.Location = new System.Drawing.Point(361, 27);
			this.bt_Search_Reservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bt_Search_Reservation.Name = "bt_Search_Reservation";
			this.bt_Search_Reservation.Size = new System.Drawing.Size(75, 29);
			this.bt_Search_Reservation.TabIndex = 35;
			this.bt_Search_Reservation.Text = "SEARCH";
			this.bt_Search_Reservation.UseVisualStyleBackColor = false;
			this.bt_Search_Reservation.Click += new System.EventHandler(this.bt_Search_Reservation_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 33;
			this.label2.Text = "BOOKING ID:";
			// 
			// bt_Cancel
			// 
			this.bt_Cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Cancel.Location = new System.Drawing.Point(590, 507);
			this.bt_Cancel.Name = "bt_Cancel";
			this.bt_Cancel.Size = new System.Drawing.Size(94, 29);
			this.bt_Cancel.TabIndex = 5;
			this.bt_Cancel.Text = "CANCEL";
			this.bt_Cancel.UseVisualStyleBackColor = false;
			this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click_1);
			// 
			// bt_Edit_Reservation
			// 
			this.bt_Edit_Reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_Edit_Reservation.Location = new System.Drawing.Point(201, 507);
			this.bt_Edit_Reservation.Name = "bt_Edit_Reservation";
			this.bt_Edit_Reservation.Size = new System.Drawing.Size(94, 29);
			this.bt_Edit_Reservation.TabIndex = 4;
			this.bt_Edit_Reservation.Text = "EDIT";
			this.bt_Edit_Reservation.UseVisualStyleBackColor = false;
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
			this.lb_Edit_Reservation.Size = new System.Drawing.Size(228, 40);
			this.lb_Edit_Reservation.TabIndex = 1;
			this.lb_Edit_Reservation.Text = "EDIT RESERVATION";
			this.lb_Edit_Reservation.UseCompatibleTextRendering = true;
			// 
			// Edit_Resevation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1117, 613);
			this.Controls.Add(this.panel1);
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
		private DateTimePicker date_Departure;
		private Label label1;
		private DateTimePicker date_Arrive;
		private TextBox tb_Special_Re;
		private Label label9;
		private Label label5;
		private TextBox tb_Customer_Name;
		private Label label4;
		private Panel panel6;
		private Label label3;
		private ComboBox cb_BookingID_Edit;
		private Label label6;
	}
}