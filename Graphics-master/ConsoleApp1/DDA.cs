using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    class DDA
    {
       public  List<int> Xpoints = new List<int>();
       public List<int> Ypoints = new List<int>();
        public List<float> UnroundedPoints = new List<float>();

        public DDA()
        {

        }

        public void DDAline(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = xEnd - x0;
            int dy = yEnd - y0;
            int steps, xf, yf;

            float slope = (float)dy / (float)dx;
            Console.WriteLine("Slope="+slope.ToString("0.000")+" in decimal");
            Console.WriteLine("Slope="+dy+"/"+dx+" in division form\n");
            float x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }
            else
            {
                steps = Math.Abs(dy);
            }

           

            if (slope > 1)
            {
                if (xEnd > x0 || yEnd > y0)
                {
                    Console.WriteLine("Slope is greater than one line processed from left to right\nSo, Y will be increased and calculate X\n");
                }
                else
                {
                    Console.WriteLine("Slope is greater than one line processed from right to left\nSo, Y will be decreased and calculate X\n");
                }
                
                for (int i = 0; i < steps; i++)
                {
                    y0 = y0 + (xEnd > x0 || yEnd > y0 ? 1 : -1);
                    Ypoints.Add(y0);

                
                    x = x + (xEnd > x0 || yEnd > y0 ? (1 / slope) : (-1 / slope));
                    UnroundedPoints.Add(x);
                    xf = (int)Math.Round(x);
                     Xpoints.Add(xf);
                }
                for (int i = 0; i < Xpoints.Count; i++)
                {
                    Console.WriteLine("(" + Xpoints[i] + "," + Ypoints[i] + ")" + "\t\t" + "Point in unrounded shape (" + UnroundedPoints[i].ToString("0.00")  + "," + Ypoints[i] + ")");
                }
            }
            else if(slope <=1)
            {
               if((xEnd > x0 || yEnd > y0) && (slope>0 && slope<1))
                {
                    Console.WriteLine("Slope is less than one line processed from left to right\nSo, X will be increased and calculate Y\n");
                }
               else
                {
                    Console.WriteLine("Slope is less than one line processed from right to left\nSo, X will be decreased and calculate Y\n");
                }
                for (int i = 0; i < steps; i++)
                {
                    if((xEnd > x0 || yEnd > y0) && (slope>0 && slope<1))
                    {
                        x0 = x0 + 1;
                        Xpoints.Add(x0);
                    }
                    else if (xEnd < x0 || yEnd < y0)
                    {
                        x0 = x0 - 1;
                        Xpoints.Add(x0);
                    }


                    if ((xEnd > x0 || yEnd > y0) && (slope > 0 && slope < 1))
                    {
                        y = y + slope;
                        UnroundedPoints.Add(y);
                        yf = (int)Math.Round(y);
                        Ypoints.Add(yf);

                    }
                    else if (xEnd < x0 || yEnd < y0)
                    {
                        y = y -  slope ;
                        UnroundedPoints.Add(y);
                        yf = (int)Math.Round(y);
                        Ypoints.Add(yf);
                    }
                  
                }
                for (int i = 0; i < Xpoints.Count; i++)
                {
                    Console.WriteLine("(" + Xpoints[i] + "," + Ypoints[i] + ")" + "\t\t" + "Point in unrounded shape (" + Xpoints[i] + "," + UnroundedPoints[i].ToString("0.00") + ")");
                }
            }
            else
            {
                Console.WriteLine("Error! invalid points no line can be drawn\n");
            }

           
        }

    }
}
