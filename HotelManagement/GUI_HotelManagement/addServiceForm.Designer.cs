namespace GUI_HotelManagement
{
    partial class addServiceForm
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
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            label6 = new Label();
            label5 = new Label();
            Price_Text = new TextBox();
            Name_Text = new TextBox();
            label4 = new Label();
            label1 = new Label();
            Unit_ComboBox = new ComboBox();
            Descript_Text = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Price_Text);
            panel2.Controls.Add(Name_Text);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Unit_ComboBox);
            panel2.Controls.Add(Descript_Text);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 402);
            panel2.TabIndex = 8;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(239, 59, 44);
            button2.Location = new Point(637, 3);
            button2.Name = "button2";
            button2.Size = new Size(40, 36);
            button2.TabIndex = 12;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(8, 48, 107);
            button3.Location = new Point(369, 333);
            button3.Name = "button3";
            button3.Size = new Size(122, 44);
            button3.TabIndex = 11;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 193, 138);
            button5.Location = new Point(189, 333);
            button5.Name = "button5";
            button5.Size = new Size(122, 44);
            button5.TabIndex = 10;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(100, 279);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 9;
            label6.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(8, 48, 107);
            label5.Location = new Point(263, 18);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 8;
            label5.Text = "CREATE SERVICE";
            // 
            // Price_Text
            // 
            Price_Text.BorderStyle = BorderStyle.FixedSingle;
            Price_Text.Location = new Point(150, 280);
            Price_Text.Name = "Price_Text";
            Price_Text.Size = new Size(161, 23);
            Price_Text.TabIndex = 7;
            // 
            // Name_Text
            // 
            Name_Text.BorderStyle = BorderStyle.FixedSingle;
            Name_Text.Location = new Point(150, 62);
            Name_Text.Name = "Name_Text";
            Name_Text.Size = new Size(453, 23);
            Name_Text.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 280);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 65);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Service's name:";
            // 
            // Unit_ComboBox
            // 
            Unit_ComboBox.FormattingEnabled = true;
            Unit_ComboBox.Items.AddRange(new object[] { "Hour", "Minute", "Day" });
            Unit_ComboBox.Location = new Point(434, 281);
            Unit_ComboBox.Name = "Unit_ComboBox";
            Unit_ComboBox.Size = new Size(169, 23);
            Unit_ComboBox.TabIndex = 5;
            // 
            // Descript_Text
            // 
            Descript_Text.BorderStyle = BorderStyle.FixedSingle;
            Descript_Text.Location = new Point(150, 104);
            Descript_Text.Multiline = true;
            Descript_Text.Name = "Descript_Text";
            Descript_Text.Size = new Size(453, 156);
            Descript_Text.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(389, 280);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 104);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // addServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(700, 422);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addServiceForm";
            Padding = new Padding(10);
            Text = "Form7";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Panel panel2;
        private TextBox Price_Text;
        private TextBox Name_Text;
        private Label label4;
        private Label label1;
        private ComboBox Unit_ComboBox;
        private TextBox Descript_Text;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button5;
        private Button button2;
    }
}