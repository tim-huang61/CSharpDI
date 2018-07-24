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

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
