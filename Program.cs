using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Indexers
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] inputs = new int[,]
         {
            { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
            { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
            { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
            { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
            { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
            { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
            { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
            { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
            { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
         };

            var sudoku = new Sudoku(inputs);

            // Example of accessing Sudoku using the indexer
            Console.WriteLine("Sudoku value at (0, 0): " + sudoku[0, 0]); // Should print 5
            Console.WriteLine("Sudoku value at (8, 8): " + sudoku[8, 8]); // Should print 9

            // Modify a value in the Sudoku grid
            sudoku[0, 0] = 1;

            // Check the updated value
            Console.WriteLine("Updated Sudoku value at (0, 0): " + sudoku[0, 0]); // Should print 1


            Console.ReadKey();
        }
    }

    public class Sudoku
    {
        private int[,] _matrix;
        // Indexer to access the Sudoku grid
        public int this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= _matrix.GetLength(0))
                    return -1;
                if (col < 0 || col >= _matrix.GetLength(1))
                    return -1;
                return _matrix[row, col];
            }
            set
            {
                if (value < 1 || value > 9)
                  return;

                _matrix[row, col] = value;
            }
        }
        // Constructor to initialize the Sudoku grid
        public Sudoku(int[,] matrix)
        {
            _matrix = matrix;
        }
    }


}