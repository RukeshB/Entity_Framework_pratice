using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFramework
{
    class print4
    {
        private PrintDocument prn;
        private Font mfont;
        private string mtext = "";
       // private datalist data = new datalist();
        //private String datatoprint ;
        //private StringCollection datatoprint = new StringCollection();

        public print4(string StringValue = "", Font Fnt = null)
        {
            mtext=StringValue;
            mfont=Fnt;
        }

        public Font font
        {
            get
            {
                return mfont;
            }

            set
            {
                mfont = value;
            }
        }

        public String text
        {
            get
            {
                return mtext;
            }

            set
            {
                mtext = value;
            }
        }
    }

    class printer
    {
        private static PrintDocument prn;
        private static Font myfont;
        private static long row = 0;
        private static string text = "";
        private static datalist data = new datalist();

        static printer()
        {
            data = new datalist();
            myfont = new Font("Courier New", 8, FontStyle.Regular, GraphicsUnit.Point); // Default
            prn = new PrintDocument();
            row = 0;
            prn.PrintPage += Document_PrintPage;
        }

        public static void SetFont(string FontFamily, float emSize, FontStyle style)
        {
            myfont = new Font(FontFamily, emSize, style);
        }

        public static void print(String mytext)
        {
            data.Add(mytext, myfont);
        }

        public static void DoPrint()
        {
            prn.Print();
        }

        private static void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Near;
            int x = 25;
            
                foreach (print4 datas in data)
            {
                RectangleF recAtZero = new RectangleF(0, x, e.PageBounds.Width, e.PageBounds.Height);
                e.Graphics.DrawString(datas.text, datas.font, drawBrush, recAtZero, drawFormat);
                x = x + 25;
            }
        }
    }

    class datalist : CollectionBase
    {
        public print4 Add(string StringValue, Font Fnt)
        {

            var Printdata = new print4(StringValue, Fnt);
            InnerList.Add(Printdata);
            return Printdata;
        }
    }
}
