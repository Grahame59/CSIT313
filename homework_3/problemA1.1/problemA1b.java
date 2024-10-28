/* For Part A: "Keywords are words that have special meaning to the translator software, e.g., int in Java or Python. Reserved words are words that the programmer may not use as
identifiers. Compare keywords (for data types integer and real) as reserved words in Java and Python."
*/

/* So data types in java such as int, float, double are considered reserved words for variable and type declaration, this is similiar in Python as int and float are reserved and unusuable as var 
names but there is dynamic data type declaration in Python such that you do not need to explicitly define a data type as it will define it at runtime. This in comparison is not how Java works and 
you need to explicitly define Java data types at first use. 
*/

// The following code will result in a Compile time error due to use or reserved words. 

public class DataTypeTest 
{
    public static void main (String[] args)
    {
        int float = 10;
        float int = 20;

    }
}