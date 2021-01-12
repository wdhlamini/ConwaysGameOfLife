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
            //1 is alive 

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
                //printArray(bigArray);
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
                //printArray(bigArray);
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
                //printArray(bigArray);
            }

            else 

            { //defaults to 10x10 with an L shape
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
                //printArray(bigArray2);
            }

           
        }

        public void printArray(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int coln = 0; coln < arr.GetLength(1); coln++)
                {
                    if (coln == arr.GetLength(1) - 1) //if at the end of the sub array ie row, make new line
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
