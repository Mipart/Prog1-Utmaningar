using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace PngToExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap image = new Bitmap(@"C:\Users\elev\Google Drive\_Skola\Programering 1\Mina Utmaningar\PngToPixelArt\PngToExcel\PngToExcel\Excel\img.png");
            int imgWidth = image.Width;
            int imgHeight = image.Height;


            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\elev\Google Drive\_Skola\Programering 1\Mina Utmaningar\PngToPixelArt\PngToExcel\PngToExcel\Excel\board.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            for (int i = 1; i < imgWidth; i++)
            {
                Console.WriteLine(i +" av " + imgWidth);
                for (int j = 1; j < imgHeight; j++)
                {
                    xlRange.Cells[i, j].Interior.Color = image.GetPixel(i, j);
                }
                Console.Clear();
            }

            xlWorksheet.SaveAs("board.xlsx");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
