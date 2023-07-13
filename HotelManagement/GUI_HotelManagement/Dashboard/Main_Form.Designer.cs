namespace GUI_HotelManagement.Dashboard
{
    partial class Main_Form
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
            panel1 = new Panel();
            Amount_room_Label = new Label();
            label1 = new Label();
            panel2 = new Panel();
            Amount_Emp_Label = new Label();
            label2 = new Label();
            panel3 = new Panel();
            Amount_Service_Label = new Label();
            label3 = new Label();
            Room_Panel = new Panel();
            Line_Room_Label = new Label();
            panel5 = new Panel();
            Line_Emp_Label = new Label();
            panel6 = new Panel();
            Line_Service_Label = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            Room_Panel.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(195, 225, 246);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Amount_room_Label);
            panel1.Location = new Point(77, 368);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 99);
            panel1.TabIndex = 2;
            // 
            // Amount_room_Label
            // 
            Amount_room_Label.AutoSize = true;
            Amount_room_Label.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Amount_room_Label.ForeColor = Color.FromArgb(34, 83, 169);
            Amount_room_Label.Location = new Point(144, 27);
            Amount_room_Label.Name = "Amount_room_Label";
            Amount_room_Label.Size = new Size(84, 65);
            Amount_room_Label.TabIndex = 1;
            Amount_room_Label.Text = "10";
            Amount_room_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(34, 83, 169);
            label1.Location = new Point(135, 12);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 0;
            label1.Text = "Số lượng phòng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(252, 229, 158);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Amount_Emp_Label);
            panel2.Location = new Point(457, 372);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 99);
            panel2.TabIndex = 3;
            // 
            // Amount_Emp_Label
            // 
            Amount_Emp_Label.AutoSize = true;
            Amount_Emp_Label.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Amount_Emp_Label.ForeColor = Color.FromArgb(69, 56, 33);
            Amount_Emp_Label.Location = new Point(136, 23);
            Amount_Emp_Label.Name = "Amount_Emp_Label";
            Amount_Emp_Label.Size = new Size(84, 65);
            Amount_Emp_Label.TabIndex = 2;
            Amount_Emp_Label.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(69, 56, 33);
            label2.Location = new Point(115, 8);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 0;
            label2.Text = "Số lượng nhân viên";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(214, 237, 187);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Amount_Service_Label);
            panel3.Location = new Point(820, 372);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 99);
            panel3.TabIndex = 4;
            // 
            // Amount_Service_Label
            // 
            Amount_Service_Label.AutoSize = true;
            Amount_Service_Label.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Amount_Service_Label.ForeColor = Color.FromArgb(41, 115, 74);
            Amount_Service_Label.Location = new Point(142, 23);
            Amount_Service_Label.Name = "Amount_Service_Label";
            Amount_Service_Label.Size = new Size(84, 65);
            Amount_Service_Label.TabIndex = 3;
            Amount_Service_Label.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(41, 115, 74);
            label3.Location = new Point(129, 8);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 1;
            label3.Text = "Số lượng dịch vụ";
            // 
            // Room_Panel
            // 
            Room_Panel.BackColor = Color.FromArgb(195, 225, 246);
            Room_Panel.Controls.Add(Line_Room_Label);
            Room_Panel.Location = new Point(79, 489);
            Room_Panel.Margin = new Padding(3, 2, 3, 2);
            Room_Panel.Name = "Room_Panel";
            Room_Panel.Size = new Size(252, 140);
            Room_Panel.TabIndex = 5;
            // 
            // Line_Room_Label
            // 
            Line_Room_Label.AutoSize = true;
            Line_Room_Label.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            Line_Room_Label.ForeColor = Color.FromArgb(34, 83, 169);
            Line_Room_Label.Location = new Point(3, 2);
            Line_Room_Label.Name = "Line_Room_Label";
            Line_Room_Label.Size = new Size(117, 31);
            Line_Room_Label.TabIndex = 0;
            Line_Room_Label.Text = "RoomInfo";
            Line_Room_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(252, 229, 158);
            panel5.Controls.Add(Line_Emp_Label);
            panel5.Location = new Point(454, 489);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 140);
            panel5.TabIndex = 6;
            // 
            // Line_Emp_Label
            // 
            Line_Emp_Label.AutoSize = true;
            Line_Emp_Label.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            Line_Emp_Label.ForeColor = Color.FromArgb(69, 56, 33);
            Line_Emp_Label.Location = new Point(3, 2);
            Line_Emp_Label.Name = "Line_Emp_Label";
            Line_Emp_Label.Size = new Size(102, 31);
            Line_Emp_Label.TabIndex = 1;
            Line_Emp_Label.Text = "EmpInfo";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(214, 237, 187);
            panel6.Controls.Add(Line_Service_Label);
            panel6.Location = new Point(820, 489);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(247, 140);
            panel6.TabIndex = 7;
            // 
            // Line_Service_Label
            // 
            Line_Service_Label.AutoSize = true;
            Line_Service_Label.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            Line_Service_Label.ForeColor = Color.FromArgb(41, 115, 74);
            Line_Service_Label.Location = new Point(2, 2);
            Line_Service_Label.Name = "Line_Service_Label";
            Line_Service_Label.Size = new Size(132, 31);
            Line_Service_Label.TabIndex = 8;
            Line_Service_Label.Text = "ServiceInfo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Asset_1_png__blue_;
            pictureBox1.Location = new Point(317, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(Room_Panel);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1125, 660);
            panel4.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.team;
            pictureBox2.Location = new Point(15, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.room_service;
            pictureBox3.Location = new Point(19, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.living_room;
            pictureBox4.Location = new Point(24, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(94, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 670);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_Form";
            Padding = new Padding(0, 0, 10, 10);
            Text = "Main_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Room_Panel.ResumeLayout(false);
            Room_Panel.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label Amount_room_Label;
        private Label label1;
        private Panel panel2;
        private Label Amount_Emp_Label;
        private Label label2;
        private Panel panel3;
        private Label Amount_Service_Label;
        private Label label3;
        private Panel Room_Panel;
        private Panel panel5;
        private Panel panel6;
        private Label Line_Room_Label;
        private Label Line_Emp_Label;
        private Label Line_Service_Label;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}