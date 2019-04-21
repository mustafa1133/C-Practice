using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();


            Rectangle smallRectangle=Rectangle.CreateRectangle(4,5);
            Rectangle.DescribeRectanlge(smallRectangle);
            Rectangle.CalculateAndDisplayArea(smallRectangle);
        }
    }
}
