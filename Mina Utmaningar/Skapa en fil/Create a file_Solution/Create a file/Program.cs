using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Create_a_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\elev\Desktop\temp1.txt";

            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
