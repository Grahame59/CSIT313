/* Assume the following JavaScript program was interpreted using static scoping rules. What value of x is displayed in function sub1? Under dynamic scoping rules, what value of x is 
displayed in the function sub1?
*/

/* The following code if following staticly scoped will return x = 5. 
The execution flow for static scoping: 
    - var x declared globally.
    - x = 5 is assigned to the global x.
    - sub2() is called.
    - Inside sub2():
        - var x is declared, this is a local instance and is seperate from the global var x.
        - x = 10 is assigned to the local x.
        - sub1() is called but due to the scope sub1() refers to the global x. 
        - so x = 5

The following code will return x = 10 if dynamically scoped.
The execution flow for dynamic scoping:
    - var x declared globally.
    - x = 5 is assigned to the global x.
    - sub2() is called. 
    - Inside sub2():
        - var x is declared, this is a local instance and is seperate from the global var x.
        - x = 10 is assigned to the local x.
        - sub1() is called but due to the scope sub1() refers to the local x.
        - so x would = 10.
        */

var x;
function sub1()
{
    document1.write("x = " + x + "");

}
function sub2()
{
    var x;
    x = 10;
    sub1();
}
x = 5;
sub2();
