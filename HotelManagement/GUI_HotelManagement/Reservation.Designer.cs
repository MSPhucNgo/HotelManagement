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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_Edit_Reservation = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_Reservation = new System.Windows.Forms.DataGridView();
            this.lb_List_Of_Items_Room = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_Search_Reservation = new System.Windows.Forms.Button();
            this.text_Customer_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Room_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_List_Of_Items = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservation)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lb_List_Of_Items);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 729);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.bt_Exit);
            this.panel3.Controls.Add(this.bt_Edit_Reservation);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 690);
            this.panel3.TabIndex = 2;
            // 
            // bt_Edit_Reservation
            // 
            this.bt_Edit_Reservation.Location = new System.Drawing.Point(500, 623);
            this.bt_Edit_Reservation.Name = "bt_Edit_Reservation";
            this.bt_Edit_Reservation.Size = new System.Drawing.Size(150, 29);
            this.bt_Edit_Reservation.TabIndex = 2;
            this.bt_Edit_Reservation.Text = "EDIT RESERVATION";
            this.bt_Edit_Reservation.UseVisualStyleBackColor = true;
            this.bt_Edit_Reservation.Click += new System.EventHandler(this.bt_Edit_Reservation_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.dgv_Reservation);
            this.panel5.Controls.Add(this.lb_List_Of_Items_Room);
            this.panel5.ForeColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(18, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1320, 440);
            this.panel5.TabIndex = 1;
            // 
            // dgv_Reservation
            // 
            this.dgv_Reservation.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reservation.Location = new System.Drawing.Point(2, 42);
            this.dgv_Reservation.Name = "dgv_Reservation";
            this.dgv_Reservation.RowHeadersWidth = 51;
            this.dgv_Reservation.RowTemplate.Height = 29;
            this.dgv_Reservation.Size = new System.Drawing.Size(1317, 398);
            this.dgv_Reservation.TabIndex = 6;
            this.dgv_Reservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Reservation_CellContentClick);
            // 
            // lb_List_Of_Items_Room
            // 
            this.lb_List_Of_Items_Room.AutoSize = true;
            this.lb_List_Of_Items_Room.BackColor = System.Drawing.Color.Transparent;
            this.lb_List_Of_Items_Room.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_List_Of_Items_Room.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_List_Of_Items_Room.ForeColor = System.Drawing.Color.Black;
            this.lb_List_Of_Items_Room.Location = new System.Drawing.Point(0, 0);
            this.lb_List_Of_Items_Room.Name = "lb_List_Of_Items_Room";
            this.lb_List_Of_Items_Room.Size = new System.Drawing.Size(159, 40);
            this.lb_List_Of_Items_Room.TabIndex = 4;
            this.lb_List_Of_Items_Room.Text = "RESERVATION";
            this.lb_List_Of_Items_Room.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.bt_Search_Reservation);
            this.panel4.Controls.Add(this.text_Customer_Name);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.text_Room_ID);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(19, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1320, 150);
            this.panel4.TabIndex = 0;
            // 
            // bt_Search_Reservation
            // 
            this.bt_Search_Reservation.Location = new System.Drawing.Point(813, 54);
            this.bt_Search_Reservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Search_Reservation.Name = "bt_Search_Reservation";
            this.bt_Search_Reservation.Size = new System.Drawing.Size(75, 29);
            this.bt_Search_Reservation.TabIndex = 35;
            this.bt_Search_Reservation.Text = "SEARCH";
            this.bt_Search_Reservation.UseVisualStyleBackColor = true;
            // 
            // text_Customer_Name
            // 
            this.text_Customer_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Customer_Name.Location = new System.Drawing.Point(575, 85);
            this.text_Customer_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_Customer_Name.Name = "text_Customer_Name";
            this.text_Customer_Name.Size = new System.Drawing.Size(201, 27);
            this.text_Customer_Name.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "CUSTOMER NAME:";
            // 
            // text_Room_ID
            // 
            this.text_Room_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Room_ID.Location = new System.Drawing.Point(575, 24);
            this.text_Room_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_Room_ID.Name = "text_Room_ID";
            this.text_Room_ID.Size = new System.Drawing.Size(201, 27);
            this.text_Room_ID.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "ROOM ID:";
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
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(697, 623);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(75, 29);
            this.bt_Exit.TabIndex = 3;
            this.bt_Exit.Text = "EXIT";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Label lb_List_Of_Items_Room;
        private Panel panel4;
        private Button bt_Search_Reservation;
        private TextBox text_Customer_Name;
        private Label label1;
        private TextBox text_Room_ID;
        private Label label2;
        private Label lb_List_Of_Items;
        private Button bt_Edit_Reservation;
        private DataGridView dgv_Reservation;
        private Button bt_Exit;
    }
}