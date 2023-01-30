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
            string[] rucksacks = File.ReadAllLines(@"C:\Users\hbarbary\Desktop\AdventCode\AdventCode_3\Input\input2.txt");
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
                            if(Char.IsUpper(letter))
                            {
                                sum += 26;
                            }

                        }
                    }
                }
            }
        }
    }
}
