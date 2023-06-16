namespace HotelManagement
{
    partial class Service_Of_Room
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
            dtgvServiceList = new DataGridView();
            panel1 = new Panel();
            btn_room_search_search = new Button();
            txtbServiceName = new TextBox();
            lb_room_service = new Label();
            bindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            dtgvOffer = new DataGridView();
            txbStatus = new TextBox();
            label1 = new Label();
            btnOrder = new Button();
            label7 = new Label();
            txtPrice = new TextBox();
            label6 = new Label();
            txtUnit = new TextBox();
            label5 = new Label();
            txtDesc = new TextBox();
            label4 = new Label();
            txbName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvServiceList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOffer).BeginInit();
            SuspendLayout();
            // 
            // dtgvServiceList
            // 
            dtgvServiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvServiceList.Location = new Point(11, 97);
            dtgvServiceList.Margin = new Padding(2, 3, 2, 3);
            dtgvServiceList.Name = "dtgvServiceList";
            dtgvServiceList.RowHeadersWidth = 62;
            dtgvServiceList.RowTemplate.Height = 33;
            dtgvServiceList.Size = new Size(680, 722);
            dtgvServiceList.TabIndex = 0;
            dtgvServiceList.CellContentClick += dtgvServiceList_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_room_search_search);
            panel1.Controls.Add(txtbServiceName);
            panel1.Controls.Add(lb_room_service);
            panel1.Location = new Point(9, 9);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1233, 52);
            panel1.TabIndex = 1;
            // 
            // btn_room_search_search
            // 
            btn_room_search_search.Location = new Point(724, 3);
            btn_room_search_search.Margin = new Padding(2, 3, 2, 3);
            btn_room_search_search.Name = "btn_room_search_search";
            btn_room_search_search.Size = new Size(179, 40);
            btn_room_search_search.TabIndex = 2;
            btn_room_search_search.Text = "Search service";
            btn_room_search_search.UseVisualStyleBackColor = true;
            btn_room_search_search.Click += button1_Click;
            // 
            // txtbServiceName
            // 
            txtbServiceName.Location = new Point(267, 9);
            txtbServiceName.Margin = new Padding(2, 3, 2, 3);
            txtbServiceName.Name = "txtbServiceName";
            txtbServiceName.Size = new Size(283, 27);
            txtbServiceName.TabIndex = 1;
            // 
            // lb_room_service
            // 
            lb_room_service.AutoSize = true;
            lb_room_service.Location = new Point(154, 13);
            lb_room_service.Margin = new Padding(2, 0, 2, 0);
            lb_room_service.Name = "lb_room_service";
            lb_room_service.Size = new Size(100, 20);
            lb_room_service.TabIndex = 0;
            lb_room_service.Text = "Service name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvOffer);
            panel2.Controls.Add(txbStatus);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnOrder);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtUnit);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtDesc);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txbName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(710, 140);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 679);
            panel2.TabIndex = 2;
            // 
            // dtgvOffer
            // 
            dtgvOffer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvOffer.Location = new Point(25, 353);
            dtgvOffer.Margin = new Padding(2, 3, 2, 3);
            dtgvOffer.Name = "dtgvOffer";
            dtgvOffer.RowHeadersWidth = 62;
            dtgvOffer.RowTemplate.Height = 33;
            dtgvOffer.Size = new Size(502, 228);
            dtgvOffer.TabIndex = 17;
            // 
            // txbStatus
            // 
            txbStatus.Location = new Point(96, 82);
            txbStatus.Margin = new Padding(2, 3, 2, 3);
            txbStatus.Name = "txbStatus";
            txbStatus.Size = new Size(431, 27);
            txbStatus.TabIndex = 16;
            txbStatus.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 15;
            label1.Text = "Status";
            label1.Click += label1_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(180, 597);
            btnOrder.Margin = new Padding(2, 3, 2, 3);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(196, 63);
            btnOrder.TabIndex = 14;
            btnOrder.Text = "ORDER SERVICE NOW!";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 315);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 12;
            label7.Text = "Offer for room";
            label7.Click += label7_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(96, 171);
            txtPrice.Margin = new Padding(2, 3, 2, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(431, 27);
            txtPrice.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 174);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 10;
            label6.Text = "Price/unit";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(96, 125);
            txtUnit.Margin = new Padding(2, 3, 2, 3);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(431, 27);
            txtUnit.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 128);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 8;
            label5.Text = "Unit";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(96, 217);
            txtDesc.Margin = new Padding(2, 3, 2, 3);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(431, 95);
            txtDesc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 220);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // txbName
            // 
            txbName.Location = new Point(96, 41);
            txbName.Margin = new Padding(2, 3, 2, 3);
            txbName.Name = "txbName";
            txbName.Size = new Size(431, 27);
            txbName.TabIndex = 5;
            txbName.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 43);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 0;
            label2.Text = "Service Information";
            label2.Click += label2_Click;
            // 
            // Service_Of_Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 843);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dtgvServiceList);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Service_Of_Room";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service_Of_Room";
            ((System.ComponentModel.ISupportInitialize)dtgvServiceList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvOffer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvServiceList;
        private Panel panel1;
        private Button btn_room_search_search;
        private TextBox txtbServiceName;
        private Label lb_room_service;
        private BindingSource bindingSource1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox txbName;
        private Button btnOrder;
        private TextBox txbDiscount;
        private Label label7;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtUnit;
        private Label label5;
        private TextBox txtDesc;
        private Label label4;
        private TextBox txbStatus;
        private Label label1;
        private DataGridView dtgvOffer;
    }
}