public class Task3
{
    public static void main(String[] args) 
    {
        
        int n = 3; // EX: Matrix size
        int[][] x = 
        {              // INDEX of rows below:
            {1, 0, 0}, // row 0
            {0, 0, 0}, // row 1
            {0, 0, 0}  // row 2
        };

            boolean allZero = false; // flag for checking for all zero

            for (int i = 0; i < n; i++)
            {
                allZero = true; //We can assume a row is all-zero unntil discovered otherwise
                for (int j = 0; j < n; j++)
                {
                    if(x[i][j] != 0) 
                    {
                        allZero = false; // if row has non-zero value flag = false
                        break; //exit
                    }
                }
                if (allZero)
                {
                    System.out.println("First all zero is: " + i);
                    break; //exit for first loop if row is all zero
                }
            }

            if(!allZero)
            {
                System.out.println("No all zero rows.");
            }
    }
}