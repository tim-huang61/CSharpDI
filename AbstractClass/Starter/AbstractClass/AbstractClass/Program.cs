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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
