using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Polygon
    {
        /// <summary>
        /// 正多邊形的數量
        /// </summary>
        public int Side { get; set; }
        /// <summary>
        /// 正多邊形的邊長
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// 正多邊形建構式
        /// </summary>
        /// <param name="side">數量</param>
        /// <param name="length">邊長</param>
        public Polygon(int side, double length)
        {
            Side = side;
            Length = length;
        }
        /// <summary>
        /// 計算多邊形的周長
        /// </summary>
        /// <returns>周長</returns>
        public double GetPerimeter()
        {
            return Side * Length;
        }
        /// <summary>
        /// 計算多邊形的面積
        /// </summary>
        /// <returns>面積</returns>
        public abstract double GetArea();
    }

    public class Polygon3 : Polygon
    {
        public Polygon3(double length) : base(3, length)
        { }
        public override double GetArea()
        {
            return Length * Length * Math.Sqrt(3) / 4;
        }
    }

    public class Polygon4 : Polygon
    {
        public Polygon4(double length) : base(4, length)
        { }
        public override double GetArea()
        {
            return Length * Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fooSide3 = new Polygon3(8);
            Console.WriteLine($"正 {fooSide3.Side} 多邊形之週長為 {fooSide3.GetPerimeter()}");
            Console.WriteLine($"正 {fooSide3.Side} 多邊形之面積為 {fooSide3.GetArea()}");

            var fooSide4 = new Polygon4(8);
            Console.WriteLine($"正 {fooSide4.Side} 多邊形之週長為 {fooSide4.GetPerimeter()}");
            Console.WriteLine($"正 {fooSide4.Side} 多邊形之面積為 {fooSide4.GetArea()}");

            Console.WriteLine("Press any key for continuing...");
            Console.ReadKey();
        }
    }
}
