using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics
{
    class Bresenham
    {
        public List<int> Xpoints = new List<int>();
        public List<int> Ypoints = new List<int>();
        public List<int> Ppoints = new List<int>();
        public Bresenham()
        {

        }

        void swap(ref int x0,ref int y0,ref int xEnd,ref int yEnd)
        {
            int temp0, temp1;
            temp0 = x0;
            x0 = y0;
            y0 = temp0;
            temp1 = xEnd;
            xEnd = yEnd;
            yEnd = temp1;
        }
        public void Bresline(int x0, int y0, int xEnd, int yEnd)
        {

            int xf = 0, yf = 0;
            int pstart=0;
            float slope = (float)(yEnd - y0) / (float)(xEnd - x0);

            Console.WriteLine("Slope="+(yEnd - y0)+ "/" + (xEnd - x0) + "  ---->  "+"Slope=" +slope.ToString("0.00")+"\n");





            if(x0<xEnd && (slope>=0 &&slope<=1))
            {
                if (slope==0)
                {
                    Console.WriteLine("Line is horizontal");
                }
                xf = x0;
                yf = y0;
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int p0 = 2 * dy - dx;
                pstart = p0;
                // Ppoints.Add(p0);
                Console.WriteLine("Line lies in First octant\n");
                Console.WriteLine("Δx=" + dx+ "\nΔy=" + dy+ "\n2Δy=" + 2*dy+ "\n2Δy-2Δx="+2*(dy-dx)+"\nP0="+(2*dy-dx)+"\n");
                
                while (x0 < xEnd)
                {
                    x0++;

                    if (p0 < 0)
                    {
                        p0 += 2 * dy;
                    }
                    else
                    {
                        y0++;
                        p0 += 2 * (dy - dx);
                    }
                    Xpoints.Add(x0);
                    Ypoints.Add(y0);
                    Ppoints.Add(p0);
                }
            }
            else if (y0<yEnd&&slope>1)
            {
                swap(ref x0, ref y0, ref xEnd, ref yEnd);
                xf = x0;
                yf = y0;
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int p0 = 2 * dy - dx;
                pstart = p0;
                // Ppoints.Add(p0);
                Console.WriteLine("Line lies in Second octant\n");
                Console.WriteLine("Δx=" + dx + "\nΔy=" + dy + "\n2Δy=" + 2 * dy + "\n2Δy-2Δx=" + 2 * (dy - dx) + "\nP0=" + p0 + "\n");
              
                while (x0 < xEnd)
                {
                    x0++;

                    if (p0 < 0)
                    {
                        p0 += 2*dy;
                    }
                    else
                    {
                        y0++;
                        p0 += 2 * (dy - dx);
                    }
                    Xpoints.Add(x0);
                    Ypoints.Add(y0);
                    Ppoints.Add(p0);
                }

            }
            else if (y0 < yEnd && slope < -1)
            {
                swap(ref x0, ref y0, ref xEnd, ref yEnd);
                xf = x0;
                yf = y0;
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int p0 = 2 * dy - dx;
                pstart = p0;
                // Ppoints.Add(p0);
                Console.WriteLine("Line lies in Third octant\n");
                Console.WriteLine("Δx=" + dx + "\nΔy=" + dy + "\n2Δy=" + 2 * dy + "\n2Δy-2Δx=" + 2 * (dy - dx) + "\nP0=" + p0 + "\n");

                while (x0 < xEnd)
                {
                    x0++;

                    if (p0 < 0)
                    {
                        p0 += 2 * dy;
                    }
                    else
                    {
                        y0--;
                        p0 += 2 * (dy - dx);
                    }
                    Xpoints.Add(x0);
                    Ypoints.Add(y0);
                    Ppoints.Add(p0);
                }

            }
            else if (x0 > xEnd && (slope >=-1&&slope<=0))
            {
                xf = x0;
                yf = y0;
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int p0 = 2 * dy - dx;
                pstart = p0;
                // Ppoints.Add(p0);
                Console.WriteLine("Line lies in Fourth octant\n");
                Console.WriteLine("Δx=" + dx + "\nΔy=" + dy + "\n2Δy=" + 2 * dy + "\n2Δy-2Δx=" + 2 * (dy - dx) + "\nP0=" + p0 + "\n");

                while (x0 > xEnd)
                {
                    x0--;

                    if (p0 < 0)
                    {
                        p0 += 2 * dy;
                    }
                    else
                    {
                        y0++;
                        p0 += 2 * (dy - dx);
                    }
                    Xpoints.Add(x0);
                    Ypoints.Add(y0);
                    Ppoints.Add(p0);
                }

            }

            else if (x0 > xEnd && (slope > 0 && slope <= 1))
            {
                xf = x0;
                yf = y0;
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int p0 = 2 * dy - dx;
                pstart = p0;
                // Ppoints.Add(p0);
                Console.WriteLine("Line lies in Fifth octant\n");
                Console.WriteLine("Δx=" + dx + "\nΔy=" + dy + "\n2Δy=" + 2 * dy + "\n2Δy-2Δx=" + 2 * (dy - dx) + "\nP0=" + p0 + "\n");

                while (x0 > xEnd)
                {
                    x0--;

                    if (p0 < 0)
                    {
                        p0 += 2 * dy;
                    }
                    else
                    {
                        y0--;
                        p0 += 2 * (dy - dx);
                    }
                    Xpoints.Add(x0);
                    Ypoints.Add(y0);
                    Ppoints.Add(p0);
                }

            }
            else if (y0 > yEnd && slope > 1)
            {
                swap(ref x0, ref y0, ref xEnd, ref yEnd);
                xf = x0;
                yf = y0;
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int p0 = 2 * dy - dx;
                pstart = p0;
                // Ppoints.Add(p0);
                Console.WriteLine("Line lies in Sixth octant\n");
                Console.WriteLine("Δx=" + dx + "\nΔy=" + dy + "\n2Δy=" + 2 * dy + "\n2Δy-2Δx=" + 2 * (dy - dx) + "\nP0=" + p0 + "\n");

                while (x0 > xEnd)
                {
                    x0--;

                    if (p0 < 0)
                    {
                        p0 += 2 * dy;
                    }
                    else
                    {
                        y0--;
                        p0 += 2 * (dy - dx);
                    }
                    Xpoints.Add(x0);
                    Ypoints.Add(y0);
                    Ppoints.Add(p0);
                }

            }
            else if (y0 > yEnd && slope < -1)
            {
                swap(ref x0, ref y0, ref xEnd, ref yEnd);
                xf = x0;
                yf = y0;
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int p0 = 2 * dy - dx;
                pstart = p0;
                // Ppoints.Add(p0);
                Console.WriteLine("Line lies in Seventh octant\n");
                Console.WriteLine("Δx=" + dx + "\nΔy=" + dy + "\n2Δy=" + 2 * dy + "\n2Δy-2Δx=" + 2 * (dy - dx) + "\nP0=" + p0 + "\n");

                while (x0 > xEnd)
                {
                    x0--;

                    if (p0 < 0)
                    {
                        p0 += 2 * dy;
                    }
                    else
                    {
                        y0++;
                        p0 += 2 * (dy - dx);
                    }
                    Xpoints.Add(x0);
                    Ypoints.Add(y0);
                    Ppoints.Add(p0);
                }

            }
            else if (x0 < xEnd && (slope <= 0 && slope >= -1))
            {
                if (slope == 0)
                {
                    Console.WriteLine("Line is horizontal");
                }
                xf = x0;
                yf = y0;
                int dx = Math.Abs(xEnd - x0);
                int dy = Math.Abs(yEnd - y0);
                int p0 = 2 * dy - dx;
                pstart = p0;
                // Ppoints.Add(p0);
                Console.WriteLine("Line lies in Eighth octant\n");
                Console.WriteLine("Δx=" + dx + "\nΔy=" + dy + "\n2Δy=" + 2 * dy + "\n2Δy-2Δx=" + 2 * (dy - dx) + "\nP0=" + (2 * dy - dx) + "\n");

                while (x0 < xEnd)
                {
                    x0++;

                    if (p0 < 0)
                    {
                        p0 += 2 * dy;
                    }
                    else
                    {
                        y0--;
                        p0 += 2 * (dy - dx);
                    }
                    Xpoints.Add(x0);
                    Ypoints.Add(y0);
                    Ppoints.Add(p0);
                }
            }
            Console.WriteLine("k" + "\t" + "Pk" + "\t" +"(Xk,Yk)");
            Console.WriteLine("--" + "\t" + "--" + "\t" + "-------");
            Console.WriteLine(0 + "\t" + pstart + "\t" + "(" + xf + "," + yf + ")" + "\t");
            for (int i = 0; i < Xpoints.Count;i++)
            {
             
                    Console.WriteLine(i+1 + "\t" + Ppoints[i] + "\t" + "(" + Xpoints[i] + "," + Ypoints[i] + ")" + "\t");

            }




       
        }
    }
}
