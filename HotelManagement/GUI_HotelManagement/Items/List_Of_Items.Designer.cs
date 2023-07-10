namespace GUI_HotelManagement
{
    partial class List_Of_Items
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_List_Of_Items = new System.Windows.Forms.DataGridView();
            this.Logout_Button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_List_Of_Items_Room = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_RoomID = new System.Windows.Forms.ComboBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_List_Of_Items = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items_Room)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dgv_List_Of_Items);
            this.panel3.Controls.Add(this.Logout_Button);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 560);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(748, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "ALL OFF ITEMS";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // dgv_List_Of_Items
            // 
            this.dgv_List_Of_Items.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_List_Of_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List_Of_Items.GridColor = System.Drawing.Color.Black;
            this.dgv_List_Of_Items.Location = new System.Drawing.Point(543, 57);
            this.dgv_List_Of_Items.Name = "dgv_List_Of_Items";
            this.dgv_List_Of_Items.RowHeadersWidth = 51;
            this.dgv_List_Of_Items.RowTemplate.Height = 29;
            this.dgv_List_Of_Items.Size = new System.Drawing.Size(542, 463);
            this.dgv_List_Of_Items.TabIndex = 34;
            // 
            // Logout_Button
            // 
            this.Logout_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logout_Button.Location = new System.Drawing.Point(849, 527);
            this.Logout_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(75, 29);
            this.Logout_Button.TabIndex = 33;
            this.Logout_Button.Text = "EXIT";
            this.Logout_Button.UseVisualStyleBackColor = false;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.dgv_List_Of_Items_Room);
            this.panel5.Controls.Add(this.label3);
            this.panel5.ForeColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(18, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(449, 422);
            this.panel5.TabIndex = 1;
            // 
            // dgv_List_Of_Items_Room
            // 
            this.dgv_List_Of_Items_Room.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_List_Of_Items_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_List_Of_Items_Room.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_List_Of_Items_Room.GridColor = System.Drawing.Color.Black;
            this.dgv_List_Of_Items_Room.Location = new System.Drawing.Point(0, 46);
            this.dgv_List_Of_Items_Room.Name = "dgv_List_Of_Items_Room";
            this.dgv_List_Of_Items_Room.RowHeadersWidth = 51;
            this.dgv_List_Of_Items_Room.RowTemplate.Height = 29;
            this.dgv_List_Of_Items_Room.Size = new System.Drawing.Size(449, 376);
            this.dgv_List_Of_Items_Room.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(149, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "INFORMATION";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.cb_RoomID);
            this.panel4.Controls.Add(this.Search_Button);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(19, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 71);
            this.panel4.TabIndex = 0;
            // 
            // cb_RoomID
            // 
            this.cb_RoomID.FormattingEnabled = true;
            this.cb_RoomID.Location = new System.Drawing.Point(128, 25);
            this.cb_RoomID.Name = "cb_RoomID";
            this.cb_RoomID.Size = new System.Drawing.Size(165, 28);
            this.cb_RoomID.TabIndex = 34;
            // 
            // Search_Button
            // 
            this.Search_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Search_Button.Location = new System.Drawing.Point(342, 25);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 29);
            this.Search_Button.TabIndex = 32;
            this.Search_Button.Text = "SEARCH";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 28);
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
            this.lb_List_Of_Items.Size = new System.Drawing.Size(170, 40);
            this.lb_List_Of_Items.TabIndex = 1;
            this.lb_List_Of_Items.Text = "LIST OF ITEMS";
            this.lb_List_Of_Items.UseCompatibleTextRendering = true;
            // 
            // List_Of_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 623);
            this.Controls.Add(this.panel1);
            this.Name = "List_Of_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Of_Items";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items_Room)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label lb_List_Of_Items;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Button Search_Button;
        private Label label2;
        private Button Logout_Button;
        private readonly DataGridViewCellEventHandler dgv_List_Of_Items_CellContentClick;
        private Label label3;
		private DataGridView dgv_List_Of_Items;
		private DataGridView dgv_List_Of_Items_Room;
		private Label label1;
		private ComboBox cb_RoomID;
	}
}