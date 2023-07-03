namespace GUI_HotelManagement
{
    partial class Checkout_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout_Form));
            BookingId_Label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idBooking_Text = new TextBox();
            cusName_Text = new TextBox();
            roomFee_Text = new TextBox();
            serviceFee_Text = new TextBox();
            damageFee_Text = new TextBox();
            addDamage_Button = new Button();
            label5 = new Label();
            totalFee_Text = new TextBox();
            label6 = new Label();
            Method_ComboBox = new ComboBox();
            button3 = new Button();
            label7 = new Label();
            label8 = new Label();
            listRoom_DataGrid = new DataGridView();
            listService_DataGrid = new DataGridView();
            button1 = new Button();
            damage_DataGrid = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            depositPrice_Text = new TextBox();
            label11 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button4 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)listRoom_DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listService_DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)damage_DataGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BookingId_Label
            // 
            BookingId_Label.AutoSize = true;
            BookingId_Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BookingId_Label.Location = new Point(38, 28);
            BookingId_Label.Name = "BookingId_Label";
            BookingId_Label.Size = new Size(80, 19);
            BookingId_Label.TabIndex = 0;
            BookingId_Label.Text = "Booking ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 59);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 1;
            label1.Text = "Customer name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 90);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 2;
            label2.Text = "Room fee:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 186);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 3;
            label3.Text = "Damage fee:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 122);
            label4.Name = "label4";
            label4.Size = new Size(76, 19);
            label4.TabIndex = 4;
            label4.Text = "Service fee:";
            // 
            // idBooking_Text
            // 
            idBooking_Text.BorderStyle = BorderStyle.FixedSingle;
            idBooking_Text.Enabled = false;
            idBooking_Text.Location = new Point(163, 24);
            idBooking_Text.Margin = new Padding(3, 2, 3, 2);
            idBooking_Text.Name = "idBooking_Text";
            idBooking_Text.Size = new Size(256, 23);
            idBooking_Text.TabIndex = 5;
            // 
            // cusName_Text
            // 
            cusName_Text.BorderStyle = BorderStyle.FixedSingle;
            cusName_Text.Location = new Point(163, 55);
            cusName_Text.Margin = new Padding(3, 2, 3, 2);
            cusName_Text.Name = "cusName_Text";
            cusName_Text.Size = new Size(256, 23);
            cusName_Text.TabIndex = 6;
            // 
            // roomFee_Text
            // 
            roomFee_Text.BorderStyle = BorderStyle.FixedSingle;
            roomFee_Text.Enabled = false;
            roomFee_Text.Location = new Point(163, 86);
            roomFee_Text.Margin = new Padding(3, 2, 3, 2);
            roomFee_Text.Name = "roomFee_Text";
            roomFee_Text.Size = new Size(156, 23);
            roomFee_Text.TabIndex = 7;
            // 
            // serviceFee_Text
            // 
            serviceFee_Text.BorderStyle = BorderStyle.FixedSingle;
            serviceFee_Text.Enabled = false;
            serviceFee_Text.Location = new Point(163, 118);
            serviceFee_Text.Margin = new Padding(3, 2, 3, 2);
            serviceFee_Text.Name = "serviceFee_Text";
            serviceFee_Text.Size = new Size(156, 23);
            serviceFee_Text.TabIndex = 8;
            // 
            // damageFee_Text
            // 
            damageFee_Text.BorderStyle = BorderStyle.FixedSingle;
            damageFee_Text.Enabled = false;
            damageFee_Text.Location = new Point(163, 181);
            damageFee_Text.Margin = new Padding(3, 2, 3, 2);
            damageFee_Text.Name = "damageFee_Text";
            damageFee_Text.Size = new Size(156, 23);
            damageFee_Text.TabIndex = 9;
            // 
            // addDamage_Button
            // 
            addDamage_Button.BackColor = Color.White;
            addDamage_Button.Enabled = false;
            addDamage_Button.FlatAppearance.BorderSize = 0;
            addDamage_Button.FlatStyle = FlatStyle.Flat;
            addDamage_Button.Image = (Image)resources.GetObject("addDamage_Button.Image");
            addDamage_Button.Location = new Point(334, 179);
            addDamage_Button.Margin = new Padding(3, 2, 3, 2);
            addDamage_Button.Name = "addDamage_Button";
            addDamage_Button.Size = new Size(27, 26);
            addDamage_Button.TabIndex = 10;
            addDamage_Button.UseVisualStyleBackColor = false;
            addDamage_Button.Click += addDamage_Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 217);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 12;
            label5.Text = "Total fee:";
            // 
            // totalFee_Text
            // 
            totalFee_Text.BorderStyle = BorderStyle.FixedSingle;
            totalFee_Text.Enabled = false;
            totalFee_Text.Location = new Point(163, 213);
            totalFee_Text.Margin = new Padding(3, 2, 3, 2);
            totalFee_Text.Name = "totalFee_Text";
            totalFee_Text.Size = new Size(156, 23);
            totalFee_Text.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 249);
            label6.Name = "label6";
            label6.Size = new Size(118, 19);
            label6.TabIndex = 14;
            label6.Text = "Payment method:";
            // 
            // Method_ComboBox
            // 
            Method_ComboBox.FormattingEnabled = true;
            Method_ComboBox.Items.AddRange(new object[] { "None", "Cash", "Credit Card", "Traveller Cheque", "Travel agent account" });
            Method_ComboBox.Location = new Point(163, 245);
            Method_ComboBox.Margin = new Padding(3, 2, 3, 2);
            Method_ComboBox.Name = "Method_ComboBox";
            Method_ComboBox.Size = new Size(256, 23);
            Method_ComboBox.TabIndex = 15;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(8, 48, 107);
            button3.Location = new Point(393, 600);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(182, 50);
            button3.TabIndex = 16;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(8, 48, 107);
            label7.Location = new Point(655, 83);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 17;
            label7.Text = "List rooms:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(8, 48, 107);
            label8.Location = new Point(928, 83);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 18;
            label8.Text = "List services:";
            // 
            // listRoom_DataGrid
            // 
            listRoom_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listRoom_DataGrid.Location = new Point(655, 111);
            listRoom_DataGrid.Margin = new Padding(3, 2, 3, 2);
            listRoom_DataGrid.Name = "listRoom_DataGrid";
            listRoom_DataGrid.RowHeadersWidth = 51;
            listRoom_DataGrid.RowTemplate.Height = 29;
            listRoom_DataGrid.Size = new Size(235, 261);
            listRoom_DataGrid.TabIndex = 19;
            // 
            // listService_DataGrid
            // 
            listService_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listService_DataGrid.Location = new Point(928, 111);
            listService_DataGrid.Margin = new Padding(3, 2, 3, 2);
            listService_DataGrid.Name = "listService_DataGrid";
            listService_DataGrid.RowHeadersWidth = 51;
            listService_DataGrid.RowTemplate.Height = 29;
            listService_DataGrid.Size = new Size(236, 261);
            listService_DataGrid.TabIndex = 20;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 193, 138);
            button1.Location = new Point(651, 600);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(182, 50);
            button1.TabIndex = 21;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // damage_DataGrid
            // 
            damage_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            damage_DataGrid.Location = new Point(26, 420);
            damage_DataGrid.Margin = new Padding(3, 2, 3, 2);
            damage_DataGrid.Name = "damage_DataGrid";
            damage_DataGrid.RowHeadersWidth = 51;
            damage_DataGrid.RowTemplate.Height = 29;
            damage_DataGrid.Size = new Size(1138, 151);
            damage_DataGrid.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(8, 48, 107);
            label9.Location = new Point(26, 393);
            label9.Name = "label9";
            label9.Size = new Size(149, 21);
            label9.TabIndex = 23;
            label9.Text = "List damaged item:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(37, 154);
            label10.Name = "label10";
            label10.Size = new Size(81, 19);
            label10.TabIndex = 24;
            label10.Text = "Deposit fee:";
            // 
            // depositPrice_Text
            // 
            depositPrice_Text.BorderStyle = BorderStyle.FixedSingle;
            depositPrice_Text.Enabled = false;
            depositPrice_Text.Location = new Point(163, 150);
            depositPrice_Text.Margin = new Padding(3, 2, 3, 2);
            depositPrice_Text.Name = "depositPrice_Text";
            depositPrice_Text.ReadOnly = true;
            depositPrice_Text.Size = new Size(156, 23);
            depositPrice_Text.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ControlLightLight;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(8, 48, 107);
            label11.Location = new Point(435, 24);
            label11.Name = "label11";
            label11.Size = new Size(285, 30);
            label11.TabIndex = 91;
            label11.Text = "CHECK-OUT INFOMATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(listRoom_DataGrid);
            panel1.Controls.Add(listService_DataGrid);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(damage_DataGrid);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 680);
            panel1.TabIndex = 92;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 242);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(cusName_Text);
            panel2.Controls.Add(roomFee_Text);
            panel2.Controls.Add(serviceFee_Text);
            panel2.Controls.Add(idBooking_Text);
            panel2.Controls.Add(depositPrice_Text);
            panel2.Controls.Add(damageFee_Text);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(addDamage_Button);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Method_ComboBox);
            panel2.Controls.Add(BookingId_Label);
            panel2.Controls.Add(totalFee_Text);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(26, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 289);
            panel2.TabIndex = 92;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(8, 48, 107);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(436, 55);
            button4.Name = "button4";
            button4.Size = new Size(88, 25);
            button4.TabIndex = 93;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(239, 59, 44);
            button2.Location = new Point(1146, 3);
            button2.Name = "button2";
            button2.Size = new Size(40, 36);
            button2.TabIndex = 94;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Checkout_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(1209, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Checkout_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout_Form";
            ((System.ComponentModel.ISupportInitialize)listRoom_DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)listService_DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)damage_DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label BookingId_Label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idBooking_Text;
        private TextBox cusName_Text;
        private TextBox roomFee_Text;
        private TextBox serviceFee_Text;
        private TextBox damageFee_Text;
        private Button addDamage_Button;
        private Label label5;
        private TextBox totalFee_Text;
        private Label label6;
        private ComboBox Method_ComboBox;
        private Button button3;
        private Label label7;
        private Label label8;
        private DataGridView listRoom_DataGrid;
        private DataGridView listService_DataGrid;
        private Button button1;
        private DataGridView damage_DataGrid;
        private Label label9;
        private Label label10;
        private TextBox depositPrice_Text;
        private Label label11;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button button2;
    }
}