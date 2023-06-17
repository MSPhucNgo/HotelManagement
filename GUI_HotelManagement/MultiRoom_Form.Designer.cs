namespace GUI_HotelManagement
{
    partial class MultiRoom_Form
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
            bookingRoom_DataGrid = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookingRoom_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // ListRoom_FlowLayout
            // 
            ListRoom_FlowLayout.AutoScroll = true;
            ListRoom_FlowLayout.Location = new Point(12, 12);
            ListRoom_FlowLayout.Name = "ListRoom_FlowLayout";
            ListRoom_FlowLayout.Size = new Size(646, 558);
            ListRoom_FlowLayout.TabIndex = 8;
            // 
            // bookingRoom_DataGrid
            // 
            bookingRoom_DataGrid.AllowUserToAddRows = false;
            bookingRoom_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingRoom_DataGrid.Location = new Point(680, 45);
            bookingRoom_DataGrid.Name = "bookingRoom_DataGrid";
            bookingRoom_DataGrid.RowHeadersVisible = false;
            bookingRoom_DataGrid.RowHeadersWidth = 51;
            bookingRoom_DataGrid.RowTemplate.Height = 29;
            bookingRoom_DataGrid.Size = new Size(398, 509);
            bookingRoom_DataGrid.TabIndex = 9;
            bookingRoom_DataGrid.CellContentClick += bookingRoom_DataGrid_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(984, 560);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(835, 22);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 11;
            label1.Text = "BookingRoom";
            // 
            // MultiRoom_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 601);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(bookingRoom_DataGrid);
            Controls.Add(ListRoom_FlowLayout);
            Name = "MultiRoom_Form";
            Text = "MultiRoom_Form";
            ((System.ComponentModel.ISupportInitialize)bookingRoom_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel ListRoom_FlowLayout;
        private DataGridView bookingRoom_DataGrid;
        private Button button1;
        private Label label1;
    }
}