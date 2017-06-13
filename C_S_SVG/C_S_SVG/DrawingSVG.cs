using System.IO;
namespace Visualize_test
{
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
        public static void MakeLine(int x1, int y1, int x2, int y2, string color, StreamWriter writer)
        {
            writer.WriteLine("    <line x1=\"{0}\" y1=\"{1}\" x2=\"{2}\" y2=\"{3}\" stroke=\"{4}\" stroke-width=\"1\" />", x1, y1, x2, y2, color);
        }
        public static void MakeRectangle(int x, int y, int width, int height, StreamWriter writer)
        {
            writer.WriteLine("     <rect x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\" stroke=\"black\" stroke-width=\"1\" fill=\"none\" />", x, y, width, height);
        }
        public static void MakeCircle(int x, int y, int radius, StreamWriter writer)
        {
            writer.WriteLine("<circle cx =\"{0}\" cy=\"{1}\" r=\"{2}\" stroke=\"black\" stroke-width=\"1\" fill=\"none\" />", x, y, radius);
        }
    }

}
