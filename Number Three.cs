using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Problems
{
    class Number_Three
    {
        public List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

        public static void ClassAverage()
        {
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            List<double> avgOfavg = new List<double>();
            double avgResult;

            for (int i = 0; i < classGrades.Count; i++)
            {
                var splitClassgrades = classGrades[i].Split(',');
                var stringInt = classGrades.Select(int.Parse).ToList();
                stringInt.Remove(stringInt.Min());
                avgResult = stringInt.Average();
                avgOfavg.Add(avgResult);
            }
            Console.WriteLine("Average Grade: " + avgOfavg.Average());
            Console.ReadLine();
        }
    }
}
