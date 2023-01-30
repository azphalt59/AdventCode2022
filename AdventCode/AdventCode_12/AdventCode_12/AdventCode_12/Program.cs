using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventCode_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines(@"C:\Users\hbarbary\Desktop\AventCode\AdventCode_12\Input\input.txt");
            int row = inputLines.Length;
            int col = inputLines[0].Length;
            char startLetter = 'S';
            char endLetter = 'E';

            string[,] positionData = new string[row, col];
            bool[,] positionExplored = new bool[row, col];

            int[,] startPos = new int[0, 0];
            int startPosRow = 0;
            int startPosCol = 0;

            int[,] endPos = new int[0, 0];
            int endPosRow = 0;
            int endPosCol = 0;

            int[,] currentPos = new int[0, 0];
            int currentXpos = 0;
            int currentYpos = 0;

            int[,] posDistance = new int[row, col];

            Queue<int[,]> posQueue;

            // Create map and get letter position
            for (int r = 0; r < inputLines.Length; r++)
            {
                for (int c = 0; c < inputLines[0].Length; c++)
                {
                    char letter = inputLines[r][c];
                    positionData[r, c] = letter + "," + r + "," + c;
                    positionExplored[r, c] = false;
                    posDistance[r, c] = -1;
                }
            }

            // Find start & end pos
            for (int r = 0; r < inputLines.Length; r++)
            {
                for (int c = 0; c < inputLines[0].Length; c++)
                {
                    char letter = inputLines[r][c];
                    if(letter == startLetter)
                    {
                        startPos = new int[r,c];
                        startPosRow = r;
                        startPosCol = c;
                        currentPos = new int[r, c];
                        currentXpos = r;
                        currentYpos = c;
                        positionExplored[r, c] = true;
                        posDistance[r, c] = 0;
                    }
                    if(letter == endLetter)
                    {
                        endPos = new int[r, c];
                        endPosRow = r;
                        endPosCol = c;
                    }
                }

            }
            posQueue = new Queue<int[,]>();
            posQueue.Enqueue(startPos);
            // Movement
            while(currentPos != endPos)
            {
                posQueue.Dequeue();
                foreach (int[] pos in)
                {

                }
                int[,] northPos = new int[currentXpos - 1, currentYpos];
                int[,] southPos = new int[currentXpos + 1, currentYpos];
                int[,] eastPos = new int[currentXpos, currentYpos+1];
                int[,] westPos = new int[currentXpos, currentYpos-1];
            }

            Console.WriteLine("la map fait " + row + " de large et " + col + " de long");
            Console.WriteLine("la pos de départ est " + startPosRow + " " + startPosCol + " et la pos de fin est " + + endPosRow + " " + endPosCol);
            Console.WriteLine(positionData[5,15]);

            

        }
    }
}
