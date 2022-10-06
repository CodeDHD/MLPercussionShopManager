using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using MOIE = Microsoft.Office.Interop.Excel;

namespace MLPercussion
{
    public partial class Sales_Log : Form
    {
        public Dictionary<string, string> profit_Table = new Dictionary<string, string>();
        DataTable dt = new DataTable();
        BindingSource SBind = new BindingSource();
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\soley\source\repos\MLPercussion\Database1.mdf; Integrated Security = True";
        public Sales_Log()
        {
            InitializeComponent();
            profit_Table.Add("IYL", "200");
            profit_Table.Add("IYB", "300");
            profit_Table.Add("OMG", "67.5");
            profit_Table.Add("OMB", "95");
            profit_Table.Add("SHK", "30");
            profit_Table.Add("SWR", "40");
            profit_Table.Add("GDG", "120");
            profit_Table.Add("GNG", "67.5");
            dateTimePicker1.CustomFormat = "ddMMMyy";

            SBind.DataSource = dt;
            dataGridView1.DataSource = SBind;
            Pull_data2();
        }
        private void Pull_data2()
        {
            using (var da = new SqlDataAdapter("SELECT * FROM [Table2]", @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\soley\source\repos\MLPercussion\Database1.mdf; Integrated Security = True"))
            {
                da.Fill(dt);
            }
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
        public void MeExit()
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {

                this.Close();
            }
        }
        private void Upload_data()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string clr_data = "TRUNCATE TABLE [Table2]";

                //connection.Open();
                SqlCommand del = new SqlCommand(clr_data, connection);
                del.Connection.Open();
                del.ExecuteNonQuery();
                del.Connection.Close();
                connection.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    foreach (DataColumn c in dt.Columns)
                    {

                        bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                    }



                    bulkCopy.DestinationTableName = "[Table2]";
                    try
                    {
                        bulkCopy.WriteToServer(dt);
                        connection.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        private void Targ_profit_calc()
        {
            try
            {
                profit.Text = profit_Table[$"{SKU_Num.Text.ToUpper().Substring(0, 3)}"];
            }
            catch
            {
                MessageBox.Show("Product in SKU number not recognised");
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
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SKU_Num.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("SKU Number");
                Store.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Store");
                pay_Out.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Pay Out").ToString();
                Shipping_cost.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Shipping Cost").ToString();
                zip_Code.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("ZIP Code");
                Country.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Country");
                sale_date.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Sale Date");
                Tracking_Num.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Tracking Number");
                profit.Text = dt.Rows[dataGridView1.CurrentCell.RowIndex].Field<string>("Profit Target").ToString();


            }
            catch
            {
                MessageBox.Show("No data at selected position");
            }

        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                Targ_profit_calc();
                float profit_val = 0;

                if (String.IsNullOrEmpty(pay_Out.Text) & String.IsNullOrEmpty(Shipping_cost.Text))
                {
                    profit_val = 0;
                }
                else
                {
                    profit_val = float.Parse(pay_Out.Text) - float.Parse(Shipping_cost.Text);
                }
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["SKU Number"] = SKU_Num.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Store"] = Store.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Pay Out"] = pay_Out.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Shipping Cost"] = Shipping_cost.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Zip Code"] = zip_Code.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Country"] = Country.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Sale Date"] = sale_date.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Tracking Number"] = Tracking_Num.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Profit Target"] = profit.Text;
                dt.Rows[dataGridView1.CurrentCell.RowIndex]["Profit"] = profit_val.ToString();



                Upload_data();

            }
            catch
            {


            }
        }



        private void add_bttn_Click(object sender, EventArgs e)
        {
            Targ_profit_calc();
            float profit_val = 0;
           
            if (String.IsNullOrEmpty(pay_Out.Text) & String.IsNullOrEmpty(Shipping_cost.Text))
            {
                profit_val = 0;
            }
            else
            {
                profit_val = float.Parse(pay_Out.Text) - float.Parse(Shipping_cost.Text);
            }

            dt.Rows.Add(SKU_Num.Text, Store.Text, pay_Out.Text, Shipping_cost.Text, zip_Code.Text, Country.Text, dateTimePicker1.Text, Tracking_Num.Text, profit.Text, profit_val.ToString());
            Upload_data();
            Update_inventory();
        }
        private void Update_inventory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string clr_data = $"DELETE TOP(1) FROM [TABLE] WHERE  CONVERT(VARCHAR, SKU_Number )= '{SKU_Num.Text}'";

                //connection.Open();
                SqlCommand del = new SqlCommand(clr_data, connection);
                del.Connection.Open();
                del.ExecuteNonQuery();
                del.Connection.Close();
              
            }
        }


        private void del_bttn_Click(object sender, EventArgs e)
        {
            iDelete();
            Upload_data();
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            iSave();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            MeExit();
        }

        private void reset_bttn_Click_1(object sender, EventArgs e)
        {
            SKU_Num.Text = string.Empty;
            Store.Text = string.Empty;
            pay_Out.Text = string.Empty;
            Shipping_cost.Text = string.Empty;
            zip_Code.Text = string.Empty;
            Country.Text = string.Empty;
            //sale_date.Text = string.Empty;
            Tracking_Num.Text = string.Empty;
            //Targ_proft.Text = string.Empty;
            profit.Text = string.Empty;
        }

    }
}

