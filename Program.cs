using System;

namespace ConwaysGameOfLife
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write("Select square board size of 10 or 15 or 20: ");

            Console.Write("Select a square board size: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

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
            mainArray.printArray(arr); 

            Console.WriteLine(); 

            //need to send the first/current array to transformarray method, print then redo until counter reached

            int counter = 1;

            
            int[,] newArr = mainArray.transformArray(arr); 

            while (counter <= 3) //can make any length of iterations
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
