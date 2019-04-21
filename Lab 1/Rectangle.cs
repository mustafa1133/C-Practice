using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Length { get; set; }

        private int area;

        public Rectangle(int w, int l)
        {
            Width=w;
            Length=l;

        }

        public Rectangle()
        {

        }



        public static Rectangle CreateRectangle (int width, int length)
        {
            Rectangle rec = new Rectangle(width,length);
            return rec;

        }


        public static void CalculateAndDisplayArea(Rectangle rec)
        {
            rec.area = rec.Width * rec.Length;

            Console.WriteLine($"the Area is {rec.area}");

        }

        public static void DescribeRectanlge(Rectangle rec)
        {
            Console.WriteLine($"The Width is {rec.Width} and the Length is {rec.Length}");
        }
    }
}
