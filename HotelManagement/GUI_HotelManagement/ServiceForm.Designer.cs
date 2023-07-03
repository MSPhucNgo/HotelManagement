namespace GUI_HotelManagement
{
    partial class ServiceForm
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
            Service_ComboBox = new ComboBox();
            Service_DataGrid = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            Disable_Button = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            Floor_ComboBox = new ComboBox();
            Room_ComboBox = new ComboBox();
            label2 = new Label();
            ServiceForRoom_DataGrid = new DataGridView();
            button5 = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            UD_Panel = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            UDService_ComboBox = new ComboBox();
            Discount_DataGid = new DataGridView();
            Infor_Label = new Label();
            label6 = new Label();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Service_DataGrid).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceForRoom_DataGrid).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            UD_Panel.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Discount_DataGid).BeginInit();
            SuspendLayout();
            // 
            // Service_ComboBox
            // 
            Service_ComboBox.FormattingEnabled = true;
            Service_ComboBox.Items.AddRange(new object[] { "Dịch vụ khách sạn", "Dịch vụ du lịch" });
            Service_ComboBox.Location = new Point(149, 42);
            Service_ComboBox.Name = "Service_ComboBox";
            Service_ComboBox.Size = new Size(465, 23);
            Service_ComboBox.TabIndex = 0;
            Service_ComboBox.SelectedIndexChanged += Service_ComboBox_SelectedIndexChanged;
            // 
            // Service_DataGrid
            // 
            Service_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Service_DataGrid.Location = new Point(27, 84);
            Service_DataGrid.Name = "Service_DataGrid";
            Service_DataGrid.ReadOnly = true;
            Service_DataGrid.RowHeadersWidth = 51;
            Service_DataGrid.RowTemplate.Height = 24;
            Service_DataGrid.Size = new Size(587, 292);
            Service_DataGrid.TabIndex = 1;
            Service_DataGrid.CellContentClick += Service_DataGrid_CellContentClick;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 193, 138);
            button1.Location = new Point(45, 27);
            button1.Name = "button1";
            button1.Size = new Size(166, 39);
            button1.TabIndex = 2;
            button1.Text = "Add Service";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 193, 138);
            button2.Location = new Point(52, 126);
            button2.Name = "button2";
            button2.Size = new Size(159, 38);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Disable_Button
            // 
            Disable_Button.FlatAppearance.BorderSize = 2;
            Disable_Button.FlatStyle = FlatStyle.Flat;
            Disable_Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Disable_Button.ForeColor = Color.FromArgb(239, 59, 44);
            Disable_Button.Location = new Point(242, 126);
            Disable_Button.Name = "Disable_Button";
            Disable_Button.Size = new Size(172, 38);
            Disable_Button.TabIndex = 4;
            Disable_Button.Text = "Disable";
            Disable_Button.UseVisualStyleBackColor = true;
            Disable_Button.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 48, 107);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(646, -1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 10);
            panel1.Size = new Size(490, 364);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Floor_ComboBox);
            panel3.Controls.Add(Room_ComboBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(ServiceForRoom_DataGrid);
            panel3.Controls.Add(button5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 354);
            panel3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 110);
            label4.Name = "label4";
            label4.Size = new Size(206, 20);
            label4.TabIndex = 15;
            label4.Text = "List services of selected room:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 40);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 14;
            label3.Text = "Floor:";
            // 
            // Floor_ComboBox
            // 
            Floor_ComboBox.FormattingEnabled = true;
            Floor_ComboBox.Location = new Point(98, 37);
            Floor_ComboBox.Margin = new Padding(3, 2, 3, 2);
            Floor_ComboBox.Name = "Floor_ComboBox";
            Floor_ComboBox.Size = new Size(200, 23);
            Floor_ComboBox.TabIndex = 13;
            Floor_ComboBox.SelectedIndexChanged += Floor_ComboBox_SelectedIndexChanged;
            // 
            // Room_ComboBox
            // 
            Room_ComboBox.FormattingEnabled = true;
            Room_ComboBox.Location = new Point(98, 63);
            Room_ComboBox.Name = "Room_ComboBox";
            Room_ComboBox.Size = new Size(200, 23);
            Room_ComboBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 65);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Room:";
            // 
            // ServiceForRoom_DataGrid
            // 
            ServiceForRoom_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceForRoom_DataGrid.Location = new Point(45, 137);
            ServiceForRoom_DataGrid.Name = "ServiceForRoom_DataGrid";
            ServiceForRoom_DataGrid.ReadOnly = true;
            ServiceForRoom_DataGrid.RowHeadersWidth = 51;
            ServiceForRoom_DataGrid.RowTemplate.Height = 24;
            ServiceForRoom_DataGrid.Size = new Size(374, 174);
            ServiceForRoom_DataGrid.TabIndex = 2;
            ServiceForRoom_DataGrid.CellContentClick += ServiceForRoom_DataGrid_CellContentClick;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 193, 138);
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 193, 138);
            button5.Location = new Point(325, 37);
            button5.Name = "button5";
            button5.Size = new Size(94, 51);
            button5.TabIndex = 4;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(8, 48, 107);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(646, 363);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 10, 0);
            panel2.Size = new Size(490, 100);
            panel2.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(470, 100);
            panel4.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(8, 48, 107);
            button4.Location = new Point(242, 27);
            button4.Name = "button4";
            button4.Size = new Size(172, 39);
            button4.TabIndex = 3;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UD_Panel
            // 
            UD_Panel.BackColor = Color.FromArgb(8, 48, 107);
            UD_Panel.Controls.Add(panel5);
            UD_Panel.Location = new Point(646, 455);
            UD_Panel.Name = "UD_Panel";
            UD_Panel.Padding = new Padding(10);
            UD_Panel.Size = new Size(490, 216);
            UD_Panel.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(Disable_Button);
            panel5.Controls.Add(UDService_ComboBox);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(10, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(470, 196);
            panel5.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 34);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 6;
            label1.Text = "Service's name:";
            // 
            // UDService_ComboBox
            // 
            UDService_ComboBox.FormattingEnabled = true;
            UDService_ComboBox.Items.AddRange(new object[] { "ứgsgd" });
            UDService_ComboBox.Location = new Point(52, 71);
            UDService_ComboBox.Name = "UDService_ComboBox";
            UDService_ComboBox.Size = new Size(362, 23);
            UDService_ComboBox.TabIndex = 5;
            // 
            // Discount_DataGid
            // 
            Discount_DataGid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Discount_DataGid.Location = new Point(27, 441);
            Discount_DataGid.Name = "Discount_DataGid";
            Discount_DataGid.RowHeadersWidth = 51;
            Discount_DataGid.RowTemplate.Height = 24;
            Discount_DataGid.Size = new Size(587, 143);
            Discount_DataGid.TabIndex = 10;
            // 
            // Infor_Label
            // 
            Infor_Label.AutoSize = true;
            Infor_Label.BackColor = SystemColors.Window;
            Infor_Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Infor_Label.Location = new Point(27, 410);
            Infor_Label.Name = "Infor_Label";
            Infor_Label.Size = new Size(292, 20);
            Infor_Label.TabIndex = 16;
            Infor_Label.Text = "List discount promotions of selected room:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Window;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 45);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 17;
            label6.Text = "Types of service:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(8, 48, 107);
            panel6.Location = new Point(-3, 661);
            panel6.Name = "panel6";
            panel6.Size = new Size(653, 10);
            panel6.TabIndex = 18;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1135, 670);
            Controls.Add(panel6);
            Controls.Add(label6);
            Controls.Add(Infor_Label);
            Controls.Add(Discount_DataGid);
            Controls.Add(UD_Panel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Service_DataGrid);
            Controls.Add(Service_ComboBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServiceForm";
            Text = "Dịch vụ khách sạn";
            ((System.ComponentModel.ISupportInitialize)Service_DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceForRoom_DataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            UD_Panel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Discount_DataGid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Service_ComboBox;
        private DataGridView Service_DataGrid;
        private Button button1;
        private Button button2;
        private Button Disable_Button;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Panel UD_Panel;
        private ComboBox comboBox2;
        private Button button5;
        private DataGridView ServiceForRoom_DataGrid;
        private Label label2;
        private ComboBox Room_ComboBox;
        private DataGridView Discount_DataGid;
        private ComboBox Floor_ComboBox;
        private ComboBox UDService_ComboBox;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label Infor_Label;
        private Label label6;
        private Panel panel6;
    }
}