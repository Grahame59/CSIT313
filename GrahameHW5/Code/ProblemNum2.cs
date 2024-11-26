// Problem #2 : Compare the status of Pass By Value and Pass by Reference.

public class ProblemNum2
{
    static void Main(String[] args) 
    {
        // Initalize vars
        int ByVal = 1000;
        int ByRef = 2000;

        Console.WriteLine("\nBefore Functions are Called : \n----------------------------");
        Console.WriteLine($"By Val : {ByVal}, By Ref : {ByRef}\n");

        PassByRef(ref ByRef);
        Console.WriteLine("After PassByRef is Called: \n----------------------------");
        Console.WriteLine($"By Val : {ByVal}, By Ref : {ByRef}\n");

        PassByVal(ByVal);
        Console.WriteLine($"After PassByVal is Called: \n---------------------------");
        Console.WriteLine($"By Val : {ByVal}, By Ref : {ByRef}\n");
        

    }

    static void PassByRef(ref int Ref)
    {
        Ref = Ref * 2;
        Console.WriteLine($"-------------------------------------\nInside Function PassByRef: Ref = {Ref}\n-------------------------------------\n");
    }

    static void PassByVal(int Val)
    {
        Val = Val * 2;
        Console.WriteLine($"-------------------------------------\nInside Function PassByVal: Val = {Val}\n-------------------------------------\n");
    }

}