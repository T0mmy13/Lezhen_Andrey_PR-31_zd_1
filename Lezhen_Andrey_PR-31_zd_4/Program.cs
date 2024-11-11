using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");
            var lengths = lines[0].Split();
            int messageLength = int.Parse(lengths[0]); 
            int newspaperLength = int.Parse(lengths[1]); 

            string message = lines[1]; 
            string newspaperText = lines[2];

            var newspaperWords = newspaperText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var newspaperWordCount = new Dictionary<string, int>();

            foreach (var word in newspaperWords)
            {
                if (newspaperWordCount.ContainsKey(word))
                {
                    newspaperWordCount[word]++;
                }
                else
                {
                    newspaperWordCount[word] = 1;
                }
            }

            var messageWords = message.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StreamWriter sw = new StreamWriter("output.txt");
            foreach (var word in messageWords)
            {
                if (!newspaperWordCount.ContainsKey(word) || newspaperWordCount[word] == 0)
                {
                    sw.WriteLine(word);
                    return;
                }
                newspaperWordCount[word]--;
            }
            sw.WriteLine("GOOD NOTE");
            sw.Close();
        }
    }
}
