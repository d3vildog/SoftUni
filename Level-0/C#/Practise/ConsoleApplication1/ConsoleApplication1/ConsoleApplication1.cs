namespace ConsoleApplication1
{
    using System;
    using System.Linq;

   public class ConsoleApplication1
    {
       public static void Main()
        {
            ////Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
            
           // Declaring variables
            int gridSize;
            int row = 0;
            int column = - 1;
            int currentNumber = 0;
            int numberToPrint = 0; 
            int[,] matrix;
            
           // User input
            Console.Write("Enter grid size(^2)  = ");
            gridSize = int.Parse(Console.ReadLine());
            matrix = new int[gridSize, gridSize];

           //// Solution

            // Printing Row - 0 and Column- 0, 1, 2, 3! currentNumber = 1 - 4!
            for (int col = numberToPrint; col < gridSize; col++)
            {
                currentNumber = currentNumber + 1;
                column = column + 1;
                matrix[row, column] = currentNumber;
            }
            numberToPrint = numberToPrint + 1;

            while (currentNumber < gridSize * gridSize)
            {
                // Printing Row - 1, 2, 3 and Column - 3! currentNumber = 5 - 7!
                for (int roww = numberToPrint; roww < gridSize; roww++)
                {
                    currentNumber = currentNumber + 1;
                    row = row + 1;
                    matrix[row, column] = currentNumber;
                }

                // Printing Row - 3 and Column - 3, 2, 1, 0! currentNumber = 8 - 10!
                for (int col = numberToPrint; col < gridSize; col++)
                {
                    currentNumber = currentNumber + 1;
                    column = column - 1;
                    matrix[row, column] = currentNumber;
                }

                numberToPrint = numberToPrint + 1;
                // Printing Row - 3, 2, 1 and Column - 0! currentNumber = 11 - 12!
                for (int roww = numberToPrint; roww < gridSize; roww++)
                {
                    currentNumber = currentNumber + 1;
                    row = row - 1;
                    matrix[row, column] = currentNumber;
                }

                // Printing Row - 1 and Column - 1, 2! currentNumber = 13 - 14!
                for (int col = numberToPrint; col < gridSize; col++)
                {
                    currentNumber = currentNumber + 1;
                    column = column + 1;
                    matrix[row, column] = currentNumber;
                }

                numberToPrint = numberToPrint + 1;
            }

           // Output
            for (int roww = 0; roww < gridSize; roww++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Console.Write("{0,5}", matrix[roww, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
