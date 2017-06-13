using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Visualize_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = MakeNewFile();
            var writer = new StreamWriter(filename);
            DrawingSVG.Init(writer);
            DrawingSVG.MakeLine(0, 0, 150, 150, "red",writer);
            DrawingSVG.MakeRectangle(0, 0, 150, 150, writer);
            DrawingSVG.MakeCircle(50, 50, 25, writer);
            DrawingSVG.End(writer);
            writer.Close();
        }
        static string MakeNewFile()
        {
            string filename = "NewFile.html";
            string stCurrentDir = System.IO.Directory.GetCurrentDirectory();
            int i = 0;
            for (i = 1; File.Exists(stCurrentDir + "\\" + filename); i++)
            {
                filename = "NewFile" + i.ToString() + ".html";
            }
            return filename;
        }

    }

}
