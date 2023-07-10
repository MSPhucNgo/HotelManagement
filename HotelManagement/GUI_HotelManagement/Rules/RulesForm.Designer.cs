namespace GUI_HotelManagement
{
    partial class RulesForm
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
            this.Rule_ComboBox = new System.Windows.Forms.ComboBox();
            this.Rules_DataGrid = new System.Windows.Forms.DataGridView();
            this.Add_Button = new System.Windows.Forms.Button();
            this.rulesId_ComboBox = new System.Windows.Forms.ComboBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Rules_DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rule_ComboBox
            // 
            this.Rule_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rule_ComboBox.FormattingEnabled = true;
            this.Rule_ComboBox.Items.AddRange(new object[] {
            "All",
            "Quy định chìa khóa",
            "Quy định khách sạn"});
            this.Rule_ComboBox.Location = new System.Drawing.Point(36, 69);
            this.Rule_ComboBox.Name = "Rule_ComboBox";
            this.Rule_ComboBox.Size = new System.Drawing.Size(425, 28);
            this.Rule_ComboBox.TabIndex = 0;
            this.Rule_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Rule_ComboBox_SelectedIndexChanged_1);
            // 
            // Rules_DataGrid
            // 
            this.Rules_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rules_DataGrid.Location = new System.Drawing.Point(38, 307);
            this.Rules_DataGrid.Name = "Rules_DataGrid";
            this.Rules_DataGrid.RowHeadersWidth = 51;
            this.Rules_DataGrid.RowTemplate.Height = 24;
            this.Rules_DataGrid.Size = new System.Drawing.Size(1032, 278);
            this.Rules_DataGrid.TabIndex = 2;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.White;
            this.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Button.FlatAppearance.BorderSize = 2;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.Add_Button.Location = new System.Drawing.Point(36, 110);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(193, 43);
            this.Add_Button.TabIndex = 3;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // rulesId_ComboBox
            // 
            this.rulesId_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rulesId_ComboBox.FormattingEnabled = true;
            this.rulesId_ComboBox.Location = new System.Drawing.Point(34, 90);
            this.rulesId_ComboBox.Name = "rulesId_ComboBox";
            this.rulesId_ComboBox.Size = new System.Drawing.Size(247, 28);
            this.rulesId_ComboBox.TabIndex = 6;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.White;
            this.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Button.FlatAppearance.BorderSize = 2;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.Delete_Button.Location = new System.Drawing.Point(318, 114);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(144, 51);
            this.Delete_Button.TabIndex = 4;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.Color.White;
            this.Update_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_Button.FlatAppearance.BorderSize = 2;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(138)))));
            this.Update_Button.Location = new System.Drawing.Point(318, 45);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(144, 51);
            this.Update_Button.TabIndex = 5;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rulesId_ComboBox);
            this.panel1.Controls.Add(this.Update_Button);
            this.panel1.Controls.Add(this.Delete_Button);
            this.panel1.Location = new System.Drawing.Point(578, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 204);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selected Rule:";
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackColor = System.Drawing.Color.White;
            this.Refresh_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_Button.FlatAppearance.BorderSize = 2;
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refresh_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.Refresh_Button.Location = new System.Drawing.Point(266, 110);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(195, 43);
            this.Refresh_Button.TabIndex = 9;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = false;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Refresh_Button);
            this.panel2.Controls.Add(this.Add_Button);
            this.panel2.Controls.Add(this.Rule_ComboBox);
            this.panel2.Location = new System.Drawing.Point(38, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 204);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Types of Rule:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 621);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1109, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 621);
            this.panel4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.label2.Location = new System.Drawing.Point(480, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "List of Rules";
            // 
            // RulesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rules_DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quy định khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.Rules_DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Rule_ComboBox;
        private DataGridView Rules_DataGrid;
        private Button Add_Button;
        private ComboBox rulesId_ComboBox;
        private Button Delete_Button;
        private Button Update_Button;
        private Panel panel1;
        private Button Refresh_Button;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}

