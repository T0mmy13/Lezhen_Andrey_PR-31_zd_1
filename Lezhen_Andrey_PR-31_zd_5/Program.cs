using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] firstLine = lines[0].Split(' ');
            int sum = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                sum += (int.Parse(lines[i]) / 2) + 1;
            }
            sum *= int.Parse(firstLine[1]);
            File.WriteAllText("output.txt", sum.ToString());        
        }
    }
}
