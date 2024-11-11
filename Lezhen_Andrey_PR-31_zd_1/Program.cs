using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = File.ReadAllLines("input.txt");
            string[] FirstLine = line[0].Split(' ');
            int k = int.Parse(FirstLine[0]);
            int n = int.Parse(FirstLine[1]);
            int fishPerFisherman = n / k;
            File.WriteAllText("output.txt", fishPerFisherman.ToString());
        }
    }
}
