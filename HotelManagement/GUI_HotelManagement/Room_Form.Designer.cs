namespace GUI_HotelManagement
{
    partial class Room_Form
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
            ListRoom_FlowLayout = new FlowLayoutPanel();
            Filter_ComboBox = new ComboBox();
            Status_ComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Type_ComboBox = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ListRoom_FlowLayout
            // 
            ListRoom_FlowLayout.AutoScroll = true;
            ListRoom_FlowLayout.BackColor = Color.White;
            ListRoom_FlowLayout.Location = new Point(44, 164);
            ListRoom_FlowLayout.Margin = new Padding(3, 2, 3, 2);
            ListRoom_FlowLayout.Name = "ListRoom_FlowLayout";
            ListRoom_FlowLayout.Size = new Size(1036, 446);
            ListRoom_FlowLayout.TabIndex = 1;
            // 
            // Filter_ComboBox
            // 
            Filter_ComboBox.FormattingEnabled = true;
            Filter_ComboBox.Items.AddRange(new object[] { "All", "Status", "Type" });
            Filter_ComboBox.Location = new Point(75, 29);
            Filter_ComboBox.Margin = new Padding(3, 2, 3, 2);
            Filter_ComboBox.Name = "Filter_ComboBox";
            Filter_ComboBox.Size = new Size(383, 23);
            Filter_ComboBox.TabIndex = 2;
            Filter_ComboBox.Text = "All";
            Filter_ComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Status_ComboBox
            // 
            Status_ComboBox.FormattingEnabled = true;
            Status_ComboBox.Items.AddRange(new object[] { "All", "Trống", "Được đặt trước", "Đang sử dụng" });
            Status_ComboBox.Location = new Point(581, 28);
            Status_ComboBox.Name = "Status_ComboBox";
            Status_ComboBox.Size = new Size(154, 23);
            Status_ComboBox.TabIndex = 3;
            Status_ComboBox.Text = "All";
            Status_ComboBox.SelectedIndexChanged += Status_ComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(212, 230, 242);
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(523, 31);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(212, 230, 242);
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 31);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "Filter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(212, 230, 242);
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(795, 31);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Type:";
            // 
            // Type_ComboBox
            // 
            Type_ComboBox.FormattingEnabled = true;
            Type_ComboBox.Items.AddRange(new object[] { "All", "Phòng 2 ng", "Phòng 4 ng", "Phòng 8 ng", "Phòng vip " });
            Type_ComboBox.Location = new Point(844, 28);
            Type_ComboBox.Name = "Type_ComboBox";
            Type_ComboBox.Size = new Size(150, 23);
            Type_ComboBox.TabIndex = 7;
            Type_ComboBox.Text = "All";
            Type_ComboBox.SelectedIndexChanged += Type_ComboBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 660);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(8, 48, 107);
            label4.Location = new Point(495, 119);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 18;
            label4.Text = "List of Rooms";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(212, 230, 242);
            panel2.Controls.Add(Filter_ComboBox);
            panel2.Controls.Add(Type_ComboBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Status_ComboBox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(44, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 85);
            panel2.TabIndex = 19;
            // 
            // Room_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 670);
            Controls.Add(ListRoom_FlowLayout);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Room_Form";
            Padding = new Padding(0, 0, 10, 10);
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel ListRoom_FlowLayout;
        private ComboBox Filter_ComboBox;
        private ComboBox Status_ComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox Type_ComboBox;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
    }
}