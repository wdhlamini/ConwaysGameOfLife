using System;

namespace ConwaysGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Select square board size of 10 or 15 or 20: ");
            
            //int n = int.Parse(Console.ReadLine());

            TwoDimenArray mainArray = new TwoDimenArray();

            int[,] arr = mainArray.InitialState(8);

            int[,] tempArray = new int[5,5] {
                {1,1,0,1,1},
                {1,0,0,1,1},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,0,0,0,1},
            };

            mainArray.printArray(tempArray); //was arr as parameter

            //need to send the first/current array to transformarray method, print then redo until counter reached

           int counter = 0;

            while (counter <= 3)
            {
                int[,] newArr = mainArray.transformArray(tempArray); //was arr as parameter
                mainArray.printArray(newArr);
                Console.WriteLine();
                //Console.Clear();
                counter += 1;
            }

        }
    }
}
