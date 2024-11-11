using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");
            int n = int.Parse(lines[0]);
            int size = 2 * n;
            var diameters = lines[1].Split(' ').Select(int.Parse).ToList();

            var indexedDiameters = new List<(int index, int diameter)>();
            for (int i = 0; i < size; i++)
            {
                indexedDiameters.Add((i + 1, diameters[i]));
            }
            indexedDiameters.Sort((a, b) => a.diameter.CompareTo(b.diameter));

            var snowmen = new List<(int lower, int upper)>();

            for (int i = 0; i < n; i++)
            {
                int lower = indexedDiameters[size - 1 - i].index;
                int upper = indexedDiameters[i].index;
                snowmen.Add((lower, upper));
            }

            using (StreamWriter sr = new StreamWriter("output.txt"))
            {
                foreach (var snowman in snowmen)
                {
                    sr.WriteLine($"{snowman.lower} {snowman.upper}");
                }
            }
        }
    }
}
