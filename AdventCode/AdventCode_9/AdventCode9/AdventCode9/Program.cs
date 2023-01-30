using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventCode9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linesInput = File.ReadAllLines(@"C:\Users\hbarbary\Desktop\AdventCode\AdventCode_9\Input\input2.txt");
            List<string> directions = new List<string>();
            List<int> distances = new List<int>();
            HashSet<(int, int)> tailPos = new HashSet<(int, int)>();

            foreach (string lineInput in linesInput)
            {
                string[] parts = lineInput.Split(' ');
                string directionInput = parts[0];
                int distanceInput = int.Parse(parts[1]);

                directions.Add(directionInput);
                distances.Add(distanceInput);
            }
            for (int i = 0; i < length; i++)
            {

            }
            
        }
    }
}
