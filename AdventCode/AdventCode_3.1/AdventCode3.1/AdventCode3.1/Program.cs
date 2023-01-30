using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace AdventCode3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rucksacks = File.ReadAllLines(@"C:\Users\hbarbary\Documents\GitHub\AdventCode2022\AdventCode\AdventCode_3.1\Input\input.txt");
            int prio = 0;
            int groupPrio = 0;

            List<String> sameLetters = new List<string>();
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alphabetLower = "abcdefghijklmnopqrstuvwyz".ToCharArray();

            foreach (string rucksack in rucksacks)
            {
                string firstCompartiment = rucksack.Substring(0, rucksack.Length / 2);
                string secondCompartiment = rucksack.Substring(rucksack.Length / 2);
                string sameLetter = "";
                sameLetters.Add(sameLetter);

                foreach (char letter in firstCompartiment)
                {
                    for (int c = 0; c < secondCompartiment.Length; c++)
                    {
                        if (letter == secondCompartiment[c])
                        {
                            bool check = sameLetter.Contains(letter);
                            sameLetter += letter;
                            if (check == false)
                            {
                                for (int i = 0; i < alphabet.Length; i++)
                                {
                                    if (letter == alphabet[i])
                                    {
                                        //Console.WriteLine("la lettre " + letter + " est dans les 2 compartiments, elle donne " + (1 + 26 + i) + " points");
                                        prio += i + 1 + 26;
                                    }
                                }
                                for (int j = 0; j < alphabetLower.Length; j++)
                                {
                                    if (letter == alphabetLower[j])
                                    {
                                        //Console.WriteLine("la lettre " + letter + " est dans les 2 compartiments, elle donne " + (1 + j) + " points");
                                        prio += j + 1;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            

        }

            
    }
}
   
            
    

    

