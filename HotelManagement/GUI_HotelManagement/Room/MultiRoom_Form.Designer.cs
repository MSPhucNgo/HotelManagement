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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bookingRoom_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListRoom_FlowLayout
            // 
            this.ListRoom_FlowLayout.AutoScroll = true;
            this.ListRoom_FlowLayout.Location = new System.Drawing.Point(42, 89);
            this.ListRoom_FlowLayout.Name = "ListRoom_FlowLayout";
            this.ListRoom_FlowLayout.Size = new System.Drawing.Size(786, 635);
            this.ListRoom_FlowLayout.TabIndex = 8;
            // 
            // bookingRoom_DataGrid
            // 
            this.bookingRoom_DataGrid.AllowUserToAddRows = false;
            this.bookingRoom_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingRoom_DataGrid.Location = new System.Drawing.Point(870, 89);
            this.bookingRoom_DataGrid.Name = "bookingRoom_DataGrid";
            this.bookingRoom_DataGrid.RowHeadersVisible = false;
            this.bookingRoom_DataGrid.RowHeadersWidth = 51;
            this.bookingRoom_DataGrid.RowTemplate.Height = 29;
            this.bookingRoom_DataGrid.Size = new System.Drawing.Size(398, 509);
            this.bookingRoom_DataGrid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(870, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "BookingRoom";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.button2.Location = new System.Drawing.Point(984, 660);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 64);
            this.button2.TabIndex = 28;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ListRoom_FlowLayout);
            this.panel1.Controls.Add(this.bookingRoom_DataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 763);
            this.panel1.TabIndex = 29;
            // 
            // MultiRoom_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1341, 789);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MultiRoom_Form";
            this.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.Text = "MultiRoom_Form";
            ((System.ComponentModel.ISupportInitialize)(this.bookingRoom_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel ListRoom_FlowLayout;
        private DataGridView bookingRoom_DataGrid;
        private Label label1;
        private Button button2;
        private Panel panel1;
    }
}