using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2019
{
    class Day_3
    {

        private static void steping(Point point, String step, List<Point> line)
        {
            string direction = step.Substring(0, 1);
            int points = Int32.Parse(step.Substring(1, step.Length - 1));

            while(points >= 0)
            {
                switch (direction)
                {

                    case "U":
                        line.Add(point);
                        point.Y += 1;
                        --points;
                        break;

                    case "D":
                        line.Add(point);
                        point.Y -= 1;
                        --points;
                        break;
                    
                    case "L":
                        line.Add(point);
                        point.X -= 1;
                        --points;
                        break;

                    case "R":
                        line.Add(point);
                        point.X += 1;
                        --points;
                        break;
                }
            }
            

        }

        private static List<Point> drawLine(String[] steps)
        {
            var lastPoint = new Point(0, 0);
            var line = new List<Point>();

            foreach(string step in steps)
            {
                steping(lastPoint, step, line);
                lastPoint = line.Last();
            }

            return line;
        }

        public static void partTwo(List<Point> intesections, List<Point> wire1, List<Point> wire2)
        {
            int minDist = 0;

            foreach(Point p in intesections)
            {
                int dist1 = wire1.IndexOf(p);
                int dist2 = wire2.IndexOf(p);
                int dist = dist1 + dist2;
                Console.WriteLine(dist1 + " " + dist2);

                if (minDist == 0 || minDist > dist)
                    minDist = dist;
            }

            Console.WriteLine("Fewest combined steps to an intersection: " + minDist);
        }

        public static void partOne()
        {

            String path = "E:\\Projects\\AdventOfCode2019\\AdventOfCode2019\\AdventOfCode2019\\day_3_input_p1.txt";
            String[] lines = File.ReadAllLines(path, Encoding.UTF8);

            String[] steps1 = lines[0].Split(",");
            String[] steps2 = lines[1].Split(",");

            var wire1 = drawLine(steps1);
            var wire2 = drawLine(steps2);

            var intersections = wire1.Intersect(wire2).ToList();
            intersections.RemoveAt(0);
            
            var distance = new List<int>();

            foreach(Point p in intersections)
            {
                distance.Add(Math.Abs(0 - p.X) + Math.Abs(0 - p.Y)); // because every line starts at 0,0
                Console.WriteLine(Math.Abs(p.X) + " " + Math.Abs(p.Y));
            }

            Console.WriteLine("Program has ended, the smallest distance is: " + distance.Min().ToString());
            partTwo(intersections, wire1, wire2);

        }
    }
}
