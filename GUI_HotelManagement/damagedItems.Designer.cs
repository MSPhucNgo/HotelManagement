namespace GUI_HotelManagement
{
    partial class damagedItems
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
            this.damageList_DataGrid = new System.Windows.Forms.DataGridView();
            this.items_ComboBox = new System.Windows.Forms.ComboBox();
            this.ListRoom_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.amount_Text = new System.Windows.Forms.TextBox();
            this.add_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.damageList_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // damageList_DataGrid
            // 
            this.damageList_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.damageList_DataGrid.Location = new System.Drawing.Point(495, 61);
            this.damageList_DataGrid.Name = "damageList_DataGrid";
            this.damageList_DataGrid.RowHeadersWidth = 51;
            this.damageList_DataGrid.RowTemplate.Height = 29;
            this.damageList_DataGrid.Size = new System.Drawing.Size(293, 321);
            this.damageList_DataGrid.TabIndex = 0;
            // 
            // items_ComboBox
            // 
            this.items_ComboBox.Enabled = false;
            this.items_ComboBox.FormattingEnabled = true;
            this.items_ComboBox.Location = new System.Drawing.Point(88, 333);
            this.items_ComboBox.Name = "items_ComboBox";
            this.items_ComboBox.Size = new System.Drawing.Size(284, 28);
            this.items_ComboBox.TabIndex = 2;
            // 
            // ListRoom_Layout
            // 
            this.ListRoom_Layout.AllowDrop = true;
            this.ListRoom_Layout.AutoScroll = true;
            this.ListRoom_Layout.Location = new System.Drawing.Point(12, 27);
            this.ListRoom_Layout.Name = "ListRoom_Layout";
            this.ListRoom_Layout.Size = new System.Drawing.Size(477, 287);
            this.ListRoom_Layout.TabIndex = 3;
            // 
            // amount_Text
            // 
            this.amount_Text.Enabled = false;
            this.amount_Text.Location = new System.Drawing.Point(88, 367);
            this.amount_Text.Name = "amount_Text";
            this.amount_Text.Size = new System.Drawing.Size(125, 27);
            this.amount_Text.TabIndex = 4;
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(88, 411);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(94, 29);
            this.add_Button.TabIndex = 5;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "List damaged items";
            // 
            // damagedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.amount_Text);
            this.Controls.Add(this.ListRoom_Layout);
            this.Controls.Add(this.items_ComboBox);
            this.Controls.Add(this.damageList_DataGrid);
            this.Name = "damagedItems";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.damageList_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView damageList_DataGrid;
        private ComboBox items_ComboBox;
        private FlowLayoutPanel ListRoom_Layout;
        private TextBox amount_Text;
        private Button add_Button;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}