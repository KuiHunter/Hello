using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2, 4);
            Point3D p3d = new Point3D(1, 2, 3);
            Console.WriteLine(p.X+","+p.Y);
            var a = Console.ReadLine();
            Console.WriteLine(a);

            
        }
    }
    
    public class Point
    {
        public int X { get;}
        public int Y { get;}
        public Point(int x, int y)
        {
            (X, Y) = (x, y);
        }

    }

    public class Point3D : Point
    {
        public int z { get; set; }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
}
