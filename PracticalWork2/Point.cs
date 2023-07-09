using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    public struct Point
    {
        int x, y;
        /// <summary>
        /// Возвращение дистанции между двумя точками
        /// </summary>
        /// <param name="x">Точка 1</param>
        /// <param name="y">Точка 2</param>
        /// <returns></returns>
        public int GetDistance(int x, int y)
        {
            this.x = x;
            this.y = y;
            return Math.Abs(x - y);
        }
    }
}
