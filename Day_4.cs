using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    class Day_4
    {

        private static List<int> generatorOfInputs()
        {
            int start = 109165;
            int end = 576723;
            var input = new List<int>();

            while(start <= end)
            {
                input.Add(start);
                start++;
            }

            return input;
        }

        public static void partTwo()
        {

        }

        public static void partOne()
        {
            var gudPasses = new List<int>();
            var input = generatorOfInputs();
            

            foreach(int numb in input)
            {
               
                int first = numb / 100000;
                int second = (numb / 10000) % 10;
                int third = (numb / 1000) % 10;
                int fourth = (numb / 100) % 10;
                int fifth = (numb / 10) % 10;
                int sixth = numb % 10;
                int largest = first;

                if (first == second || second == third || third == fourth || fourth == fifth || fifth == sixth)
                {
                    if (first <= second)
                    {
                        if (second <= third)
                        {
                            if (third <= fourth)
                            {
                                if (fourth <= fifth)
                                {
                                    if (fifth <= sixth)
                                    {
                                        gudPasses.Add(numb);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(gudPasses.Count);
        }
    }
}
