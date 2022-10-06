
namespace MLPercussion
{
    partial class sku_gen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sku_gen));
            this.prod_slec = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.supp_loc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inv_loc = new System.Windows.Forms.ComboBox();
            this.generate = new System.Windows.Forms.Button();
            this.sku_disp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.print_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prod_slec
            // 
            this.prod_slec.FormattingEnabled = true;
            this.prod_slec.Items.AddRange(new object[] {
            "GanGan",
            "Iya-Ilu",
            "Iya-Ilu Bata",
            "Omele Bata",
            "Omele Gangan",
            "Saworo",
            "Gudugudu",
            "Shekere"});
            this.prod_slec.Location = new System.Drawing.Point(10, 24);
            this.prod_slec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prod_slec.Name = "prod_slec";
            this.prod_slec.Size = new System.Drawing.Size(133, 23);
            this.prod_slec.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 25);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 22, 0, 0, 0, 0);
            // 
            // supp_loc
            // 
            this.supp_loc.Location = new System.Drawing.Point(372, 25);
            this.supp_loc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supp_loc.Name = "supp_loc";
            this.supp_loc.PlaceholderText = "e.g Oyo";
            this.supp_loc.Size = new System.Drawing.Size(117, 23);
            this.supp_loc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Production Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory Location:";
            // 
            // inv_loc
            // 
            this.inv_loc.FormattingEnabled = true;
            this.inv_loc.Items.AddRange(new object[] {
            "UK",
            "NG"});
            this.inv_loc.Location = new System.Drawing.Point(498, 24);
            this.inv_loc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inv_loc.Name = "inv_loc";
            this.inv_loc.Size = new System.Drawing.Size(117, 23);
            this.inv_loc.TabIndex = 4;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(108, 113);
            this.generate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(192, 28);
            this.generate.TabIndex = 5;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // sku_disp
            // 
            this.sku_disp.Location = new System.Drawing.Point(186, 77);
            this.sku_disp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sku_disp.Name = "sku_disp";
            this.sku_disp.PlaceholderText = "SKU Number";
            this.sku_disp.ReadOnly = true;
            this.sku_disp.Size = new System.Drawing.Size(258, 23);
            this.sku_disp.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "SKU Number:";
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(306, 113);
            this.print_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(127, 28);
            this.print_button.TabIndex = 7;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // sku_gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 160);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.sku_disp);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.inv_loc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supp_loc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.prod_slec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sku_gen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SKU Generator";
            this.Load += new System.EventHandler(this.sku_gen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox prod_slec;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox supp_loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inv_loc;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox sku_disp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button print_button;
    }
}