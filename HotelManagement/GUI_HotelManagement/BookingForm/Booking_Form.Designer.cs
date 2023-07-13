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
            labelPaymentMethod = new Label();
            comboBoxPaymentMethod = new ComboBox();
            checkBoxDeposit = new CheckBox();
            txtDepositFee = new TextBox();
            labelDepositFee = new Label();
            txtRoomFee = new TextBox();
            labelRoomFee = new Label();
            btnCheck = new Button();
            txtSpecialReq = new TextBox();
            txtNumberRoom = new TextBox();
            txtDepartureDate = new TextBox();
            txtArrivalDate = new TextBox();
            btnChooseRoom = new Button();
            labelDepartureDate = new Label();
            label2 = new Label();
            txtBirthday = new TextBox();
            txtGender = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtIdentify = new TextBox();
            txtName = new TextBox();
            panel1 = new Panel();
            txtNumberStay = new TextBox();
            labelNumberStay = new Label();
            labelNameGroup = new Label();
            txtNameGroup = new TextBox();
            checkBoxGroup = new CheckBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            panelBooking.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(21, 60);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 21);
            labelName.TabIndex = 7;
            labelName.Text = "Full Name:";
            // 
            // labelPhone
            // 
            labelPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhone.Location = new Point(21, 139);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(119, 21);
            labelPhone.TabIndex = 11;
            labelPhone.Text = "Phone Number:";
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(21, 179);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email:";
            // 
            // labelIdentify
            // 
            labelIdentify.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelIdentify.AutoSize = true;
            labelIdentify.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdentify.Location = new Point(21, 98);
            labelIdentify.Name = "labelIdentify";
            labelIdentify.Size = new Size(102, 21);
            labelIdentify.TabIndex = 23;
            labelIdentify.Text = "Identify Card:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(8, 48, 107);
            label11.Location = new Point(423, 6);
            label11.Name = "label11";
            label11.Size = new Size(151, 28);
            label11.TabIndex = 35;
            label11.Text = "Booking Room";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCreateBooking
            // 
            btnCreateBooking.BackColor = Color.FromArgb(0, 193, 138);
            btnCreateBooking.Cursor = Cursors.Hand;
            btnCreateBooking.FlatStyle = FlatStyle.Flat;
            btnCreateBooking.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateBooking.ForeColor = Color.White;
            btnCreateBooking.Location = new Point(584, 376);
            btnCreateBooking.Margin = new Padding(3, 2, 3, 2);
            btnCreateBooking.Name = "btnCreateBooking";
            btnCreateBooking.Size = new Size(286, 53);
            btnCreateBooking.TabIndex = 36;
            btnCreateBooking.Text = "Create Booking";
            btnCreateBooking.UseVisualStyleBackColor = false;
            btnCreateBooking.Click += btnCreateBooking_Click_1;
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelGender.Location = new Point(21, 219);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(64, 21);
            labelGender.TabIndex = 42;
            labelGender.Text = "Gender:";
            // 
            // labelBirthday
            // 
            labelBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelBirthday.AutoSize = true;
            labelBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBirthday.Location = new Point(21, 260);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(71, 21);
            labelBirthday.TabIndex = 43;
            labelBirthday.Text = "Birthday:";
            // 
            // labelArrivalDate
            // 
            labelArrivalDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelArrivalDate.AutoSize = true;
            labelArrivalDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelArrivalDate.Location = new Point(496, 60);
            labelArrivalDate.Name = "labelArrivalDate";
            labelArrivalDate.Size = new Size(95, 21);
            labelArrivalDate.TabIndex = 45;
            labelArrivalDate.Text = "Arrival Date:";
            // 
            // labelNumberRoom
            // 
            labelNumberRoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumberRoom.AutoSize = true;
            labelNumberRoom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberRoom.Location = new Point(496, 214);
            labelNumberRoom.Name = "labelNumberRoom";
            labelNumberRoom.Size = new Size(124, 21);
            labelNumberRoom.TabIndex = 46;
            labelNumberRoom.Text = "Number Rooms:";
            // 
            // labelSepcialReq
            // 
            labelSepcialReq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSepcialReq.AutoSize = true;
            labelSepcialReq.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSepcialReq.Location = new Point(496, 139);
            labelSepcialReq.Name = "labelSepcialReq";
            labelSepcialReq.Size = new Size(149, 21);
            labelSepcialReq.TabIndex = 49;
            labelSepcialReq.Text = "Special Requiments:";
            // 
            // panelBooking
            // 
            panelBooking.BackColor = Color.White;
            panelBooking.Controls.Add(labelPaymentMethod);
            panelBooking.Controls.Add(comboBoxPaymentMethod);
            panelBooking.Controls.Add(checkBoxDeposit);
            panelBooking.Controls.Add(txtDepositFee);
            panelBooking.Controls.Add(labelDepositFee);
            panelBooking.Controls.Add(txtRoomFee);
            panelBooking.Controls.Add(labelRoomFee);
            panelBooking.Controls.Add(btnCheck);
            panelBooking.Controls.Add(txtSpecialReq);
            panelBooking.Controls.Add(txtNumberRoom);
            panelBooking.Controls.Add(txtDepartureDate);
            panelBooking.Controls.Add(txtArrivalDate);
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
            panelBooking.Controls.Add(panel1);
            panelBooking.Dock = DockStyle.Fill;
            panelBooking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelBooking.Location = new Point(10, 10);
            panelBooking.Margin = new Padding(3, 2, 3, 2);
            panelBooking.Name = "panelBooking";
            panelBooking.Size = new Size(957, 447);
            panelBooking.TabIndex = 8;
            // 
            // labelPaymentMethod
            // 
            labelPaymentMethod.AutoSize = true;
            labelPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPaymentMethod.Location = new Point(496, 336);
            labelPaymentMethod.Name = "labelPaymentMethod";
            labelPaymentMethod.Size = new Size(131, 21);
            labelPaymentMethod.TabIndex = 85;
            labelPaymentMethod.Text = "Payment Method:";
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.Cursor = Cursors.IBeam;
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Traveller Cheque", "Traveller Agent Account" });
            comboBoxPaymentMethod.Location = new Point(648, 331);
            comboBoxPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(151, 29);
            comboBoxPaymentMethod.TabIndex = 84;
            comboBoxPaymentMethod.SelectedIndexChanged += comboBoxPaymentMethod_SelectedIndexChanged_1;
            // 
            // checkBoxDeposit
            // 
            checkBoxDeposit.AutoSize = true;
            checkBoxDeposit.Cursor = Cursors.Hand;
            checkBoxDeposit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxDeposit.Location = new Point(819, 336);
            checkBoxDeposit.Margin = new Padding(3, 2, 3, 2);
            checkBoxDeposit.Name = "checkBoxDeposit";
            checkBoxDeposit.Size = new Size(106, 25);
            checkBoxDeposit.TabIndex = 83;
            checkBoxDeposit.Text = "Deposited?";
            checkBoxDeposit.UseVisualStyleBackColor = true;
            checkBoxDeposit.CheckedChanged += checkBoxDeposit_CheckedChanged_1;
            // 
            // txtDepositFee
            // 
            txtDepositFee.BorderStyle = BorderStyle.FixedSingle;
            txtDepositFee.Cursor = Cursors.IBeam;
            txtDepositFee.Location = new Point(648, 291);
            txtDepositFee.Margin = new Padding(3, 2, 3, 2);
            txtDepositFee.Name = "txtDepositFee";
            txtDepositFee.Size = new Size(151, 29);
            txtDepositFee.TabIndex = 82;
            // 
            // labelDepositFee
            // 
            labelDepositFee.AutoSize = true;
            labelDepositFee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDepositFee.Location = new Point(496, 299);
            labelDepositFee.Name = "labelDepositFee";
            labelDepositFee.Size = new Size(94, 21);
            labelDepositFee.TabIndex = 81;
            labelDepositFee.Text = "Deposit Fee:";
            // 
            // txtRoomFee
            // 
            txtRoomFee.BorderStyle = BorderStyle.FixedSingle;
            txtRoomFee.Cursor = Cursors.IBeam;
            txtRoomFee.Location = new Point(648, 252);
            txtRoomFee.Margin = new Padding(3, 2, 3, 2);
            txtRoomFee.Name = "txtRoomFee";
            txtRoomFee.Size = new Size(151, 29);
            txtRoomFee.TabIndex = 80;
            // 
            // labelRoomFee
            // 
            labelRoomFee.AutoSize = true;
            labelRoomFee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRoomFee.Location = new Point(496, 260);
            labelRoomFee.Name = "labelRoomFee";
            labelRoomFee.Size = new Size(83, 21);
            labelRoomFee.TabIndex = 79;
            labelRoomFee.Text = "Room Fee:";
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(8, 48, 107);
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(306, 92);
            btnCheck.Margin = new Padding(3, 2, 3, 2);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(100, 29);
            btnCheck.TabIndex = 78;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click_1;
            // 
            // txtSpecialReq
            // 
            txtSpecialReq.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialReq.Cursor = Cursors.IBeam;
            txtSpecialReq.Location = new Point(648, 131);
            txtSpecialReq.Margin = new Padding(3, 2, 3, 2);
            txtSpecialReq.Multiline = true;
            txtSpecialReq.Name = "txtSpecialReq";
            txtSpecialReq.Size = new Size(277, 64);
            txtSpecialReq.TabIndex = 72;
            // 
            // txtNumberRoom
            // 
            txtNumberRoom.BorderStyle = BorderStyle.FixedSingle;
            txtNumberRoom.Cursor = Cursors.IBeam;
            txtNumberRoom.Location = new Point(648, 206);
            txtNumberRoom.Margin = new Padding(3, 2, 3, 2);
            txtNumberRoom.Name = "txtNumberRoom";
            txtNumberRoom.Size = new Size(86, 29);
            txtNumberRoom.TabIndex = 73;
            // 
            // txtDepartureDate
            // 
            txtDepartureDate.BorderStyle = BorderStyle.FixedSingle;
            txtDepartureDate.Cursor = Cursors.IBeam;
            txtDepartureDate.Location = new Point(648, 91);
            txtDepartureDate.Margin = new Padding(3, 2, 3, 2);
            txtDepartureDate.Name = "txtDepartureDate";
            txtDepartureDate.Size = new Size(151, 29);
            txtDepartureDate.TabIndex = 74;
            // 
            // txtArrivalDate
            // 
            txtArrivalDate.BorderStyle = BorderStyle.FixedSingle;
            txtArrivalDate.Cursor = Cursors.IBeam;
            txtArrivalDate.Location = new Point(648, 52);
            txtArrivalDate.Margin = new Padding(3, 2, 3, 2);
            txtArrivalDate.Name = "txtArrivalDate";
            txtArrivalDate.Size = new Size(151, 29);
            txtArrivalDate.TabIndex = 75;
            // 
            // btnChooseRoom
            // 
            btnChooseRoom.BackColor = Color.FromArgb(8, 48, 107);
            btnChooseRoom.Cursor = Cursors.Hand;
            btnChooseRoom.FlatAppearance.BorderSize = 0;
            btnChooseRoom.FlatStyle = FlatStyle.Flat;
            btnChooseRoom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChooseRoom.ForeColor = Color.White;
            btnChooseRoom.Location = new Point(754, 206);
            btnChooseRoom.Margin = new Padding(3, 2, 3, 2);
            btnChooseRoom.Name = "btnChooseRoom";
            btnChooseRoom.Size = new Size(171, 29);
            btnChooseRoom.TabIndex = 65;
            btnChooseRoom.Text = "Choose Room";
            btnChooseRoom.UseVisualStyleBackColor = false;
            btnChooseRoom.Click += btnChooseRoom_Click;
            // 
            // labelDepartureDate
            // 
            labelDepartureDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDepartureDate.AutoSize = true;
            labelDepartureDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDepartureDate.Location = new Point(496, 100);
            labelDepartureDate.Name = "labelDepartureDate";
            labelDepartureDate.Size = new Size(119, 21);
            labelDepartureDate.TabIndex = 62;
            labelDepartureDate.Text = "Departure Date:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(496, 87);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 61;
            // 
            // txtBirthday
            // 
            txtBirthday.BorderStyle = BorderStyle.FixedSingle;
            txtBirthday.Cursor = Cursors.IBeam;
            txtBirthday.Location = new Point(146, 252);
            txtBirthday.Margin = new Padding(3, 2, 3, 2);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(141, 29);
            txtBirthday.TabIndex = 56;
            // 
            // txtGender
            // 
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Cursor = Cursors.IBeam;
            txtGender.Location = new Point(146, 211);
            txtGender.Margin = new Padding(3, 2, 3, 2);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(141, 29);
            txtGender.TabIndex = 55;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(146, 171);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 29);
            txtEmail.TabIndex = 54;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Cursor = Cursors.IBeam;
            txtPhone.Location = new Point(146, 131);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(141, 29);
            txtPhone.TabIndex = 53;
            // 
            // txtIdentify
            // 
            txtIdentify.BorderStyle = BorderStyle.FixedSingle;
            txtIdentify.Cursor = Cursors.IBeam;
            txtIdentify.Location = new Point(146, 92);
            txtIdentify.Margin = new Padding(3, 2, 3, 2);
            txtIdentify.Name = "txtIdentify";
            txtIdentify.Size = new Size(141, 29);
            txtIdentify.TabIndex = 52;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(146, 52);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 29);
            txtName.TabIndex = 51;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 246, 252);
            panel1.Controls.Add(txtNumberStay);
            panel1.Controls.Add(labelNumberStay);
            panel1.Controls.Add(labelNameGroup);
            panel1.Controls.Add(txtNameGroup);
            panel1.Controls.Add(checkBoxGroup);
            panel1.Location = new Point(21, 299);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 130);
            panel1.TabIndex = 86;
            // 
            // txtNumberStay
            // 
            txtNumberStay.BorderStyle = BorderStyle.FixedSingle;
            txtNumberStay.Cursor = Cursors.IBeam;
            txtNumberStay.Location = new Point(170, 45);
            txtNumberStay.Margin = new Padding(3, 2, 3, 2);
            txtNumberStay.Name = "txtNumberStay";
            txtNumberStay.Size = new Size(171, 29);
            txtNumberStay.TabIndex = 71;
            txtNumberStay.Visible = false;
            // 
            // labelNumberStay
            // 
            labelNumberStay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNumberStay.AutoSize = true;
            labelNumberStay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberStay.Location = new Point(35, 53);
            labelNumberStay.Name = "labelNumberStay";
            labelNumberStay.Size = new Size(104, 21);
            labelNumberStay.TabIndex = 67;
            labelNumberStay.Text = "Number Stay:";
            labelNumberStay.Visible = false;
            // 
            // labelNameGroup
            // 
            labelNameGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNameGroup.AutoSize = true;
            labelNameGroup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameGroup.Location = new Point(35, 90);
            labelNameGroup.Name = "labelNameGroup";
            labelNameGroup.Size = new Size(121, 21);
            labelNameGroup.TabIndex = 68;
            labelNameGroup.Text = "Name of Group:";
            labelNameGroup.Visible = false;
            // 
            // txtNameGroup
            // 
            txtNameGroup.BorderStyle = BorderStyle.FixedSingle;
            txtNameGroup.Cursor = Cursors.IBeam;
            txtNameGroup.Location = new Point(170, 82);
            txtNameGroup.Margin = new Padding(3, 2, 3, 2);
            txtNameGroup.Name = "txtNameGroup";
            txtNameGroup.Size = new Size(171, 29);
            txtNameGroup.TabIndex = 76;
            txtNameGroup.Visible = false;
            // 
            // checkBoxGroup
            // 
            checkBoxGroup.AutoSize = true;
            checkBoxGroup.Cursor = Cursors.Hand;
            checkBoxGroup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxGroup.Location = new Point(35, 14);
            checkBoxGroup.Margin = new Padding(3, 2, 3, 2);
            checkBoxGroup.Name = "checkBoxGroup";
            checkBoxGroup.Size = new Size(178, 25);
            checkBoxGroup.TabIndex = 66;
            checkBoxGroup.Text = "Group Inclusive Tour?";
            checkBoxGroup.UseVisualStyleBackColor = true;
            checkBoxGroup.CheckedChanged += checkBoxGroup_CheckedChanged;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Booking_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 193, 138);
            ClientSize = new Size(977, 467);
            Controls.Add(panelBooking);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Booking_Form";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking_Form";
            Load += Load_BookingForm;
            panelBooking.ResumeLayout(false);
            panelBooking.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label labelNameGroup;
        private Label labelNumberStay;
        private CheckBox checkBoxGroup;
        private Button btnCheck;
        private TextBox txtDepositFee;
        private Label labelDepositFee;
        private TextBox txtRoomFee;
        private Label labelRoomFee;
        private CheckBox checkBoxDeposit;
        private ComboBox comboBoxPaymentMethod;
        private Label labelPaymentMethod;
        private Panel panel1;
    }
}