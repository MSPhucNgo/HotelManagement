namespace GUI_HotelManagement.Check_out
{
    partial class Feedback
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
            feedback_Text = new TextBox();
            Star1st = new PictureBox();
            Star2nd = new PictureBox();
            Star3rd = new PictureBox();
            Star4th = new PictureBox();
            Star5th = new PictureBox();
            rating_Label = new Label();
            rate_Label = new Label();
            panel1 = new Panel();
            button2 = new Button();
            label11 = new Label();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)Star1st).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Star2nd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Star3rd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Star4th).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Star5th).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // feedback_Text
            // 
            feedback_Text.BackColor = Color.White;
            feedback_Text.BorderStyle = BorderStyle.FixedSingle;
            feedback_Text.Cursor = Cursors.IBeam;
            feedback_Text.Location = new Point(56, 104);
            feedback_Text.Margin = new Padding(3, 2, 3, 2);
            feedback_Text.Multiline = true;
            feedback_Text.Name = "feedback_Text";
            feedback_Text.Size = new Size(640, 218);
            feedback_Text.TabIndex = 0;
            // 
            // Star1st
            // 
            Star1st.Cursor = Cursors.Hand;
            Star1st.Image = Properties.Resources.Star_Dark;
            Star1st.Location = new Point(57, 339);
            Star1st.Margin = new Padding(3, 2, 3, 2);
            Star1st.Name = "Star1st";
            Star1st.Size = new Size(63, 59);
            Star1st.TabIndex = 1;
            Star1st.TabStop = false;
            Star1st.Click += pictureBox1_Click;
            // 
            // Star2nd
            // 
            Star2nd.Cursor = Cursors.Hand;
            Star2nd.Image = Properties.Resources.Star_Dark;
            Star2nd.Location = new Point(120, 339);
            Star2nd.Margin = new Padding(3, 2, 3, 2);
            Star2nd.Name = "Star2nd";
            Star2nd.Size = new Size(63, 59);
            Star2nd.TabIndex = 2;
            Star2nd.TabStop = false;
            Star2nd.Click += Star2nd_Click;
            // 
            // Star3rd
            // 
            Star3rd.Cursor = Cursors.Hand;
            Star3rd.Image = Properties.Resources.Star_Dark;
            Star3rd.Location = new Point(183, 339);
            Star3rd.Margin = new Padding(3, 2, 3, 2);
            Star3rd.Name = "Star3rd";
            Star3rd.Size = new Size(61, 59);
            Star3rd.TabIndex = 3;
            Star3rd.TabStop = false;
            Star3rd.Click += Star3rd_Click;
            // 
            // Star4th
            // 
            Star4th.Cursor = Cursors.Hand;
            Star4th.Image = Properties.Resources.Star_Dark;
            Star4th.Location = new Point(244, 339);
            Star4th.Margin = new Padding(3, 2, 3, 2);
            Star4th.Name = "Star4th";
            Star4th.Size = new Size(64, 59);
            Star4th.TabIndex = 4;
            Star4th.TabStop = false;
            Star4th.Click += Star4th_Click;
            // 
            // Star5th
            // 
            Star5th.Cursor = Cursors.Hand;
            Star5th.Image = Properties.Resources.Star_Dark;
            Star5th.Location = new Point(308, 339);
            Star5th.Margin = new Padding(3, 2, 3, 2);
            Star5th.Name = "Star5th";
            Star5th.Size = new Size(58, 59);
            Star5th.TabIndex = 5;
            Star5th.TabStop = false;
            Star5th.Click += Star5th_Click;
            // 
            // rating_Label
            // 
            rating_Label.AutoSize = true;
            rating_Label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            rating_Label.ForeColor = Color.FromArgb(8, 48, 107);
            rating_Label.Location = new Point(594, 339);
            rating_Label.Name = "rating_Label";
            rating_Label.Size = new Size(80, 30);
            rating_Label.TabIndex = 6;
            rating_Label.Text = "Rating:";
            // 
            // rate_Label
            // 
            rate_Label.AutoSize = true;
            rate_Label.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            rate_Label.ForeColor = Color.FromArgb(8, 48, 107);
            rate_Label.Location = new Point(671, 339);
            rate_Label.Name = "rate_Label";
            rate_Label.Size = new Size(21, 30);
            rate_Label.TabIndex = 8;
            rate_Label.Text = "1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(rate_Label);
            panel1.Controls.Add(feedback_Text);
            panel1.Controls.Add(Star1st);
            panel1.Controls.Add(rating_Label);
            panel1.Controls.Add(Star2nd);
            panel1.Controls.Add(Star5th);
            panel1.Controls.Add(Star3rd);
            panel1.Controls.Add(Star4th);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 486);
            panel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 193, 138);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(544, 412);
            button2.Name = "button2";
            button2.Size = new Size(152, 43);
            button2.TabIndex = 94;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.WhiteSmoke;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(8, 48, 107);
            label11.Location = new Point(268, 23);
            label11.Name = "label11";
            label11.Size = new Size(236, 45);
            label11.TabIndex = 93;
            label11.Text = "Give Feedback";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(56, 69);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 95;
            label1.Text = "Content:";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(239, 59, 44);
            button3.Location = new Point(709, 3);
            button3.Name = "button3";
            button3.Size = new Size(40, 36);
            button3.TabIndex = 96;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(772, 506);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Feedback";
            Padding = new Padding(10);
            Text = "Feedback";
            ((System.ComponentModel.ISupportInitialize)Star1st).EndInit();
            ((System.ComponentModel.ISupportInitialize)Star2nd).EndInit();
            ((System.ComponentModel.ISupportInitialize)Star3rd).EndInit();
            ((System.ComponentModel.ISupportInitialize)Star4th).EndInit();
            ((System.ComponentModel.ISupportInitialize)Star5th).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox feedback_Text;
        private PictureBox Star1st;
        private PictureBox Star2nd;
        private PictureBox Star3rd;
        private PictureBox Star4th;
        private PictureBox Star5th;
        private Label rating_Label;
        private Label rate_Label;
        private Panel panel1;
        private Label label11;
        private Button button2;
        private Label label1;
        private Button button3;
    }
}