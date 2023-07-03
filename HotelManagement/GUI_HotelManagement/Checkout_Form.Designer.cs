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
            this.BookingId_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idBooking_Text = new System.Windows.Forms.TextBox();
            this.cusName_Text = new System.Windows.Forms.TextBox();
            this.roomFee_Text = new System.Windows.Forms.TextBox();
            this.serviceFee_Text = new System.Windows.Forms.TextBox();
            this.damageFee_Text = new System.Windows.Forms.TextBox();
            this.addDamage_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalFee_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Method_ComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listRoom_DataGrid = new System.Windows.Forms.DataGridView();
            this.listService_DataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.damage_DataGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listRoom_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listService_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damage_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BookingId_Label
            // 
            this.BookingId_Label.AutoSize = true;
            this.BookingId_Label.Location = new System.Drawing.Point(12, 33);
            this.BookingId_Label.Name = "BookingId_Label";
            this.BookingId_Label.Size = new System.Drawing.Size(81, 20);
            this.BookingId_Label.TabIndex = 0;
            this.BookingId_Label.Text = "Booking Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Damage fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Service fee";
            // 
            // idBooking_Text
            // 
            this.idBooking_Text.Enabled = false;
            this.idBooking_Text.Location = new System.Drawing.Point(131, 30);
            this.idBooking_Text.Name = "idBooking_Text";
            this.idBooking_Text.Size = new System.Drawing.Size(199, 27);
            this.idBooking_Text.TabIndex = 5;
            // 
            // cusName_Text
            // 
            this.cusName_Text.Location = new System.Drawing.Point(131, 75);
            this.cusName_Text.Name = "cusName_Text";
            this.cusName_Text.Size = new System.Drawing.Size(199, 27);
            this.cusName_Text.TabIndex = 6;
            // 
            // roomFee_Text
            // 
            this.roomFee_Text.Enabled = false;
            this.roomFee_Text.Location = new System.Drawing.Point(131, 112);
            this.roomFee_Text.Name = "roomFee_Text";
            this.roomFee_Text.Size = new System.Drawing.Size(94, 27);
            this.roomFee_Text.TabIndex = 7;
            // 
            // serviceFee_Text
            // 
            this.serviceFee_Text.Enabled = false;
            this.serviceFee_Text.Location = new System.Drawing.Point(131, 154);
            this.serviceFee_Text.Name = "serviceFee_Text";
            this.serviceFee_Text.Size = new System.Drawing.Size(94, 27);
            this.serviceFee_Text.TabIndex = 8;
            // 
            // damageFee_Text
            // 
            this.damageFee_Text.Enabled = false;
            this.damageFee_Text.Location = new System.Drawing.Point(131, 199);
            this.damageFee_Text.Name = "damageFee_Text";
            this.damageFee_Text.Size = new System.Drawing.Size(94, 27);
            this.damageFee_Text.TabIndex = 9;
            // 
            // addDamage_Button
            // 
            this.addDamage_Button.Enabled = false;
            this.addDamage_Button.Image = ((System.Drawing.Image)(resources.GetObject("addDamage_Button.Image")));
            this.addDamage_Button.Location = new System.Drawing.Point(231, 196);
            this.addDamage_Button.Name = "addDamage_Button";
            this.addDamage_Button.Size = new System.Drawing.Size(32, 32);
            this.addDamage_Button.TabIndex = 10;
            this.addDamage_Button.UseVisualStyleBackColor = true;
            this.addDamage_Button.Click += new System.EventHandler(this.addDamage_Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total fee";
            // 
            // totalFee_Text
            // 
            this.totalFee_Text.Enabled = false;
            this.totalFee_Text.Location = new System.Drawing.Point(131, 244);
            this.totalFee_Text.Name = "totalFee_Text";
            this.totalFee_Text.Size = new System.Drawing.Size(94, 27);
            this.totalFee_Text.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Payment method";
            // 
            // Method_ComboBox
            // 
            this.Method_ComboBox.FormattingEnabled = true;
            this.Method_ComboBox.Items.AddRange(new object[] {
            "None",
            "Cash",
            "Credit Card",
            "Traveller Cheque",
            "Travel agent account"});
            this.Method_ComboBox.Location = new System.Drawing.Point(131, 290);
            this.Method_ComboBox.Name = "Method_ComboBox";
            this.Method_ComboBox.Size = new System.Drawing.Size(94, 28);
            this.Method_ComboBox.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(881, 582);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "List rooms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(895, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "List service";
            // 
            // listRoom_DataGrid
            // 
            this.listRoom_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listRoom_DataGrid.Location = new System.Drawing.Point(436, 67);
            this.listRoom_DataGrid.Name = "listRoom_DataGrid";
            this.listRoom_DataGrid.RowHeadersWidth = 51;
            this.listRoom_DataGrid.RowTemplate.Height = 29;
            this.listRoom_DataGrid.Size = new System.Drawing.Size(298, 321);
            this.listRoom_DataGrid.TabIndex = 19;
            // 
            // listService_DataGrid
            // 
            this.listService_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listService_DataGrid.Location = new System.Drawing.Point(783, 67);
            this.listService_DataGrid.Name = "listService_DataGrid";
            this.listService_DataGrid.RowHeadersWidth = 51;
            this.listService_DataGrid.RowTemplate.Height = 29;
            this.listService_DataGrid.Size = new System.Drawing.Size(300, 321);
            this.listService_DataGrid.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // damage_DataGrid
            // 
            this.damage_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.damage_DataGrid.Location = new System.Drawing.Point(9, 408);
            this.damage_DataGrid.Name = "damage_DataGrid";
            this.damage_DataGrid.RowHeadersWidth = 51;
            this.damage_DataGrid.RowTemplate.Height = 29;
            this.damage_DataGrid.Size = new System.Drawing.Size(1074, 149);
            this.damage_DataGrid.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "List damaged item";
            // 
            // Checkout_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 623);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.damage_DataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listService_DataGrid);
            this.Controls.Add(this.listRoom_DataGrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Method_ComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalFee_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addDamage_Button);
            this.Controls.Add(this.damageFee_Text);
            this.Controls.Add(this.serviceFee_Text);
            this.Controls.Add(this.roomFee_Text);
            this.Controls.Add(this.cusName_Text);
            this.Controls.Add(this.idBooking_Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookingId_Label);
            this.Name = "Checkout_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout_Form";
            ((System.ComponentModel.ISupportInitialize)(this.listRoom_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listService_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damage_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button button2;
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
    }
}