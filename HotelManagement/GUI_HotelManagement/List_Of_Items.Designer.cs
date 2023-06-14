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
            this.lb_List_Of_Items = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_List_Of_Items);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 729);
            this.panel1.TabIndex = 1;
            // 
            // lb_List_Of_Items
            // 
            this.lb_List_Of_Items.AutoSize = true;
            this.lb_List_Of_Items.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_List_Of_Items.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_List_Of_Items.Location = new System.Drawing.Point(0, 0);
            this.lb_List_Of_Items.Name = "lb_List_Of_Items";
            this.lb_List_Of_Items.Size = new System.Drawing.Size(160, 33);
            this.lb_List_Of_Items.TabIndex = 1;
            this.lb_List_Of_Items.Text = "LIST OF ITEMS";
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
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label lb_List_Of_Items;
    }
}