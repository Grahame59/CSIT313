using System;

class MatrixMultiplicationProgram
{
    // Initialize Matrix Vars
    private static int m; // Rows in A
    private static int n; // Columns in A / Rows in B
    private static int p; // Columns in B
    private static int[,] A; // Matrix A
    private static int[,] B; // Matrix B
    private static int[,] C; // Result Matrix C

    public static void CountLoop()
    {
        for (int i = 0; i < m; i++) // loop through rows of matrix 1 or A
        {        
            for (int j = 0; j < p; j++) // Loop through columns of matrix 2 or B
            {    
                C[i][j] = 0;                  
                for (int k = 0; k < n; k++) // Loop through columns of matrix A / rows of matrix b
                { 
                    C[i][j] += A[i][k] * B[k][j]; // Accumulate the product of the matrices multiplication
                }
            }
        }
    }

    public static void LogicLoop()
    {
        //initialize indices
        int i = 0;
        int j = 0;

        while (i < m) // Loop through rows of matrix A
        {
            j = 0; // Reset column index for new row
            while (j < p) // Loop through columns of matrix B
            {    
                C[i, j] = 0; // Initialize 
                int k = 0; // initialize inner loop index
                while (k < n) // Loop through columns of A / rows of B
                { 
                    C[i, j] += A[i, k] * B[k, j]; // product
                    k++; // Increment inner loop index
                }
                j++; // Increment column index
            }
            i++; // Increment row index
        }
    }

    public static void userInputSetup()
    {
        Console.Write("Enter number of rows in matrix A: ");
        m = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns in matrix A (rows in B): ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns in matrix B: ");
        p = int.Parse(Console.ReadLine());

        // Initialize Matrices off userInput
        A = new int[m, n];
        B = new int[n, p];
        C = new int[m, p];

        // Input values for matrix A
        Console.WriteLine("Enter elements for matrix A:");
        for (int i = 0; i < m; i++) // loop for rows of matrix A
        {
            for (int j = 0; j < n; j++) // loop for columns of matrix A
            {
                Console.Write($"A[{i},{j}]: "); 
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Input values for matrix B
        Console.WriteLine("Enter elements for matrix B:");
        for (int i = 0; i < n; i++) // loop for rows of matrix B ( = columns of matrix A)
        {
            for (int j = 0; j < p; j++) // loop for columns of matrix B
            {
                Console.Write($"B[{i},{j}]: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Method to print the result matrix
    public static void PrintMatrixC()
    {
        Console.WriteLine("Result Matrix C:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(C[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    
    
    // Main entry point    
    static void Main(string[] args)
    {
        userInputSetup(); //calls for user to setup rows, columns, and values of matrices A and B
        
        Console.WriteLine("Counting Loop: \n");
        CountLoop(); //Matrix Multiplication Counting Loop
        PrintMatrixC();

        Console.WriteLine("Logic Loop: \n");
        LogicLoop(); //Matric Multiplication Logic Loop
        PrintMatrixC();

        

    }
}
