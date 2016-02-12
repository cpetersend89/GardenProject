using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlots
{
    class Plot
    {
        private int _x;
        private int _y;
        private int _w;
        private int _h;
        public Plot(int X, int Y, int W, int H)
        {
            _x = X;
            _y = Y;
            _w = W;
            _h = H;
        }
        public override string ToString()
        {
            return $"{_x}, {_y}, {_w}, {_h}";
        }
        public int GetPerimeter()
        {
            int perimeter;
            perimeter = 2 * (_w + _h);
            return perimeter;
        }
    }
}
