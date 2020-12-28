using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFramework
{
    class print3
    {
        private PrintDocument prn;
        private static Font myfont;
        private long row=0;
        //private String datatoprint ;
        private StringCollection datatoprint = new StringCollection();
        void Printer()
        {
            
            myfont = new Font("Courier New", 8, FontStyle.Regular, GraphicsUnit.Point); // Default
            prn = new PrintDocument();
            row = 0;
            prn.PrintPage += Document_PrintPage;
        }

        public void NewPrint()
        {
            //PrintDatalist = new PrintDatalist();
            myfont = new Font("Courier New", 8, FontStyle.Regular, GraphicsUnit.Point); // Default
            prn = new PrintDocument();
            row = 0;
            var PS1 = new PageSettings();
            PS1.PaperSize = prn.PrinterSettings.PaperSizes.Cast<PaperSize>().FirstOrDefault();
            PS1.Margins.Left = 0;
            PS1.Margins.Right = 0;
            PS1.Margins.Top = 0;
            PS1.Margins.Bottom = 0;
            prn.DefaultPageSettings = PS1;
            prn.PrintPage += Document_PrintPage;
        }

        public void print(String data)
        {
            datatoprint.Add(data);
        }

        public void SetFont(string FontFamily, float emSize, FontStyle style)
        {
            myfont = new Font(FontFamily, emSize, style);
        }

        public void DoPrint()
        {
            prn.Print();
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            int x = 25;
            foreach (string data in datatoprint)
            {
                RectangleF recAtZero = new RectangleF(0, x, e.PageBounds.Width, e.PageBounds.Height);
                e.Graphics.DrawString(data, myfont, drawBrush, recAtZero, drawFormat);
                row++;
                x = x + 25;
            }
        }
    }
}
