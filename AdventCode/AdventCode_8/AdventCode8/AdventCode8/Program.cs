using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventCode8
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input
            string[] input = File.ReadAllLines(@"C:\Users\hbarbary\Desktop\AdventCode\AdventCode_8\Input\input.txt");
            int[][] treesGrid = new int[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                treesGrid[i] = Array.ConvertAll(input[i].ToCharArray(), l => (int)Char.GetNumericValue(l));
            }

            int visibleTrees = 0;
            visibleTrees += (treesGrid.Length * 2 - 2) * 2;

            // Count visible Trees
            for (int row = 1; row < treesGrid.Length-1; row++)
            {
                for (int col = 1; col < treesGrid.Length-1; col++)
                {
                    
                    int currTree = treesGrid[row][col];
                    bool TopIsVisible = Top(row, col, currTree, treesGrid);
                    if(TopIsVisible == true)
                    {
                        visibleTrees++;
                        continue;
                    }
                    bool BotIsVisible = Bot(row, col, currTree, treesGrid);
                    if (BotIsVisible == true)
                    {
                        visibleTrees++;
                        continue;
                    }
                    bool LeftIsVisible = Left(row, col, currTree, treesGrid);
                    if (LeftIsVisible == true)
                    {
                        visibleTrees++;
                        continue;
                    }
                    bool RightIsVisible = Right(row, col, currTree, treesGrid);
                    if (RightIsVisible == true)
                    {
                        visibleTrees++;
                    }
                }
            }

            int mostVisibleTree = 0;
            // Find best spot for house
            for (int row = 1; row < treesGrid.Length - 1; row++)
            {
                for (int col = 1; col < treesGrid.Length - 1; col++)
                {
                    int currTree = treesGrid[row][col];
                    bool TopIsVisible = Top(row, col, currTree, treesGrid);
                    bool BotIsVisible = Bot(row, col, currTree, treesGrid);
                    bool LeftIsVisible = Left(row, col, currTree, treesGrid);
                    bool RightIsVisible = Right(row, col, currTree, treesGrid);
                    // Find Best spot for house
                    if (TopIsVisible == true || LeftIsVisible == true || RightIsVisible == true || BotIsVisible == true)
                    {
                        int count = BotTreeVisible(row, col, currTree, treesGrid) *
                                    RightTreeVisible(row, col, currTree, treesGrid) *
                                    LeftTreeVisible(row, col, currTree, treesGrid) *
                                    TopTreeVisible(row, col, currTree, treesGrid);
                        if (count > mostVisibleTree)
                        {
                            mostVisibleTree = count;
                        }
                    }
                }

            }


            bool Top(int row, int col, int currTree, int[][] grid)
            {
                for (int i = 0; i < row; i++)
                {
                    if(grid[i][col] >= currTree)
                    {
                        return false;
                    }
                }
                return true;
            }
            bool Bot(int row, int col, int currTree, int[][] grid)
            {
                for (int i = row+1; i < grid.Length; i++)
                {
                    if(grid[i][col] >= currTree)
                    {
                        return false;
                    }
                }
                return true;
            }
            bool Right(int row, int col, int currTree, int[][] grid)
            {
                for (int i = col+1; i < grid.Length; i++)
                {
                    if(grid[row][i] >= currTree)
                    {
                        return false;
                    }
                }
                return true;
            }
            bool Left(int row, int col, int currTree, int [][] grid)
            {
                for (int i = 0; i < col; i++)
                {
                    if(grid[row][i] >= currTree)
                    {
                        return false;
                    }
                }
                return true;
            }
            int RightTreeVisible(int row, int col, int currTree, int[][] grid)
            {
                int treeVisible = 0;
                for (int i = col+1; i < grid.Length; i++)
                {
                    treeVisible++;
                    if(grid[row][i] >= currTree)
                    {
                        break;
                    }
                }
                return treeVisible;
            }
            int LeftTreeVisible(int row, int col, int currTree, int[][] grid)
            {
                int treeVisible = 0;
                for (int i = col-1; i >= 0; i--)
                {
                    treeVisible++;
                    if (grid[row][i] >= currTree)
                    {
                        break;
                    }
                }
                return treeVisible;
            }
            int TopTreeVisible(int row, int col, int currTree, int[][] grid)
            {
                int treeVisible = 0;
                for (int i = row-1; i >= 0; i--)
                {
                    treeVisible++;
                    if (grid[i][col] >= currTree)
                    {
                        break;
                    }
                }
                return treeVisible;
            }
            int BotTreeVisible(int row, int col, int currTree, int[][] grid)
            {
                int treeVisible = 0;
                for (int i = row+1; i < grid.Length; i++)
                {
                    treeVisible++;
                    if (grid[i][col] >= currTree)
                    {
                        break;
                    }
                }
                return treeVisible;
            }
            int GetTreeVisible(int row, int col, int currTree, int[][]grid)
            {
          

                return LeftTreeVisible(row, col, currTree, grid) * RightTreeVisible(row, col, currTree, grid) * BotTreeVisible(row, col, currTree, grid) * TopTreeVisible(row, col, currTree, grid);
            }
            Console.WriteLine(visibleTrees);
            Console.WriteLine(mostVisibleTree);
            
        }
    }
}
