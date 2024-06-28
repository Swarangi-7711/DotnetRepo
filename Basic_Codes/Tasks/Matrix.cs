using System;

class Matrix
{
    const int MAX = 10;

    static void ReadMatrix(int[,] matrix, int row, int col)
    {
        Console.WriteLine("Enter elements of the matrix :"+row*col);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write("Element "+"["+i+"]"+"["+j+"]");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void PrintMatrix(int[,] matrix, int row, int col)
    {
        Console.WriteLine("Matrix "+row*col);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void AddMatrices(int[,] mat1, int[,] mat2, int[,] result, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                result[i, j] = mat1[i, j] + mat2[i, j];
            }
        }
    }

    static void SubtractMatrices(int[,] mat1, int[,] mat2, int[,] result, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                result[i, j] = mat1[i, j] - mat2[i, j];
            }
        }
    }

    static void MultiplyMatrices(int[,] mat1, int[,] mat2, int[,] result, int row1, int col1, int col2)
    {
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < col2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < col1; k++)
                {
                    result[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }
    }

    static void Main()
    {
        int[,] mat1 = new int[MAX, MAX];
        int[,] mat2 = new int[MAX, MAX];
        int[,] result = new int[MAX, MAX];
        int row1, col1, row2, col2;
        int choice;

        Console.Write("Enter rows and columns for first matrix: ");
        var input = Console.ReadLine().Split();
        row1 = int.Parse(input[0]);
        col1 = int.Parse(input[1]);

        Console.Write("Enter rows and columns for second matrix: ");
        input = Console.ReadLine().Split();
        row2 = int.Parse(input[0]);
        col2 = int.Parse(input[1]);

        ReadMatrix(mat1, row1, col1);
        ReadMatrix(mat2, row2, col2);
      do{
        Console.WriteLine("Choose operation:\n1. Addition\n2. Subtraction\n3. Multiplication\n4.Quit");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                if (row1 == row2 && col1 == col2)
                {
                    AddMatrices(mat1, mat2, result, row1, col1);
                    Console.WriteLine("Resultant matrix after addition:");
                    PrintMatrix(result, row1, col1);
                }
                else
                {
                    Console.WriteLine("Matrices cannot be added.");
                }
                break;
            case 2:
                if (row1 == row2 && col1 == col2)
                {
                    SubtractMatrices(mat1, mat2, result, row1, col1);
                    Console.WriteLine("Resultant matrix after subtraction:");
                    PrintMatrix(result, row1, col1);
                }
                else
                {
                    Console.WriteLine("Matrices cannot be subtracted.");
                }
                break;
            case 3:
                if (col1 == row2)
                {
                    MultiplyMatrices(mat1, mat2, result, row1, col1, col2);
                    Console.WriteLine("Resultant matrix after multiplication:");
                    PrintMatrix(result, row1, col2);
                }
                else
                {
                    Console.WriteLine("Matrices cannot be multiplied. Column of first matrix is not equal to row of second matrix.");
                }
                break;
            case 4:
                  break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
            
        }
    }while(choice!=4);
    }
}
