using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    public interface IPolygon
    {
        /// <summary>
        /// 正多邊形的數量
        /// </summary>
        int Side { get; set; }
        /// <summary>
        /// 正多邊形的邊長
        /// </summary>
        double Length { get; set; }
        /// <summary>
        /// 計算多邊形的周長
        /// </summary>
        /// <returns>周長</returns>
        double GetPerimeter();
        /// <summary>
        /// 計算多邊形的面積
        /// </summary>
        /// <returns>面積</returns>
        double GetArea();
    }

    public class Polygon3 : IPolygon
    {
        public int Side { get; set; }
        public double Length { get; set; }
        public Polygon3(double length)
        {
            Side = 3;
            Length = length;
        }
        public double GetPerimeter()
        { return Side * Length; }
        public double GetArea()
        { return Length * Length * Math.Sqrt(3) / 4; }
    }

    public class Polygon4 : IPolygon
    {
        public int Side { get; set; }
        public double Length { get; set; }
        public Polygon4(double length)
        {
            Side = 4;
            Length = length;
        }
        public double GetPerimeter()
        { return Side * Length; }
        public double GetArea()
        { return Length * Length; }
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
