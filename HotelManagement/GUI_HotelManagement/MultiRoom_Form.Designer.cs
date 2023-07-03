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
            this.ListRoom_FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.bookingRoom_DataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingRoom_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ListRoom_FlowLayout
            // 
            this.ListRoom_FlowLayout.AutoScroll = true;
            this.ListRoom_FlowLayout.Location = new System.Drawing.Point(12, 12);
            this.ListRoom_FlowLayout.Name = "ListRoom_FlowLayout";
            this.ListRoom_FlowLayout.Size = new System.Drawing.Size(646, 558);
            this.ListRoom_FlowLayout.TabIndex = 8;
            // 
            // bookingRoom_DataGrid
            // 
            this.bookingRoom_DataGrid.AllowUserToAddRows = false;
            this.bookingRoom_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingRoom_DataGrid.Location = new System.Drawing.Point(680, 45);
            this.bookingRoom_DataGrid.Name = "bookingRoom_DataGrid";
            this.bookingRoom_DataGrid.RowHeadersVisible = false;
            this.bookingRoom_DataGrid.RowHeadersWidth = 51;
            this.bookingRoom_DataGrid.RowTemplate.Height = 29;
            this.bookingRoom_DataGrid.Size = new System.Drawing.Size(398, 509);
            this.bookingRoom_DataGrid.TabIndex = 9;
            this.bookingRoom_DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingRoom_DataGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "BookingRoom";
            // 
            // MultiRoom_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookingRoom_DataGrid);
            this.Controls.Add(this.ListRoom_FlowLayout);
            this.Name = "MultiRoom_Form";
            this.Text = "MultiRoom_Form";
            ((System.ComponentModel.ISupportInitialize)(this.bookingRoom_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel ListRoom_FlowLayout;
        private DataGridView bookingRoom_DataGrid;
        private Button button1;
        private Label label1;
    }
}