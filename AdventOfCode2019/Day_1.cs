using System;
using System.IO;
using System.Text;

namespace AdventOfCode2019
{
    class Day_1
    {

        private static void partOne(String[] lines)
        {
           
            int sum = 0;
            

            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    //parses integers for every line in the input
                    int num = Int32.Parse(lines[i]);
                    num = num / 3;
                    num -= 2;
                    sum += num;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }
            }

            //displays the sum
            Console.WriteLine(sum);
            String s = Console.ReadLine();

        }

        private static void partTwo(String[] lines)
        {
            int sum = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                try
                {
                    //parses integers for every line in the input
                    int num = Int32.Parse(lines[i]);
                    num = num / 3;
                    num -= 2;
                    sum += num;

                    while (num > 0)
                    {
                        num = num / 3;
                        num -= 2;
                        if (num < 0)
                            num = 0;
                        sum += num;
                    }
                    
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine(sum);

        }


        static void Main(string[] args)
        {
            //String path = "D:\\Projects\\AdventOfCode2019\\AdventOfCode2019\\AdventOfCode2019\\day_1_input_p1.txt";
            //String[] lines = File.ReadAllLines(path, Encoding.UTF8);

            //First part
            //partOne(lines);

            //Part two
            //partTwo(lines);

            //Day_2.partOne();
            //Day_2.partTwo();

            //Day_3.partOne();

            Day_4.partOne();
            String s = Console.ReadLine();

        }
    }
}
