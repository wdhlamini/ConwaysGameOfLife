using System;

namespace ConwaysGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select square board size of 10 or 15 or 20: ");
            
            int n = int.Parse(Console.ReadLine());

            TwoDimenArray mainArray = new TwoDimenArray();

            int[,] arr = mainArray.InitialState(n);

            /*int[,] tempArray = new int[5,5] {
                {1,1,0,1,1},
                {1,0,0,1,1},
                {0,0,0,0,0},
                {0,0,0,0,1},
                {1,0,1,0,1},
            };*/

            Console.WriteLine("Initial state:");
            mainArray.printArray(arr); //was arr as parameter

            Console.WriteLine(); //temporary remove

            //need to send the first/current array to transformarray method, print then redo until counter reached

            int counter = 0;

            
            int[,] newArr = mainArray.transformArray(arr); //was arr as parameter
            

            while (counter <= 3)
            {
                Console.WriteLine("Iteration " + counter + ": ");
                mainArray.printArray(newArr);
                newArr = mainArray.transformArray(newArr);
                Console.WriteLine();
                //Console.Clear();
                counter += 1;
            }

        }
    }
}
