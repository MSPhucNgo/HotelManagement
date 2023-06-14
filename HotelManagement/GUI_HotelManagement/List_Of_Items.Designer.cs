namespace GUI_HotelManagement
{
    partial class List_Of_Items
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_List_Of_Items = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_List_Of_Items = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lb_List_Of_Items);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 729);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 693);
            this.panel3.TabIndex = 2;
            // 
            // lb_List_Of_Items
            // 
            this.lb_List_Of_Items.AutoSize = true;
            this.lb_List_Of_Items.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_List_Of_Items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_List_Of_Items.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_List_Of_Items.Location = new System.Drawing.Point(0, 0);
            this.lb_List_Of_Items.Name = "lb_List_Of_Items";
            this.lb_List_Of_Items.Size = new System.Drawing.Size(170, 40);
            this.lb_List_Of_Items.TabIndex = 1;
            this.lb_List_Of_Items.Text = "LIST OF ITEMS";
            this.lb_List_Of_Items.UseCompatibleTextRendering = true;
            this.lb_List_Of_Items.Click += new System.EventHandler(this.lb_List_Of_Items_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(19, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1320, 150);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.dgv_List_Of_Items);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(18, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1320, 493);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIST OF ITEMS";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // dgv_List_Of_Items
            // 
            this.dgv_List_Of_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List_Of_Items.Location = new System.Drawing.Point(0, 43);
            this.dgv_List_Of_Items.Name = "dgv_List_Of_Items";
            this.dgv_List_Of_Items.RowHeadersWidth = 51;
            this.dgv_List_Of_Items.RowTemplate.Height = 29;
            this.dgv_List_Of_Items.Size = new System.Drawing.Size(1317, 447);
            this.dgv_List_Of_Items.TabIndex = 5;
            // 
            // List_Of_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel1);
            this.Name = "List_Of_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Of_Items";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List_Of_Items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label lb_List_Of_Items;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dgv_List_Of_Items;
        private Label label1;
    }
}