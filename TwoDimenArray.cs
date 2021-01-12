using System;
using System.Collections.Generic;
using System.Text;

namespace ConwaysGameOfLife
{
    class TwoDimenArray
    {
        public int[,] InitialState(int n)
        {
            //creates the initial state of the game board
            

            if (n == 10)
            {
                Random rnd = new Random();
                int[,] bigArray = new int[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        bigArray[i, j] = rnd.Next(0, 2);
                    }
                }

                return bigArray;
            }

            if (n == 15)
            {
                Random rnd = new Random();
                int[,] bigArray = new int[15, 15];
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        bigArray[i, j] = rnd.Next(0, 2);
                        
                    }
                }

                return bigArray;
            }

            if (n == 20)
            {
                Random rnd = new Random();
                int[,] bigArray = new int[20, 20];
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        bigArray[i, j] = rnd.Next(0, 2);

                    }
                }

                return bigArray;
            }

            else if (n != 10 || n!= 15 || n != 20 )

            {
                int[,] bigArray2 = new int[10, 10] {{1,0,0,0,0,0,0,0,0,0},
                                                    {1,0,0,0,0,0,0,0,0,0},
                                                    {1,0,0,0,0,0,0,0,0,0},
                                                    {1,0,0,0,0,0,0,0,0,0},
                                                    {1,0,0,0,0,0,0,0,0,0},
                                                    {1,0,0,0,0,0,0,0,0,0},
                                                    {1,0,0,0,0,0,0,0,0,0},
                                                    {1,0,0,0,0,0,0,0,0,0},
                                                    {1,0,0,0,0,0,0,0,0,0},
                                                    {1,1,1,1,1,1,1,1,1,1}};

                return bigArray2;
            }
            //populate 
            //1 is alive cell, 0 is dead cell

            /* for (int row = 0; row < n; row++)
             {
                 for (int coln = 0; row < n; coln++)
                 {
                     //making an L means left and bottom must be filled with ones
                     if (coln == 0) //left
                     {
                         bigArray[row, coln] = 1;
                     }

                     else if (row == n - 1) //bottom
                     {
                         bigArray[row, coln] = 1;
                     }

                     else
                     {
                         bigArray[row, coln] = 0;
                     }
                 }
             }


             return bigArray;*/


        }

        public void printArray(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int coln = 0; coln < arr.GetLength(1); coln++)
                {
                    if (coln == arr.GetLength(1) - 1)
                    {
                        Console.WriteLine(arr[row, coln]);
                    }

                    else
                    {
                        Console.Write(arr[row, coln]);
                    }

                }
            }
        }


    }
}
