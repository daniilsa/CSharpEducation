using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    struct Rectangle
    {
        double width;
        double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;


        }
        /// <summary>
        /// РАсчёт площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            return (width * height);
        }
    }
}
