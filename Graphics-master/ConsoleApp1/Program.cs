using System;
using System.Collections.Generic;
using System.Threading;

namespace Graphics
{
    class Program
    {

        public static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Choose the algorithm from the list below\n1-DDA\n2-Bresenham\n3-Circle\n\n(1,2,3)?");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\n\t** DDA algoritm **\nfollow the on-screen instructions to continue");
                DDA dDA = new DDA();
                int x0, y0, x1, y1;
                Console.WriteLine("\nenter the start x point ");
                x0 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the start y point ");
                y0 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the end x point ");
                x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the end y point ");
                y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n(X0,Y0)=("+x0+","+y0+")\t\t"+"(X1,Y1)=("+x1+","+y1+")\n");
                dDA.DDAline(x0, y0, x1, y1);
                
            }
            if (choice == 2)
            {
                Console.WriteLine("\n\t** Bresenham algoritm **\nfollow the on-screen instructions to continue");
                Bresenham bresenHam = new Bresenham();
                int x0, y0, x1, y1;
                Console.WriteLine("\nenter the start x point ");
                x0 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the start y point ");
                y0 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the end x point ");
                x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the end y point ");
                y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n(X0,Y0)=(" + x0 + "," + y0 + ")\t\t" + "(X1,Y1)=("+ x1+","+ y1+")\n");
                bresenHam.Bresline(x0, y0, x1, y1);
               /*for (int i = 0; i < bresenHam.Xpoints.Count; i++)
                {
                    Console.WriteLine(bresenHam.Xpoints[i] + "\t" + bresenHam.Ypoints[i]);
                }*/
            }
            if (choice == 3)
            {
                Circle circle = new Circle();
            circle.CirclePoints(10);
             for (int i = 0; i < circle.Xpoints.Count; i++)
            {
             Console.WriteLine(circle.Xpoints[i] + "\t" + circle.Ypoints[i]);
            }
         
            }








        }

    }
    
   
}