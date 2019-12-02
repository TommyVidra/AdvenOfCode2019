using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2019
{
    class Day_2
    {

        private static int[] getVals()
        {
            String path = "D:\\Projects\\AdventOfCode2019\\AdventOfCode2019\\AdventOfCode2019\\day_2_input_p1.txt";

            String[] lines = File.ReadAllLines(path, Encoding.UTF8);
            String line = "";

            for (int i = 0; i < lines.Length; ++i)
            {
                line += lines[i];
            }

            String[] values = line.Split(",");

            int[] vals = new int[values.Length];

            for (int i = 0; i < values.Length; ++i)
            {
                try
                {
                    vals[i] = Int32.Parse(values[i]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }
            }

            return vals;
        }

        private static int getOutput(int noun, int verb, int[] vals)
        {
            vals[1] = noun;
            vals[2] = verb;

            for (int i = 0; i < vals.Length; i += 4)
            {
                if (!(vals[i] == 99))
                {
                    try
                    {
                        int first = vals[i];
                        int second, third, dest, temp;
                        temp = vals[i + 1];
                        second = vals[temp];

                        temp = vals[i + 2];
                        third = vals[temp];

                        dest = vals[i + 3];

                        switch (first)
                        {
                            case 1:
                                temp = second + third;
                                break;
                            case 2:
                                temp = second * third;
                                break;
                        }

                        vals[dest] = temp;
                    }
                    catch(IndexOutOfRangeException e)
                    {
                        Console.WriteLine("EKOOOOOOOOOOOOO\n\n");
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Program ended");
                    Console.WriteLine(vals[0]);
                    return vals[0];
                }

            }
            return vals[0];
        }

        public static void partOne()
        {
            int[] vals = getVals();

            vals[1] = 12;
            vals[2] = 2;

            int output = getOutput(vals[1], vals[2], vals);

        }

        public static void partTwo()
        {
            int[] vals = getVals();

            for(int noun = 0; noun < 99; ++noun)
            {
                for(int verb = 0; verb < 99; ++verb)
                {
                    vals = getVals();
                    int output = getOutput(noun, verb, vals);
                    if (output == 19690720)
                    {
                        Console.WriteLine("Program found a result");
                        Console.WriteLine(noun + " " + verb);
                        int res = 100 * noun + verb;
                        Console.WriteLine(res);
                        return;
                    }
                }
            }
           
        }
        
    }
}
