namespace MLPercussion
{
    partial class inventorymanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventorymanager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.SKU = new System.Windows.Forms.TextBox();
            this.product_count = new System.Windows.Forms.TextBox();
            this.var_qty = new System.Windows.Forms.TextBox();
            this.quant_ng = new System.Windows.Forms.TextBox();
            this.quant_uk = new System.Windows.Forms.TextBox();
            this.prod = new System.Windows.Forms.TextBox();
            this.manuf = new System.Windows.Forms.TextBox();
            this.dte_lgged = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.save_bttn = new System.Windows.Forms.Button();
            this.del_bttn = new System.Windows.Forms.Button();
            this.prnt_bttn = new System.Windows.Forms.Button();
            this.reset_bttn = new System.Windows.Forms.Button();
            this.add_bttn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.sku_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.SKU);
            this.panel1.Controls.Add(this.product_count);
            this.panel1.Controls.Add(this.var_qty);
            this.panel1.Controls.Add(this.quant_ng);
            this.panel1.Controls.Add(this.quant_uk);
            this.panel1.Controls.Add(this.prod);
            this.panel1.Controls.Add(this.manuf);
            this.panel1.Controls.Add(this.dte_lgged);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.exit_bttn);
            this.panel1.Controls.Add(this.save_bttn);
            this.panel1.Controls.Add(this.del_bttn);
            this.panel1.Controls.Add(this.prnt_bttn);
            this.panel1.Controls.Add(this.reset_bttn);
            this.panel1.Controls.Add(this.add_bttn);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 478);
            this.panel1.TabIndex = 0;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(22, 184);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 9;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // SKU
            // 
            this.SKU.Location = new System.Drawing.Point(112, 44);
            this.SKU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SKU.Name = "SKU";
            this.SKU.Size = new System.Drawing.Size(110, 23);
            this.SKU.TabIndex = 1;
            this.SKU.TextChanged += new System.EventHandler(this.SKU_TextChanged_1);
            // 
            // product_count
            // 
            this.product_count.Location = new System.Drawing.Point(812, 93);
            this.product_count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product_count.Name = "product_count";
            this.product_count.Size = new System.Drawing.Size(110, 23);
            this.product_count.TabIndex = 8;
            // 
            // var_qty
            // 
            this.var_qty.Location = new System.Drawing.Point(812, 44);
            this.var_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.var_qty.Name = "var_qty";
            this.var_qty.Size = new System.Drawing.Size(110, 23);
            this.var_qty.TabIndex = 7;
            // 
            // quant_ng
            // 
            this.quant_ng.Location = new System.Drawing.Point(600, 93);
            this.quant_ng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quant_ng.Name = "quant_ng";
            this.quant_ng.Size = new System.Drawing.Size(110, 23);
            this.quant_ng.TabIndex = 6;
            // 
            // quant_uk
            // 
            this.quant_uk.Location = new System.Drawing.Point(579, 44);
            this.quant_uk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quant_uk.Name = "quant_uk";
            this.quant_uk.Size = new System.Drawing.Size(110, 23);
            this.quant_uk.TabIndex = 5;
            // 
            // prod
            // 
            this.prod.Location = new System.Drawing.Point(89, 90);
            this.prod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(110, 23);
            this.prod.TabIndex = 2;
            // 
            // manuf
            // 
            this.manuf.Location = new System.Drawing.Point(347, 44);
            this.manuf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manuf.Name = "manuf";
            this.manuf.Size = new System.Drawing.Size(110, 23);
            this.manuf.TabIndex = 3;
            // 
            // dte_lgged
            // 
            this.dte_lgged.Location = new System.Drawing.Point(347, 95);
            this.dte_lgged.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dte_lgged.Name = "dte_lgged";
            this.dte_lgged.Size = new System.Drawing.Size(110, 23);
            this.dte_lgged.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(723, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Variation Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantity(NG)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity(UK)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Logged";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKU Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(821, 258);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // exit_bttn
            // 
            this.exit_bttn.Location = new System.Drawing.Point(848, 429);
            this.exit_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(82, 36);
            this.exit_bttn.TabIndex = 16;
            this.exit_bttn.Text = "Exit";
            this.exit_bttn.UseVisualStyleBackColor = true;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            // 
            // save_bttn
            // 
            this.save_bttn.Location = new System.Drawing.Point(848, 386);
            this.save_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(82, 36);
            this.save_bttn.TabIndex = 15;
            this.save_bttn.Text = "Save";
            this.save_bttn.UseVisualStyleBackColor = true;
            this.save_bttn.Click += new System.EventHandler(this.save_bttn_Click);
            // 
            // del_bttn
            // 
            this.del_bttn.Location = new System.Drawing.Point(848, 342);
            this.del_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_bttn.Name = "del_bttn";
            this.del_bttn.Size = new System.Drawing.Size(82, 36);
            this.del_bttn.TabIndex = 14;
            this.del_bttn.Text = "Delete";
            this.del_bttn.UseVisualStyleBackColor = true;
            this.del_bttn.Click += new System.EventHandler(this.del_bttn_Click);
            // 
            // prnt_bttn
            // 
            this.prnt_bttn.Location = new System.Drawing.Point(848, 298);
            this.prnt_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prnt_bttn.Name = "prnt_bttn";
            this.prnt_bttn.Size = new System.Drawing.Size(82, 36);
            this.prnt_bttn.TabIndex = 13;
            this.prnt_bttn.Text = "Print";
            this.prnt_bttn.UseVisualStyleBackColor = true;
            // 
            // reset_bttn
            // 
            this.reset_bttn.Location = new System.Drawing.Point(848, 255);
            this.reset_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset_bttn.Name = "reset_bttn";
            this.reset_bttn.Size = new System.Drawing.Size(82, 36);
            this.reset_bttn.TabIndex = 12;
            this.reset_bttn.Text = "Reset";
            this.reset_bttn.UseVisualStyleBackColor = true;
            this.reset_bttn.Click += new System.EventHandler(this.reset_bttn_Click);
            // 
            // add_bttn
            // 
            this.add_bttn.Location = new System.Drawing.Point(848, 212);
            this.add_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(82, 36);
            this.add_bttn.TabIndex = 11;
            this.add_bttn.Text = "Add";
            this.add_bttn.UseVisualStyleBackColor = true;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flieToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flieToolStripMenuItem
            // 
            this.flieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.flieToolStripMenuItem.Name = "flieToolStripMenuItem";
            this.flieToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.flieToolStripMenuItem.Text = "Flie";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // sku_num
            // 
            this.sku_num.HeaderText = "SKU Number";
            this.sku_num.MinimumWidth = 6;
            this.sku_num.Name = "sku_num";
            this.sku_num.Width = 125;
            // 
            // inventorymanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 478);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "inventorymanager";
            this.Text = "Inventory Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.Button del_bttn;
        private System.Windows.Forms.Button prnt_bttn;
        private System.Windows.Forms.Button reset_bttn;
        private System.Windows.Forms.TextBox product_count;
        private System.Windows.Forms.TextBox var_qty;
        private System.Windows.Forms.TextBox quant_ng;
        private System.Windows.Forms.TextBox quant_uk;
        private System.Windows.Forms.TextBox prod;
        private System.Windows.Forms.TextBox manuf;
        private System.Windows.Forms.TextBox dte_lgged;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button add_bttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku_num;
        private System.Windows.Forms.TextBox SKU;
        private System.Windows.Forms.Button update;
    }
}