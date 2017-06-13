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
            DrawingSVG.MakeLine(0, 0, 150, 150, writer);
            DrawingSVG.MakeRectangle(0, 0, 150, 150, writer);
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
    public class DrawingSVG
    {
        public static void Init(StreamWriter writer)
        {
            writer.WriteLine("<svg width=\"300px\" height=\"150px\">");
        }
        public static void End(StreamWriter writer)
        {
            writer.WriteLine("</svg>");
        }
        public static void MakeLine(int x1, int y1, int x2, int y2, StreamWriter writer)
        {
            writer.WriteLine("    <line x1=\"{0}\" y1=\"{1}\" x2=\"{2}\" y2=\"{3}\" stroke=\"black\" stroke-width=\"1\" />", x1, y1, x2, y2);
        }
        public static void MakeRectangle(int x, int y, int width, int height, StreamWriter writer)
        {
            writer.WriteLine("     <rect x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\" stroke=\"black\" stroke-width=\"1\" fill=\"none\" />", x, y, width, height);
        }
    }

}
