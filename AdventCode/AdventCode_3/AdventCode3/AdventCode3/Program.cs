using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventCode3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rucksacks = File.ReadAllLines(@"C:\Users\hbarbary\Documents\GitHub\AdventCode2022\AdventCode\AdventCode_3\Input\input2.txt");
            int sum = 0;

            foreach (string rucksack in rucksacks)
            {
                string firstCompartiment = rucksack.Substring(0, rucksack.Length / 2);
                string secondCompartiment = rucksack.Substring(rucksack.Length / 2);
                foreach (char letter in firstCompartiment)
                {
                    for (int l = 0; l < secondCompartiment.Length; l++)
                    {
                        if(letter == l)
                        {
                            int letterValue = 0;
                            if(Char.IsUpper(letter))
                            {
                                letterValue += 26;
                                letter.ToString().ToLower();
                            }
                            letterValue = (int)Char.GetNumericValue(letter) - 64;
                            sum += letterValue;
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
