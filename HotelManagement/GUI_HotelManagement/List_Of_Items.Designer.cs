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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.bt_Logout = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dgv_List_Of_Items = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.BookID_Text = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lb_List_Of_Items = new System.Windows.Forms.Label();
			this.dgv_List_Of_Items_Room = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lb_List_Of_Items_Room = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items_Room)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.lb_List_Of_Items);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1093, 599);
			this.panel1.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Silver;
			this.panel3.Controls.Add(this.bt_Logout);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Location = new System.Drawing.Point(0, 39);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1093, 560);
			this.panel3.TabIndex = 2;
			// 
			// bt_Logout
			// 
			this.bt_Logout.Location = new System.Drawing.Point(849, 527);
			this.bt_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bt_Logout.Name = "bt_Logout";
			this.bt_Logout.Size = new System.Drawing.Size(75, 29);
			this.bt_Logout.TabIndex = 33;
			this.bt_Logout.Text = "EXIT";
			this.bt_Logout.UseVisualStyleBackColor = true;
			this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.LightGray;
			this.panel5.Controls.Add(this.lb_List_Of_Items_Room);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.dgv_List_Of_Items_Room);
			this.panel5.Controls.Add(this.dgv_List_Of_Items);
			this.panel5.ForeColor = System.Drawing.Color.Silver;
			this.panel5.Location = new System.Drawing.Point(18, 98);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1041, 422);
			this.panel5.TabIndex = 1;
			// 
			// dgv_List_Of_Items
			// 
			this.dgv_List_Of_Items.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dgv_List_Of_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_List_Of_Items.Location = new System.Drawing.Point(487, 105);
			this.dgv_List_Of_Items.Name = "dgv_List_Of_Items";
			this.dgv_List_Of_Items.RowHeadersWidth = 51;
			this.dgv_List_Of_Items.RowTemplate.Height = 29;
			this.dgv_List_Of_Items.Size = new System.Drawing.Size(551, 314);
			this.dgv_List_Of_Items.TabIndex = 5;
			this.dgv_List_Of_Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_List_Of_Items_CellContentClick_1);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkGray;
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.BookID_Text);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Location = new System.Drawing.Point(19, 21);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1040, 71);
			this.panel4.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(369, 24);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 29);
			this.button2.TabIndex = 32;
			this.button2.Text = "SEARCH";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// BookID_Text
			// 
			this.BookID_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BookID_Text.Location = new System.Drawing.Point(128, 25);
			this.BookID_Text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BookID_Text.Name = "BookID_Text";
			this.BookID_Text.Size = new System.Drawing.Size(201, 27);
			this.BookID_Text.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 28);
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
			this.lb_List_Of_Items.Click += new System.EventHandler(this.lb_List_Of_Items_Click);
			// 
			// dgv_List_Of_Items_Room
			// 
			this.dgv_List_Of_Items_Room.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dgv_List_Of_Items_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_List_Of_Items_Room.Location = new System.Drawing.Point(3, 105);
			this.dgv_List_Of_Items_Room.Name = "dgv_List_Of_Items_Room";
			this.dgv_List_Of_Items_Room.RowHeadersWidth = 51;
			this.dgv_List_Of_Items_Room.RowTemplate.Height = 29;
			this.dgv_List_Of_Items_Room.Size = new System.Drawing.Size(442, 314);
			this.dgv_List_Of_Items_Room.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(695, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 33);
			this.label1.TabIndex = 7;
			this.label1.Text = "LIST OF ITEMS";
			this.label1.UseCompatibleTextRendering = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(125, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(205, 33);
			this.label3.TabIndex = 8;
			this.label3.Text = "LIST OF ITEMS ROOM";
			this.label3.UseCompatibleTextRendering = true;
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
			this.lb_List_Of_Items_Room.Size = new System.Drawing.Size(160, 40);
			this.lb_List_Of_Items_Room.TabIndex = 9;
			this.lb_List_Of_Items_Room.Text = "LIST OF ITEMS";
			this.lb_List_Of_Items_Room.UseCompatibleTextRendering = true;
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
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items_Room)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label lb_List_Of_Items;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dgv_List_Of_Items;
        private Button button2;
        private TextBox BookID_Text;
        private Label label2;
        private Button bt_Logout;
        private readonly DataGridViewCellEventHandler dgv_List_Of_Items_CellContentClick;
        private Label lb_List_Of_Items_Room;
        private Label label3;
        private Label label1;
        private DataGridView dgv_List_Of_Items_Room;
    }
}