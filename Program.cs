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

            //need to send the first/current array to transformarray method, print then redo until counter reached

           int counter = 0;

            while (counter <= 20)
            {
                int[,] newArr = mainArray.transformArray(arr);
                mainArray.printArray(newArr);
                Console.Clear();
                counter += 1;
            }

        }
    }
}
