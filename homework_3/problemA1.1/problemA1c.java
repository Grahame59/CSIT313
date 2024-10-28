/* For Part A: "The type of a variable indicates its range of values. Contrast the type of variables in Java and Python." */

/* Java is Strong typing and statically typed where Python is flexible and dynmaically typed. So in Java a variables data type must be declared at compile time and the type is strictly defined 
by a range of values specific to that type. 

Java provides multiple primitive types such as:
    - int: Can store a 32 bit integer. Range is -2,147,483,648 to 2,147,483, 647.
    - double: Can store a 64 bit floating point number. Range is generally from -1.7e-308 to +1.7e-308.
    - bool: Can store a binary value of either true or false.
    - char: Can store a single 16 Unicode char. Range is from '\u0000' to '\uffff' ( 0 to 65,535).

Python is dynamically typed and flexible meaning that the types are determined at runtime and not explicitly defined at compile time such as in Java. Python also does not have fixed primitive 
data types for ints and floats with restricted ranges:
    - int: Python's int type supports arbitrary precision meaning that an int can grow as large as the memory will allow.
    - float: Python's float is a double precision so 64 bit floating point number. The range is generally the same as Java's range for floats.
*/

public class VariableTypeTest
{
    public static void main(String[] args)
    {
        int maxInt = 2147483647;
        double maxDouble = 1.7e+308;

        System.out.println("Int value = " + maxInt);
        System.out.println("Double value = " + maxDouble);

        maxInt = 2147483648; //This will cause an Error because it is out of the Integer Range.    
        }
}