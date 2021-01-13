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

        public int[,] transformArray(int[,] firstArr)
        {
            /*
             * alive neighbour <= 1 OR >= 4 then dies
             * alive neighbour == 2 or 3 alive
             * 
             */
           
           // int counter = 0; //the game will repeat for 20 steps

            int n = firstArr.GetLength(0); //gets the length of the row (which is the length of colns since it's a square)

            if (n == 15) 
            {
                int[,] newArr = new int[15, 15]; 

                //int[,] newArr = new int[5, 5]; 

                //initialise newArr to completely blank

                for (int row = 0; row < firstArr.GetLength(0); row++)
                {
                    for (int coln = 0; coln < firstArr.GetLength(1); coln++)
                    {


                        #region the corners

                        if (row == 0 && coln == 0) //top left
                        {

                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }


                        }

                        else if (row == 0 && coln == n - 1) //top right
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (row == n - 1 && coln == 0) //bottom left
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (row == n - 1 && coln == n - 1) //bottom right
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up left NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        #endregion

                        #region edges

                        else if (row == 0) //top edge
                        {
                            int aliveNeighbours = 0;


                            //check neighbour right E
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }
                            
                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (coln == n - 1) //right edge
                        {

                            int aliveNeighbours = 0;

                            //check neighbour W left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }

                        }

                        else if (row == n - 1) //bottom edge
                        {
                            int aliveNeighbours = 0;

                            //check neighbour W left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up left NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour E right
                            if (firstArr[row , coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (coln == 0) //left edge 
                        {
                            int aliveNeighbours = 0;

                            //check neighbour E right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        #endregion

                        #region centre with eight neighbours 
                        else      //centre pieces with eight neighbours
                        {
                            int aliveNeighbours = 0;

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour right E
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour SE
                            if (firstArr[row + 1, coln +1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour left W
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }

                            

                        }

                        #endregion
                    }

                }

                return newArr;
            }


            
        

            else if (n==20)
            {
                int[,] newArr = new int[20, 20];
                for (int row = 0; row < firstArr.GetLength(0); row++)
                {
                    for (int coln = 0; coln < firstArr.GetLength(1); coln++)
                    {
                        #region the corners

                        if (row == 0 && coln == 0) //top left
                        {

                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }


                        }

                        else if (row == 0 && coln == n - 1) //top right
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (row == n - 1 && coln == 0) //bottom left
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (row == n - 1 && coln == n - 1) //bottom right
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up left NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        #endregion

                        #region edges

                        else if (row == 0) //top edge
                        {
                            int aliveNeighbours = 0;


                            //check neighbour right E
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (coln == n - 1) //right edge
                        {

                            int aliveNeighbours = 0;

                            //check neighbour W left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }

                        }

                        else if (row == n - 1) //bottom edge
                        {
                            int aliveNeighbours = 0;

                            //check neighbour W left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up left NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour E right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (coln == 0) //left edge 
                        {
                            int aliveNeighbours = 0;

                            //check neighbour E right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        #endregion

                        #region centre with eight neighbours 
                        else      //centre pieces with eight neighbours
                        {
                            int aliveNeighbours = 0;

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour right E
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour left W
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }



                        }

                        #endregion
                    }

                }

                return newArr;
            }
            
            else //default of 10
            {
                int[,] newArr = new int[10, 10];
                for (int row = 0; row < firstArr.GetLength(0); row++)
                {
                    for (int coln = 0; coln < firstArr.GetLength(1); coln++)
                    {
                        #region the corners

                        if (row == 0 && coln == 0) //top left
                        {

                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }


                        }

                        else if (row == 0 && coln == n - 1) //top right
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (row == n - 1 && coln == 0) //bottom left
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (row == n - 1 && coln == n - 1) //bottom right
                        {
                            //have only three neighbours

                            int aliveNeighbours = 0;


                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up left NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            if (aliveNeighbours <= 1)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        #endregion

                        #region edges

                        else if (row == 0) //top edge
                        {
                            int aliveNeighbours = 0;


                            //check neighbour right E
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (coln == n - 1) //right edge
                        {

                            int aliveNeighbours = 0;

                            //check neighbour W left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour up
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag down left SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }

                        }

                        else if (row == n - 1) //bottom edge
                        {
                            int aliveNeighbours = 0;

                            //check neighbour W left
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag up left NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour E right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        else if (coln == 0) //left edge 
                        {
                            int aliveNeighbours = 0;

                            //check neighbour E right
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour diag down right SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour diag up right NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours += 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }
                        }

                        #endregion

                        #region centre with eight neighbours 
                        else      //centre pieces with eight neighbours
                        {
                            int aliveNeighbours = 0;

                            //check neighbour up N
                            if (firstArr[row - 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour NE
                            if (firstArr[row - 1, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour right E
                            if (firstArr[row, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour SE
                            if (firstArr[row + 1, coln + 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour down S
                            if (firstArr[row + 1, coln] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour SW
                            if (firstArr[row + 1, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour left W
                            if (firstArr[row, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //check neighbour NW
                            if (firstArr[row - 1, coln - 1] == 1)
                            {
                                aliveNeighbours = aliveNeighbours + 1;

                            }

                            //alive neighbour <= 1 OR >= 4 then dies
                            //alive neighbour == 2 or 3 alive

                            if (aliveNeighbours <= 1 || aliveNeighbours >= 4)
                            {
                                //current cell must die ie change to zero in new array
                                newArr[row, coln] = 0;
                            }

                            else if (aliveNeighbours == 2 || aliveNeighbours == 3)
                            {
                                newArr[row, coln] = 1;
                            }



                        }

                        #endregion
                    }

                }

                return newArr;
            }

            


                 
        }
        
    }
}
