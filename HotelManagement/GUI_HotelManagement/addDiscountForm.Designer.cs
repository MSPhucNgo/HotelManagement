namespace GUI_HotelManagement
{
    partial class addDiscountForm
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
            label1 = new Label();
            nameDiscount_Text = new TextBox();
            Start_Date = new DateTimePicker();
            End_Date = new DateTimePicker();
            Descript_Text = new TextBox();
            label6 = new Label();
            Type_CheckList = new CheckedListBox();
            label5 = new Label();
            PercentDiscount_Text = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            AmountRequiment_Text = new TextBox();
            label7 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 70);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "Promotion's name:";
            // 
            // nameDiscount_Text
            // 
            nameDiscount_Text.BorderStyle = BorderStyle.FixedSingle;
            nameDiscount_Text.Location = new Point(183, 67);
            nameDiscount_Text.Name = "nameDiscount_Text";
            nameDiscount_Text.Size = new Size(507, 23);
            nameDiscount_Text.TabIndex = 5;
            // 
            // Start_Date
            // 
            Start_Date.Location = new Point(183, 114);
            Start_Date.Name = "Start_Date";
            Start_Date.Size = new Size(226, 23);
            Start_Date.TabIndex = 6;
            // 
            // End_Date
            // 
            End_Date.Location = new Point(183, 148);
            End_Date.Name = "End_Date";
            End_Date.Size = new Size(226, 23);
            End_Date.TabIndex = 7;
            // 
            // Descript_Text
            // 
            Descript_Text.BorderStyle = BorderStyle.FixedSingle;
            Descript_Text.Location = new Point(183, 192);
            Descript_Text.Multiline = true;
            Descript_Text.Name = "Descript_Text";
            Descript_Text.Size = new Size(507, 81);
            Descript_Text.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 294);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 12;
            label6.Text = "Type discount:";
            // 
            // Type_CheckList
            // 
            Type_CheckList.BorderStyle = BorderStyle.None;
            Type_CheckList.FormattingEnabled = true;
            Type_CheckList.Items.AddRange(new object[] { "Giảm giá", "Miễn phí một sản phẩm", "Miễn phí toàn phần" });
            Type_CheckList.Location = new Point(183, 294);
            Type_CheckList.Name = "Type_CheckList";
            Type_CheckList.Size = new Size(507, 36);
            Type_CheckList.TabIndex = 13;
            Type_CheckList.SelectedIndexChanged += Type_CheckList_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 359);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 14;
            label5.Text = "Percent discoount:";
            // 
            // PercentDiscount_Text
            // 
            PercentDiscount_Text.BorderStyle = BorderStyle.FixedSingle;
            PercentDiscount_Text.Enabled = false;
            PercentDiscount_Text.Location = new Point(183, 356);
            PercentDiscount_Text.Name = "PercentDiscount_Text";
            PercentDiscount_Text.Size = new Size(158, 23);
            PercentDiscount_Text.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(AmountRequiment_Text);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(PercentDiscount_Text);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Type_CheckList);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Descript_Text);
            panel2.Controls.Add(End_Date);
            panel2.Controls.Add(Start_Date);
            panel2.Controls.Add(nameDiscount_Text);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 486);
            panel2.TabIndex = 19;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(8, 48, 107);
            button1.Location = new Point(410, 411);
            button1.Name = "button1";
            button1.Size = new Size(147, 44);
            button1.TabIndex = 25;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 193, 138);
            button5.Location = new Point(220, 411);
            button5.Name = "button5";
            button5.Size = new Size(149, 44);
            button5.TabIndex = 24;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(239, 59, 44);
            button4.Location = new Point(709, 3);
            button4.Name = "button4";
            button4.Size = new Size(40, 36);
            button4.TabIndex = 23;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 190);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 22;
            label4.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 148);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 21;
            label3.Text = "Finish date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 114);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 20;
            label2.Text = "Start date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLightLight;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(8, 48, 107);
            label8.Location = new Point(241, 21);
            label8.Name = "label8";
            label8.Size = new Size(301, 25);
            label8.TabIndex = 19;
            label8.Text = "CREATE DISCOUNT PROMOTION";
            // 
            // AmountRequiment_Text
            // 
            AmountRequiment_Text.BorderStyle = BorderStyle.FixedSingle;
            AmountRequiment_Text.Enabled = false;
            AmountRequiment_Text.Location = new Point(517, 356);
            AmountRequiment_Text.Name = "AmountRequiment_Text";
            AmountRequiment_Text.Size = new Size(173, 23);
            AmountRequiment_Text.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(385, 359);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 16;
            label7.Text = "Amount require:";
            // 
            // addDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(772, 506);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addDiscountForm";
            Padding = new Padding(10);
            Text = "Thêm chương trình khuyến mãi";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox nameDiscount_Text;
        private DateTimePicker Start_Date;
        private DateTimePicker End_Date;
        private TextBox Descript_Text;
        private Label label6;
        private CheckedListBox Type_CheckList;
        private Label label5;
        private TextBox PercentDiscount_Text;
        private Panel panel2;
        private TextBox AmountRequiment_Text;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Button button4;
        private Button button1;
        private Button button5;
    }
}