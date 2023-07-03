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
            Rule_ComboBox = new ComboBox();
            Rules_DataGrid = new DataGridView();
            button2 = new Button();
            rulesId_ComboBox = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button6 = new Button();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Rules_DataGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Rule_ComboBox
            // 
            Rule_ComboBox.Cursor = Cursors.Hand;
            Rule_ComboBox.FormattingEnabled = true;
            Rule_ComboBox.Items.AddRange(new object[] { "All", "Quy định chìa khóa", "Quy định khách sạn" });
            Rule_ComboBox.Location = new Point(36, 69);
            Rule_ComboBox.Name = "Rule_ComboBox";
            Rule_ComboBox.Size = new Size(425, 23);
            Rule_ComboBox.TabIndex = 0;
            Rule_ComboBox.SelectedIndexChanged += Rule_ComboBox_SelectedIndexChanged;
            // 
            // Rules_DataGrid
            // 
            Rules_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Rules_DataGrid.Location = new Point(38, 307);
            Rules_DataGrid.Name = "Rules_DataGrid";
            Rules_DataGrid.RowHeadersWidth = 51;
            Rules_DataGrid.RowTemplate.Height = 24;
            Rules_DataGrid.Size = new Size(1032, 278);
            Rules_DataGrid.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 193, 138);
            button2.Location = new Point(36, 110);
            button2.Name = "button2";
            button2.Size = new Size(193, 43);
            button2.TabIndex = 3;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // rulesId_ComboBox
            // 
            rulesId_ComboBox.Cursor = Cursors.Hand;
            rulesId_ComboBox.FormattingEnabled = true;
            rulesId_ComboBox.Location = new Point(34, 90);
            rulesId_ComboBox.Name = "rulesId_ComboBox";
            rulesId_ComboBox.Size = new Size(247, 23);
            rulesId_ComboBox.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(239, 59, 44);
            button3.Location = new Point(318, 114);
            button3.Name = "button3";
            button3.Size = new Size(144, 51);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 193, 138);
            button4.Location = new Point(318, 45);
            button4.Name = "button4";
            button4.Size = new Size(144, 51);
            button4.TabIndex = 5;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 246, 252);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rulesId_ComboBox);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(578, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 204);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 61);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 17;
            label1.Text = "Selected Rule:";
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(8, 48, 107);
            button6.Location = new Point(266, 110);
            button6.Name = "button6";
            button6.Size = new Size(195, 43);
            button6.TabIndex = 9;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 246, 252);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(Rule_ComboBox);
            panel2.Location = new Point(38, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 204);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 39);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 16;
            label4.Text = "Types of Rule:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(8, 48, 107);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 621);
            panel3.Name = "panel3";
            panel3.Size = new Size(1119, 10);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(8, 48, 107);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1109, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 621);
            panel4.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(8, 48, 107);
            label2.Location = new Point(480, 263);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 17;
            label2.Text = "List of Rules";
            // 
            // RulesForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1119, 631);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Rules_DataGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RulesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quy định khách sạn";
            ((System.ComponentModel.ISupportInitialize)Rules_DataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Rule_ComboBox;
        private DataGridView Rules_DataGrid;
        private Button button2;
        private ComboBox rulesId_ComboBox;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Button button6;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}

