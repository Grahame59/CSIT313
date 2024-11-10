// Task2A

public class Task2A 
{
    public static void main(String[] args) 
    {
        int num = 10;

        // Short-circuit evalution 
        if (num == 10 && isBoolTrue() )
        {
            System.out.println("Both conditions = True");

        }
        else
        {
            System.out.println("Short circuit evaluation occured, second condition not evaluated.");
        }

    }

    public static boolean isBoolTrue()
    {
        System.out.println("Second condition met");
        return false;
    }
}