using System; 
using System.Diagnostics;

// Problem #1 : Comparison of pass-by-value and pass-by-ref. 

/* COMMENTED OUT NUM1 for entry point for NUM2 --> 

class Program 
{
    static void Main(string[] args)
    {

        
        // Creating a Large Array
        int[] LArray = new int[99999]; //Array with 1mil values -> dropped all vals cause it was too taxing
        for(int i = 0; i < LArray.Length; i++) //Populate the array with increments by 1
        {   
            LArray[i] = i; 
        }

        // Measure Time for Pass By Value
        Stopwatch stopwatch = Stopwatch.StartNew();
        for (int i = 0; i < 9999; i++)
        {
            PassByVal(LArray);
        }
        stopwatch.Stop();
        Console.WriteLine($" Process By Value time : {stopwatch.ElapsedMilliseconds} milliseconds." ); 

        // Measure Time for Pass by Ref
        stopwatch.Restart();
        for (int i = 0; i < 9999; i++)
        {
            PassByRef( ref LArray);
        }
        stopwatch.Stop();
        Console.WriteLine($" Process by Ref time : {stopwatch.ElapsedMilliseconds} milliseconds.");


    } // End of main


    // Pass By Val
    static void PassByVal(int[] array)
    {
        int total = 0;
        for (int i = 0; i < array.Length; i++)
        {
            total += array[i];
        }
    }

    
    // Pass By Ref
    static void PassByRef(ref int[] array)
    {
        int total = 0;
        for (int i = 0; i < array.Length; i++)
        {
            total += array[i];
        }
    }



} // End of class Program

*/