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

            mainArray.printArray(arr);

        }
    }
}
