using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM_OF_SIDES;
            do
            {
                Console.Write("How many vertices for your polygon? ");
                NUM_OF_SIDES = int.Parse(Console.ReadLine());
            } while (NUM_OF_SIDES < 3);
            

            double[] xValues = new double[NUM_OF_SIDES+1];
            double[] yValues = new double[NUM_OF_SIDES+1];
            // NOTE: the first index (index 0) of each array is left alone to make things simpler
            // index will correspond with the vertex number
            // ie. xValue[3] will contain the x-coordinate for the third vertex

            int vertex = 1;
            while (vertex <= NUM_OF_SIDES) {
                Console.Write($"vertex{vertex} x-value: ");
                xValues[vertex] = Convert.ToDouble(Console.ReadLine());
                Console.Write($"vertex{vertex} y-value: ");
                yValues[vertex] = Convert.ToDouble(Console.ReadLine());
                vertex++;
            }
            int side = 1;           
            double xA, xB, yA, yB;
            double area;
            List<double> areas = new List<double>();
            while (side <= NUM_OF_SIDES)
            {
                if (side == NUM_OF_SIDES) // last side will use the last and first points
                {
                    xA = xValues[side]; // last x
                    yA = yValues[side]; // last y
                    xB = xValues[1]; // first x
                    yB = yValues[1]; // first y
                }
                else
                {
                    xA = xValues[side];
                    yA = yValues[side];
                    xB = xValues[side+1];
                    yB = yValues[side+1];

                }
                area = (xA - xB) * (yA + yB) / 2;
                Console.WriteLine($"Points ({xA},{yA}) and ({xB},{yB}) -> area = {area}");
                areas.Add(area);
                side++;
            }
            double finalArea = Math.Abs(areas.Sum());
            Console.WriteLine($"The final area is {finalArea}");
            Console.WriteLine("Done");
        }
    }
}
