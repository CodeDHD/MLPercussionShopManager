using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using MOIE = Microsoft.Office.Interop.Excel;


namespace MLPercussion
{

    public partial class inventorymanager : Form
    {
        public Dictionary<string, string> product = new Dictionary<string, string>();
        DataTable dt = new DataTable();
        BindingSource SBind = new BindingSource();
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\soley\source\repos\MLPercussion\Database1.mdf; Integrated Security = True";
        public inventorymanager()
        {
            InitializeComponent();
            //PullData();// Pull existing data
            Pull_data2();
            product.Add("IYL", "Iya-Ilu");
            product.Add("IYB", "Iya-Ilu Bata");
            product.Add("OMG", "Omele Gangan");
            product.Add("OMB", "Omele Bata");
            product.Add("SHK", "Shekere");
            product.Add("SWR", "Saworo");
            product.Add("GDG", "Gudugudu");

            //dt.Columns.AddRange(new DataColumn[5] { new DataColumn("SKU Number", typeof(string)),
                    //new DataColumn("Product", typeof(string)),
                    //new DataColumn("Manufacturer",typeof(string)),
                    //new DataColumn("Date Logged",typeof(string)),
                    //new DataColumn ("Shipping_Location", typeof(string))

            //});


            SBind.DataSource = dt;
            dataGridView1.DataSource = SBind;

        }


        private void exit_bttn_Click(object sender, EventArgs e)
        {
            MeExit();
        }
        public void MeExit()
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeExit();

        }

        private void SkuRead()
        {
            try
            {
                prod.Text = product[$"{SKU.Text.ToUpper().Substring(0, 3)}"];
                manuf.Text = $"{SKU.Text.Substring(10, 3)}";
                dte_lgged.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                product_count.Text = dt.Select($"Product='{prod.Text}'").Length.ToString();

                //validationChecker(SKU.Text);// Checks if the input is valid
                dt.Rows.Add(SKU.Text, prod.Text, manuf.Text, dte_lgged.Text, SKU.Text.Substring(14, 2));
                quantityCheck();
                Upload_data();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("The input doesnt not follow the required format", "Return to Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.SyntaxErrorException)
            {
                MessageBox.Show("Syntax Error", "Return to Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                MessageBox.Show("Incorrect SKU Product Key", "Return to Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            SkuRead();
            product_count.Text = dt.Select($"Product='{prod.Text}'").Length.ToString();
            
            //quant_uk.Text = dt.Select($"Shipping Location='UK'").Length.ToString();


        }

        private void del_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                iDelete();
                Upload_data();

            }
            catch
            {
                MessageBox.Show("There is nothing to delete", "Return to Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void iDelete()
        {
            DialogResult iDel;
            iDel = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iDel == DialogResult.Yes)
            {
                try
                {

                    var dr = dt.Rows[dataGridView1.CurrentCell.RowIndex];
                    List<DataRow> toDelete = new List<DataRow>();
                    toDelete.Add(dr);
                    dt.Rows.Remove(dr);
                    product_count.Text = dt.Select($"Product='{prod.Text}'").Length.ToString();
                    quantityCheck();
                    
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("There is nothing to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Delete one data point at a time", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }





            // dt.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iDelete();
        }
        private void iSave()
        {
            MOIE.Application app = new MOIE.Application();
            MOIE.Workbook workbook = app.Workbooks.Add(Type.Missing);
            MOIE.Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Worksheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported From Data Grid View";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            iSave();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iSave();
        }

        private void SKU_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void scan_mode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reset_bttn_Click(object sender, EventArgs e)
        {
            SKU.Text = string.Empty;
            prod.Text = string.Empty;
            manuf.Text = string.Empty;
            dte_lgged.Text = string.Empty;
            product_count.Text = string.Empty;
            quant_ng.Text = string.Empty;
            quant_uk.Text = string.Empty;
            var_qty.Text = string.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SKU.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("SKU_Number");
                prod.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Product");
                manuf.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Manufacturer");
                dte_lgged.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Date Logged");
                product_count.Text = dt.Select($"Product='{prod.Text}'").Length.ToString();
                quantityCheck();
            }
            catch
            {
                MessageBox.Show("No data at selected position");
            }
           
        }

        private void validationChecker(string SKU_num)
        {
            while (SKU_num.Length != 16)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void quantityCheck()
        {
            quant_uk.Text = dt.Select($"Shipping_Location='UK' AND Manufacturer='{SKU.Text.Substring(10, 3)}' AND Product='{prod.Text}'").Length.ToString();
            quant_ng.Text = dt.Select($"Shipping_Location='NG' AND Manufacturer='{SKU.Text.Substring(10, 3)}' AND Product='{prod.Text}'").Length.ToString();
            var_qty.Text = dt.Select($"Manufacturer='{SKU.Text.Substring(10, 3)}'AND Product='{prod.Text}'").Length.ToString();
        }
        private void Upload_data()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                string clr_data = "TRUNCATE TABLE [Table]";
                
                //connection.Open();
                SqlCommand del = new SqlCommand(clr_data, connection);
                del.Connection.Open();
                del.ExecuteNonQuery();
                del.Connection.Close();
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    foreach(DataColumn c in dt.Columns)
                    {
                        //bulkCopy.ColumnMappings.Clear();
                        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                    }



                    bulkCopy.DestinationTableName = "[Table]";
                    try
                    {
                        bulkCopy.WriteToServer(dt);
                        connection.Dispose();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
       
        private void Pull_data2()
        {
            using (var da = new SqlDataAdapter("SELECT * FROM [Table]", @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\soley\source\repos\MLPercussion\Database1.mdf; Integrated Security = True"))
            {
                da.Fill(dt);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["SKU_Number"] = SKU.Text;
                prod.Text = product[$"{SKU.Text.ToUpper().Substring(0, 3)}"];
                manuf.Text = $"{SKU.Text.Substring(10, 3)}";
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Product"] = prod.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Manufacturer"]= manuf.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Shipping_Location"] = SKU.Text.Substring(14, 2);
                if (dte_lgged.Text=="")
                { 
                    dte_lgged.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                    dt.Rows[dataGridView1.CurrentCell.RowIndex]["Date Logged"] = dte_lgged.Text;
                }
                
                product_count.Text = dt.Select($"Product='{prod.Text}'").Length.ToString();
                quantityCheck();
                Upload_data();

            }
            catch
            {


            }
        }
    }
}


