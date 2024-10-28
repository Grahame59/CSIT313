public class JavaScopeTest()
{
    public static void main(String[] args) 
    {
        for (int i = 0; i < 10; i++)
        {
            System.out.println("Value of i in the for loop: " + i);

        }
        
        // Accessing local var i outside its loop instance. 
        System.out.println("Value of i outside the for loop: " + i); //This will produce a out of scope or undefined error. 
    }
}