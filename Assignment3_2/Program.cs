namespace Assignment3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Assingment 3_2!\n\n");
            Create2DArray();
            Console.WriteLine("\nPress ENTER to continue to Assignment 3_2_2");
            Console.ReadLine();
            AddSameSizeMatrices();
            Console.WriteLine("\nPress ENTER to continue to Assignment 3_2_4");
            Console.ReadLine();
            FindTotalAndAverage();
            Console.WriteLine("\nPress ENTER to continue to Assignment 3_2_5");
            Console.ReadLine();
            SearchArray();
        }
        static void Create2DArray()
        {

            Console.WriteLine("=================================");
            Console.WriteLine("         Assignment3_2_1");
            Console.WriteLine("=================================\n");
            Console.WriteLine("1. Create a 2D array to store integers and print them in matrix format with proper formatting.\r\n\r\ne.g:\r\n\r\n| 2 | 3 | 4 |\r\n| 1 | 4 | 6 |\r\n\r\n");
            // Create a 2D arr
            int[,] matrix = {
            { 2, 3, 4 },
            { 1, 4, 6 }
        };

            // Get the dimensions of the matrix
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Print the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"| {matrix[i, j]} ");
                }
                Console.WriteLine("|");
            }

        }

        static void AddSameSizeMatrices()
        {
            Console.Clear();
            Console.WriteLine("\n=================================");
            Console.WriteLine("         Assignment3_2_2");
            Console.WriteLine("=================================\n");
            Console.WriteLine("2. Addition of two Matrices of same size.\n");

            int matrixSize;
            do
            {
                Console.Write("Input the size of the square matrix (less than 5): ");
            } while (!int.TryParse(Console.ReadLine(), out matrixSize) || matrixSize >= 5 || matrixSize <= 0);

            int[,] matrix1 = new int[matrixSize, matrixSize];
            int[,] matrix2 = new int[matrixSize, matrixSize];

            Console.WriteLine("\nInput elements in the first matrix:");
            InputMatrix(matrix1);

            Console.WriteLine("\nInput elements in the second matrix:");
            InputMatrix(matrix2);

            Console.WriteLine("\nThe First matrix is:");
            PrintMatrix(matrix1);

            Console.WriteLine("\nThe Second matrix is:");
            PrintMatrix(matrix2);

            int[,] resultMatrix = AddMatrices(matrix1, matrix2);

            Console.WriteLine("\nThe Addition of two matrix is:");
            PrintMatrix(resultMatrix);
        }

        static void InputMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        static void FindTotalAndAverage()
        {
            Console.Clear();
            Console.WriteLine("\n=================================");
            Console.WriteLine("         Assignment3_2_4");
            Console.WriteLine("=================================\n");
            Console.WriteLine("4. Calculate the total and average of 4 numbers.\n");

            double[] numbers = new double[4];
            string[] ordinals = { "First", "Second", "Third", "Fourth" };

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter the {ordinals[i]} number: ");
                while (!double.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write($"Invalid input. Please enter a valid number for the {ordinals[i]} number: ");
                }
            }

            (double total, double average) = FindTotalAndAverage(numbers[0], numbers[1], numbers[2], numbers[3]);

            Console.WriteLine($"\nThe average of {numbers[0]} , {numbers[1]} , {numbers[2]} , {numbers[3]} is: {average:F2}");
            Console.WriteLine($"The total is {total}");
        }

        static (double total, double average) FindTotalAndAverage(double num1, double num2, double num3, double num4)
        {
            double total = num1 + num2 + num3 + num4;
            double average = total / 4;
            return (total, average);
        }

        static void SearchArray()
        {
            Console.Clear();
            Console.WriteLine("\n=================================");
            Console.WriteLine("         Assignment3_2_5");
            Console.WriteLine("=================================\n");
            Console.WriteLine("5. Find the index of a given item in the array.\n");


            Console.WriteLine("\nEnter your own array and search item:");
            Console.WriteLine("Enter array elements separated by spaces: I.E: 1 3 5");
            int[] userArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine();
            Console.WriteLine("Enter the item to search for: I.E: 5");
            int searchItem = int.Parse(Console.ReadLine());
            int userResult = Search(userArray, searchItem);
            Console.WriteLine($"\nSearch result: {userResult}");
        }
        static int Search(int[] arr, int item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
