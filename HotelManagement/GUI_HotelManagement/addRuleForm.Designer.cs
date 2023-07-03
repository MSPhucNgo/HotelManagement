namespace GUI_HotelManagement
{
    partial class addRuleForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            ruleName_Text = new TextBox();
            Description_Text = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Type_ComboBox = new ComboBox();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 193, 138);
            button1.Location = new Point(182, 330);
            button1.Name = "button1";
            button1.Size = new Size(122, 44);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(239, 59, 44);
            button2.Location = new Point(635, 6);
            button2.Name = "button2";
            button2.Size = new Size(40, 36);
            button2.TabIndex = 2;
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
            button3.Location = new Point(390, 330);
            button3.Name = "button3";
            button3.Size = new Size(122, 44);
            button3.TabIndex = 3;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Type_ComboBox);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(Description_Text);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ruleName_Text);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 402);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 73);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Rule's name:";
            // 
            // ruleName_Text
            // 
            ruleName_Text.BorderStyle = BorderStyle.FixedSingle;
            ruleName_Text.Cursor = Cursors.IBeam;
            ruleName_Text.Location = new Point(133, 72);
            ruleName_Text.Name = "ruleName_Text";
            ruleName_Text.Size = new Size(499, 23);
            ruleName_Text.TabIndex = 1;
            // 
            // Description_Text
            // 
            Description_Text.BorderStyle = BorderStyle.FixedSingle;
            Description_Text.Cursor = Cursors.IBeam;
            Description_Text.Location = new Point(134, 126);
            Description_Text.Multiline = true;
            Description_Text.Name = "Description_Text";
            Description_Text.Size = new Size(498, 124);
            Description_Text.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 123);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 276);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Rule's type:";
            // 
            // Type_ComboBox
            // 
            Type_ComboBox.Cursor = Cursors.Hand;
            Type_ComboBox.FormattingEnabled = true;
            Type_ComboBox.Items.AddRange(new object[] { "Quy định chìa khóa", "Quy định khách sạn" });
            Type_ComboBox.Location = new Point(133, 276);
            Type_ComboBox.Name = "Type_ComboBox";
            Type_ComboBox.Size = new Size(499, 23);
            Type_ComboBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(8, 48, 107);
            label4.Location = new Point(285, 24);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 6;
            label4.Text = "CREATE RULE";
            // 
            // addRuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(700, 422);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addRuleForm";
            Padding = new Padding(10);
            Text = "Form5";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private ComboBox Type_ComboBox;
        private TextBox Description_Text;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox ruleName_Text;
        private Label label4;
    }
}