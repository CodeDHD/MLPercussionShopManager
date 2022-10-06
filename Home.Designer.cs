
namespace MLPercussion
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sale_logbttn = new System.Windows.Forms.Button();
            this.inv_Manager = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sku = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.sale_logbttn);
            this.panel1.Controls.Add(this.inv_Manager);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.sku);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 366);
            this.panel1.TabIndex = 0;
            // 
            // sale_logbttn
            // 
            this.sale_logbttn.Location = new System.Drawing.Point(127, 282);
            this.sale_logbttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sale_logbttn.Name = "sale_logbttn";
            this.sale_logbttn.Size = new System.Drawing.Size(102, 27);
            this.sale_logbttn.TabIndex = 3;
            this.sale_logbttn.Text = "Log Sale";
            this.sale_logbttn.UseVisualStyleBackColor = true;
            this.sale_logbttn.Click += new System.EventHandler(this.sale_logbttn_Click);
            // 
            // inv_Manager
            // 
            this.inv_Manager.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inv_Manager.Location = new System.Drawing.Point(127, 234);
            this.inv_Manager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inv_Manager.Name = "inv_Manager";
            this.inv_Manager.Size = new System.Drawing.Size(102, 32);
            this.inv_Manager.TabIndex = 2;
            this.inv_Manager.Text = "Inventory Manager";
            this.inv_Manager.UseVisualStyleBackColor = true;
            this.inv_Manager.Click += new System.EventHandler(this.inv_Manager_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(112, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 132);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // sku
            // 
            this.sku.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sku.Location = new System.Drawing.Point(127, 185);
            this.sku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(102, 32);
            this.sku.TabIndex = 1;
            this.sku.Text = "SKU Generator";
            this.sku.UseVisualStyleBackColor = true;
            this.sku.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLPercussion";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sku;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button inv_Manager;
        private System.Windows.Forms.Button sale_logbttn;
    }
}

