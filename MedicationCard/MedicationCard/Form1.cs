using OfficeOpenXml; 
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace MedicationCard
{
    public partial class Form1 : Form
    {
        string excelPath = "";
        int currentRow = 2; 
        bool isPrintingInsidePage = false; 

        public Form1()
        {
            InitializeComponent();
           
            ExcelPackage.License.SetNonCommercialPersonal("Guma");
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        }

        
        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Files|*.xlsx" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    excelPath = ofd.FileName;
                   
                    currentRow = 2; 
                }
            }
        }

      private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(excelPath))
            {
                MessageBox.Show("الرجاء اختيار ملف الإكسل أولاً");
                return;
            }

            PrintDocument pd = new PrintDocument();
            
            pd.DefaultPageSettings.PaperSize = new PaperSize("A5", 583, 827);
            pd.DefaultPageSettings.Landscape = true;

            pd.PrintPage += new PrintPageEventHandler(OnPrintPage);

            string printerName = pd.PrinterSettings.PrinterName;

            DialogResult result = MessageBox.Show($"هل تريد الطباعة باستخدام الطابعة: {printerName}؟","تأكيد الطباعة",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                  //PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd };
                  //ppd.ShowDialog();
               pd.Print();
            }
        }
       

     

        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Millimeter; 

            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                var sheet = package.Workbook.Worksheets[0];
                int totalRows = sheet.Dimension.Rows;

                if (currentRow <= totalRows)
                {
                    if (!isPrintingInsidePage)
                    {
                   
                        DrawFrontPage(g, sheet, currentRow);

                      
                        isPrintingInsidePage = true;
                        e.HasMorePages = true;
                    }
                    else
                    {
                   
                        DrawInsidePage(g, sheet, currentRow);

                       
                        isPrintingInsidePage = false;
                        //currentRow++;

                       
                        e.HasMorePages = false;
                    }
                }
            }
        }

        private void DrawFrontPage(Graphics g, ExcelWorksheet sheet, int row)
        {
            Font fontBold = new Font("Arial", 12, FontStyle.Bold);
            Brush brush = Brushes.Black;

           
            string no = sheet.Cells[row, 1].Text;
            string name = sheet.Cells[row, 2].Text;      
            string memberId = sheet.Cells[row, 4].Text;  
            string age = sheet.Cells[row, 8].Text;       
            string phone = sheet.Cells[row, 13].Text;    
            //string notes = sheet.Cells[row, 17].Text;    

            g.DrawString(no, fontBold, brush, 65, 22);   
            g.DrawString(name, fontBold, brush, 15, 51);   
            g.DrawString(age, fontBold, brush, 30, 60);    
            g.DrawString(phone, fontBold, brush, 30, 75);  
            //g.DrawString(notes, fontBold, brush, 60, 97);  
            g.DrawString(memberId, fontBold, brush, 9, 117); 
        }

        private void DrawInsidePage(Graphics g, ExcelWorksheet sheet, int row)
        {
            Font fontMed = new Font("Arial", 10, FontStyle.Bold);

            
            string photoPath = sheet.Cells[row, 12].Text;
            if (File.Exists(photoPath))
            {
                using (Image img = Image.FromFile(photoPath))
                {
                   
                    g.DrawImage(img, 104, 15, 30, 40);
                }
            }

            
            float x = 135; 
            float y = 72;  
            float spacing = 6.2f; 

            for (int col = 20; col <= 24; col++)
            {
                string medicine = sheet.Cells[row, col].Text;
                if (!string.IsNullOrEmpty(medicine))
                {
                    g.DrawString(medicine, fontMed, Brushes.Black, x, y);
                    y += spacing; 
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(excelPath))
            {
                MessageBox.Show("الرجاء اختيار ملف الإكسل أولاً");
                return;
            }

            string searchId = txtMemberIdSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchId))
            {
                MessageBox.Show("الرجاء إدخال رقم العضوية للبحث");
                return;
            }

            //if (!System.Text.RegularExpressions.Regex.IsMatch(searchId, @"^\d{2}\*00$"))
            //{
            //    MessageBox.Show("تنبيه: رقم العضوية يجب أن يكون بالشكل (مثال: 00*10)");
            //    return;
            //}




            using (var package = new ExcelPackage(new FileInfo(excelPath)))
            {
                var sheet = package.Workbook.Worksheets[0];
                int totalRows = sheet.Dimension.Rows;

                bool found = false;
                for (int row = 2; row <= totalRows; row++)
                {
                    string memberId = sheet.Cells[row, 4].Text; 
                    if (memberId == searchId)
                    {
                        currentRow = row; 
                        found = true;

                      
                        TxtmemberId.Text = memberId;
                        Txtname.Text = sheet.Cells[row, 2].Text;   
                        Txtage.Text = sheet.Cells[row, 8].Text;    
                        Txtphone.Text = sheet.Cells[row, 13].Text; 
                        //Txtnotes.Text = sheet.Cells[row, 17].Text; 
                        string photoPath = sheet.Cells[row, 12].Text;
                        if (File.Exists(photoPath))
                        {
                            Pic.Image = Image.FromFile(photoPath);
                        }
                        else
                        {
                            Pic.Image = null;
                        }

                       
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show(" لم يتم العثور على رقم العضوية");
                }
            }
        }
    }
    }
