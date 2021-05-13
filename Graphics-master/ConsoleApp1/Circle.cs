using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    class Circle
    {
        public List<int> Xpoints = new List<int>();
        public List<int> Ypoints = new List<int>();
        public Circle()
        {

        }

        public void CirclePoints(int r)
        {
            int x = 0;
            int y = r;
            int p0 = 1 - r;

            while (x < y)
            {
                if (p0 < 0)
                {
                    p0 += 2 * x + 3; 
                }
                else
                {
                    p0 += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                Xpoints.Add(x);
                Ypoints.Add(y);
            }

        }
    }
}
