//Task 2BS

public class Task2A
{
    public static void main (String[] args)
    {

        int num = 9;

        if (num == 10) 
        {
            if (isBoolTrue()) 
            { // This only evaluates if num == 10 is true
                System.out.println("Both conditions = True");
            } 
            else 
            {
                System.out.println("Second condition was false");
            }
        } 
        else 
        {
            System.out.println("First condition was false, second condition not evaluated.");
        }
    }

}

    public static boolean isBoolTrue()
    {
        System.out.println("Second condition met");
        return false;
    }
}