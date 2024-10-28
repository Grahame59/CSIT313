// For Part A: "Contrast the case-sensitivty in Java and Python"

/* In Java names are case sensitive and follow a rule set of any char is allowed as long as it is a letter (uppercase or lowercase are different chars so A != a), a number ( 0 - 9 ), or an 
underscore _ or money sign $, the variable name cannot start with a number, and you cannot use reserved words ( such as class, int, static, public, private, etc...). So CustomerMoney and
customerMoney are not the same variable. 
*/

public class CaseSensitivtyExample
{
    public static void main (String[] args)
    {
        int customerMoney = 10;
        int CustomerMoney = 50;
    }

    System.out.println("customerMoney = " + customerMoney); // prints 10
    System.out.println("CustomerMoney = " + CustomerMoney); // prints 50
}
