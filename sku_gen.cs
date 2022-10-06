using bpac;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;




namespace MLPercussion
{
    public partial class sku_gen : Form

    {
        public Dictionary<string, string> product = new Dictionary<string, string>();
        private const string TEMPLATE_DIRECTORY = @"C:\Users\soley\source\repos\MLPercussion\SKU.lbx"; // Template file path
        private const string TEMPLATE_SIMPLE = "SKU.lbx";    // Template file name
        public int num_copies;


        public sku_gen()
        {
            InitializeComponent();
            product.Add("Iya-Ilu", "IYL");
            product.Add("Iya-Ilu Bata", "IYB");
            product.Add("Omele Gangan", "OMG");
            product.Add("Omele Bata", "OMB");
            product.Add("Shekere", "SHK");
            product.Add("Saworo", "SWR");
            product.Add("GuduGudu", "GDG");
            product.Add("GanGan", "GNG");
            dateTimePicker1.CustomFormat = "MMMyy";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


        }

        private void button1_Click(object sender, EventArgs e)// Generate SKU Click
        {
            sku_disp.Text = $"{product[$"{prod_slec.Text}"]}-{dateTimePicker1.Text.ToUpper()}-{supp_loc.Text.Substring(0, 3).ToUpper()}-{inv_loc.Text.ToUpper()}";

            //The following code enables the sku to create a database to store the numbers
            string database = @"C:\Users\soley\source\repos\MLPercussion\sku_database.xlsx";
            // If directory does not exist, don't even try   
            //bool write_Data = false;
            if (File.Exists(database))
            {
                FileInfo fi = new FileInfo(database);
                using ExcelPackage excelPackage = new ExcelPackage(fi);
                var ws = excelPackage.Workbook.Worksheets[0];
                for (int i = 1; i < int.MaxValue; i++)
                {
                    if (ws.Cells[i, 1].Value is null)
                    {
                        ws.Cells[i, 1].Value = prod_slec.Text;
                        ws.Cells[i, 2].Value = dateTimePicker1.Text.ToUpper();
                        ws.Cells[i, 3].Value = supp_loc.Text.ToUpper();
                        ws.Cells[i, 4].Value = inv_loc.Text.ToUpper();
                        ws.Cells[i, 5].Value = sku_disp.Text;
                        ws.Cells[i, 6].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                        //ws.Cells["A1:E1"].Style.Font.Bold = true;
                        //excelPackage.SaveAs(fi);
                        break;
                    }
                    else
                    {

                    }
                    ; // Error thrown if file is already open
                }

                //excelPackage.SaveAs(fi); // Error thrown if file is already open
            }
            else
            {
                using ExcelPackage excelPackage = new ExcelPackage();
                //Set some properties of the Excel document
                excelPackage.Workbook.Properties.Author = "MLPercussion";
                excelPackage.Workbook.Properties.Title = "SKU Database";
                excelPackage.Workbook.Properties.Subject = "sku_export data";
                excelPackage.Workbook.Properties.Created = DateTime.Now;

                //Create the WorkSheet
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");

                //Append the data into the worksheet


                //Save your file
                FileInfo fi = new FileInfo(database);
                excelPackage.SaveAs(fi);

            }

        }

        private void print_button_Click(object sender, EventArgs e)
        {
            string templatePath = TEMPLATE_DIRECTORY;

            bpac.Document doc = new Document();

            if (doc.Open(templatePath) != false)
            {
                //doc.Open(templatePath + TEMPLATE_SIMPLE);
                doc.GetObject("objBarcode").Text = sku_disp.Text;

                // Enable the print dialog to allow the user select the number of pages to print
                PrintDialog pDialog = new PrintDialog
                {
                    AllowCurrentPage = false,
                    AllowPrintToFile = false,
                    AllowSelection = false,
                    AllowSomePages = false
                };
                pDialog.ShowDialog();

                // doc.SetMediaById(doc.Printer.GetMediaId(), true);
                doc.StartPrint("", PrintOptionConstants.bpoDefault);
                doc.PrintOut(pDialog.PrinterSettings.Copies, PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
            }
            else
            {
                MessageBox.Show("Open() Error: " + doc.ErrorCode);
            }
        }

        private void sku_gen_Load(object sender, EventArgs e)
        {
            //this.cmbTemplate.SelectedIndex = 0;
        }
    }
}
