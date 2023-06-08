namespace GUI_HotelManagement
{
    partial class login_GUI
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
            btn_login = new Button();
            tb_User = new TextBox();
            tb_Pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(356, 250);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 0;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tb_User
            // 
            tb_User.Location = new Point(344, 137);
            tb_User.Name = "tb_User";
            tb_User.Size = new Size(100, 23);
            tb_User.TabIndex = 1;
            // 
            // tb_Pass
            // 
            tb_Pass.Location = new Point(344, 190);
            tb_Pass.Name = "tb_Pass";
            tb_Pass.Size = new Size(100, 23);
            tb_Pass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 144);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "EMP11";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 198);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "1234";
            // 
            // login_GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_Pass);
            Controls.Add(tb_User);
            Controls.Add(btn_login);
            Name = "login_GUI";
            Text = "login_GUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox tb_User;
        private TextBox tb_Pass;
        private Label label1;
        private Label label2;
    }
}