using System.Runtime.Intrinsics.X86;

namespace GUI_HotelManagement
{
    partial class Booking_Form
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
            components = new System.ComponentModel.Container(); 
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelName = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelIdentify = new Label();
            label11 = new Label();
            btnCreateBooking = new Button();
            labelGender = new Label();
            labelBirthday = new Label();
            labelArrivalDate = new Label();
            labelNumberRoom = new Label();
            labelSepcialReq = new Label();
            panelBooking = new Panel();
            btnCheck = new Button();
            splitter1 = new Splitter();
            txtSpecialReq = new TextBox();
            txtNumberRoom = new TextBox();
            txtDepartureDate = new TextBox();
            txtArrivalDate = new TextBox();
            txtNameGroup = new TextBox();
            txtNumberStay = new TextBox();
            labelNameGroup = new Label();
            labelNumberStay = new Label();
            checkBoxGroup = new CheckBox();
            btnChooseRoom = new Button();
            labelDepartureDate = new Label();
            label2 = new Label();
            txtBirthday = new TextBox();
            txtGender = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtIdentify = new TextBox();
            txtName = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            panelBooking.SuspendLayout();
            SuspendLayout();
            
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(24, 59);
            labelName.Name = "labelName";
            labelName.Size = new Size(127, 35);
            labelName.TabIndex = 7;
            labelName.Text = "Full Name";
            // 
            // labelPhone
            // 
            labelPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhone.Location = new Point(24, 185);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(184, 35);
            labelPhone.TabIndex = 11;
            labelPhone.Text = "Phone Number";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(24, 251);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(75, 35);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // labelIdentify
            // 
            labelIdentify.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelIdentify.AutoSize = true;
            labelIdentify.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdentify.Location = new Point(24, 121);
            labelIdentify.Name = "labelIdentify";
            labelIdentify.Size = new Size(157, 35);
            labelIdentify.TabIndex = 23;
            labelIdentify.Text = "Identify Card";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(491, -3);
            label11.Name = "label11";
            label11.Size = new Size(112, 35);
            label11.TabIndex = 35;
            label11.Text = "Booking";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCreateBooking
            // 
            btnCreateBooking.Location = new Point(880, 498);
            btnCreateBooking.Name = "btnCreateBooking";
            btnCreateBooking.Size = new Size(177, 84);
            btnCreateBooking.TabIndex = 36;
            btnCreateBooking.Text = "Create Booking";
            btnCreateBooking.UseVisualStyleBackColor = true;
            btnCreateBooking.Click += btnCreateBooking_Click;
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelGender.Location = new Point(24, 311);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(96, 35);
            labelGender.TabIndex = 42;
            labelGender.Text = "Gender";
            // 
            // labelBirthday
            // 
            labelBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelBirthday.AutoSize = true;
            labelBirthday.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelBirthday.Location = new Point(17, 374);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(106, 35);
            labelBirthday.TabIndex = 43;
            labelBirthday.Text = "Birthday";
            // 
            // labelArrivalDate
            // 
            labelArrivalDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelArrivalDate.AutoSize = true;
            labelArrivalDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelArrivalDate.Location = new Point(516, 250);
            labelArrivalDate.Name = "labelArrivalDate";
            labelArrivalDate.Size = new Size(145, 35);
            labelArrivalDate.TabIndex = 45;
            labelArrivalDate.Text = "Arrival Date";
            // 
            // labelNumberRoom
            // 
            labelNumberRoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumberRoom.AutoSize = true;
            labelNumberRoom.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberRoom.Location = new Point(508, 443);
            labelNumberRoom.Name = "labelNumberRoom";
            labelNumberRoom.Size = new Size(191, 35);
            labelNumberRoom.TabIndex = 46;
            labelNumberRoom.Text = "Number Rooms";
            // 
            // labelSepcialReq
            // 
            labelSepcialReq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSepcialReq.AutoSize = true;
            labelSepcialReq.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelSepcialReq.Location = new Point(512, 382);
            labelSepcialReq.Name = "labelSepcialReq";
            labelSepcialReq.Size = new Size(230, 35);
            labelSepcialReq.TabIndex = 49;
            labelSepcialReq.Text = "Special Requiments";
            // 
            // Load data 
            this.Load += new System.EventHandler(this.Load_BookingForm);
            // panelBooking
            // 
            panelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBooking.Controls.Add(btnCheck);
            panelBooking.Controls.Add(splitter1);
            panelBooking.Controls.Add(txtSpecialReq);
            panelBooking.Controls.Add(txtNumberRoom);
            panelBooking.Controls.Add(txtDepartureDate);
            panelBooking.Controls.Add(txtArrivalDate);
            panelBooking.Controls.Add(txtNameGroup);
            panelBooking.Controls.Add(txtNumberStay);
            panelBooking.Controls.Add(labelNameGroup);
            panelBooking.Controls.Add(labelNumberStay);
            panelBooking.Controls.Add(checkBoxGroup);
            panelBooking.Controls.Add(btnChooseRoom);
            panelBooking.Controls.Add(labelDepartureDate);
            panelBooking.Controls.Add(label2);
            panelBooking.Controls.Add(txtBirthday);
            panelBooking.Controls.Add(txtGender);
            panelBooking.Controls.Add(txtEmail);
            panelBooking.Controls.Add(txtPhone);
            panelBooking.Controls.Add(txtIdentify);
            panelBooking.Controls.Add(txtName);
            panelBooking.Controls.Add(labelSepcialReq);
            panelBooking.Controls.Add(labelNumberRoom);
            panelBooking.Controls.Add(labelArrivalDate);
            panelBooking.Controls.Add(labelBirthday);
            panelBooking.Controls.Add(labelGender);
            panelBooking.Controls.Add(btnCreateBooking);
            panelBooking.Controls.Add(label11);
            panelBooking.Controls.Add(labelIdentify);
            panelBooking.Controls.Add(labelEmail);
            panelBooking.Controls.Add(labelPhone);
            panelBooking.Controls.Add(labelName);
            panelBooking.Location = new Point(12, 12);
            panelBooking.Name = "panelBooking";
            panelBooking.Size = new Size(1093, 599);
            panelBooking.TabIndex = 8;
            panelBooking.Paint += panelBooking_Paint_1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(346, 122);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(60, 40);
            btnCheck.TabIndex = 78;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 599);
            splitter1.TabIndex = 77;
            splitter1.TabStop = false;
            // 
            // txtSpecialReq
            // 
            txtSpecialReq.Location = new Point(748, 382);
            txtSpecialReq.Name = "txtSpecialReq";
            txtSpecialReq.Size = new Size(258, 27);
            txtSpecialReq.TabIndex = 72;
            // 
            // txtNumberRoom
            // 
            txtNumberRoom.Location = new Point(720, 451);
            txtNumberRoom.Name = "txtNumberRoom";
            txtNumberRoom.Size = new Size(132, 27);
            txtNumberRoom.TabIndex = 73;
            // 
            // txtDepartureDate
            // 
            txtDepartureDate.Location = new Point(759, 320);
            txtDepartureDate.Name = "txtDepartureDate";
            txtDepartureDate.Size = new Size(245, 27);
            txtDepartureDate.TabIndex = 74;
            // 
            // txtArrivalDate
            // 
            txtArrivalDate.Location = new Point(720, 259);
            txtArrivalDate.Name = "txtArrivalDate";
            txtArrivalDate.Size = new Size(286, 27);
            txtArrivalDate.TabIndex = 75;
            // 
            // txtNameGroup
            // 
            txtNameGroup.Location = new Point(764, 194);
            txtNameGroup.Name = "txtNameGroup";
            txtNameGroup.Size = new Size(242, 27);
            txtNameGroup.TabIndex = 76;
            txtNameGroup.Visible = false;
            // 
            // txtNumberStay
            // 
            txtNumberStay.Location = new Point(734, 130);
            txtNumberStay.Name = "txtNumberStay";
            txtNumberStay.Size = new Size(272, 27);
            txtNumberStay.TabIndex = 71;
            txtNumberStay.Visible = false;
            // 
            // labelNameGroup
            // 
            labelNameGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNameGroup.AutoSize = true;
            labelNameGroup.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameGroup.Location = new Point(516, 185);
            labelNameGroup.Name = "labelNameGroup";
            labelNameGroup.Size = new Size(189, 35);
            labelNameGroup.TabIndex = 68;
            labelNameGroup.Text = "Name of Group";
            labelNameGroup.Visible = false;
            // 
            // labelNumberStay
            // 
            labelNumberStay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumberStay.AutoSize = true;
            labelNumberStay.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberStay.Location = new Point(516, 121);
            labelNumberStay.Name = "labelNumberStay";
            labelNumberStay.Size = new Size(159, 35);
            labelNumberStay.TabIndex = 67;
            labelNumberStay.Text = "Number Stay";
            labelNumberStay.Visible = false;
            // 
            // checkBoxGroup
            // 
            checkBoxGroup.AutoSize = true;
            checkBoxGroup.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxGroup.Location = new Point(516, 59);
            checkBoxGroup.Name = "checkBoxGroup";
            checkBoxGroup.Size = new Size(276, 39);
            checkBoxGroup.TabIndex = 66;
            checkBoxGroup.Text = "Group Inclusive Tour?";
            checkBoxGroup.UseVisualStyleBackColor = true;
            checkBoxGroup.CheckedChanged += checkBoxGroup_CheckedChanged;
            // 
            // btnChooseRoom
            // 
            btnChooseRoom.Location = new Point(880, 434);
            btnChooseRoom.Name = "btnChooseRoom";
            btnChooseRoom.Size = new Size(124, 58);
            btnChooseRoom.TabIndex = 65;
            btnChooseRoom.Text = "Choose Room";
            btnChooseRoom.UseVisualStyleBackColor = true;
            btnChooseRoom.Click += btnChooseRoom_Click;
            // 
            // labelDepartureDate
            // 
            labelDepartureDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDepartureDate.AutoSize = true;
            labelDepartureDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelDepartureDate.Location = new Point(514, 311);
            labelDepartureDate.Name = "labelDepartureDate";
            labelDepartureDate.Size = new Size(186, 35);
            labelDepartureDate.TabIndex = 62;
            labelDepartureDate.Text = "Departure Date";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(514, 306);
            label2.Name = "label2";
            label2.Size = new Size(0, 35);
            label2.TabIndex = 61;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(126, 382);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(280, 27);
            txtBirthday.TabIndex = 56;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(126, 319);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(280, 27);
            txtGender.TabIndex = 55;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(105, 255);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(301, 27);
            txtEmail.TabIndex = 54;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(214, 193);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(192, 27);
            txtPhone.TabIndex = 53;
            // 
            // txtIdentify
            // 
            txtIdentify.Location = new Point(185, 129);
            txtIdentify.Name = "txtIdentify";
            txtIdentify.Size = new Size(155, 27);
            txtIdentify.TabIndex = 52;
            txtIdentify.TextChanged += txtIdentity_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 27);
            txtName.TabIndex = 51;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Booking_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 623);
            Controls.Add(panelBooking);
            Name = "Booking_Form";
            Text = "Booking_Form";
            Load += Booking_Form_Load;
            panelBooking.ResumeLayout(false);
            panelBooking.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label labelName;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelIdentify;
        private Label label11;
        private Button btnCreateBooking;
        private Label labelGender;
        private Label labelBirthday;
        private Label labelArrivalDate;
        private Label labelNumberRoom;
        private Label labelSepcialReq;
        private Panel panelBooking;
        private Button btnChooseRoom;
        private Label labelDepartureDate;
        private Label label2;
        private TextBox txtBirthday;
        private TextBox txtGender;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtIdentify;
        private TextBox txtName;
        private TextBox txtSpecialReq;
        private TextBox txtNumberRoom;
        private TextBox txtDepartureDate;
        private TextBox txtArrivalDate;
        private TextBox txtNameGroup;
        private TextBox txtNumberStay;
        private ContextMenuStrip contextMenuStrip2;
        private Splitter splitter1;
        private Label labelNameGroup;
        private Label labelNumberStay;
        private CheckBox checkBoxGroup;
        private Button btnCheck;
    }
}