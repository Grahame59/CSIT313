/* For part A.3: Consider the following C program: ... For each of the four marked points in this function, list each visible variable along with the number of the defintion
statement that defines it.



void fun(void)
{
    int a, b, c; //Definition 1
    ...
    while (...)
    {
        int b, c, d; //Definition 2
        ... <------------ 1
        while(...)
        {
        int c, d, e; //Definition 3
        ... <--------- 2
        }
        ... <---------- 3
    }
... <---------- 4
}

ANSWER: 

so at Point 1:
    - a is defined at defintion 1.
    - b and c are defined in definition 2 but shadow definition 1.
    - d is defined in defintion 2.

At Point 2:
    - a still defined in defintion 1.
    - b is defined in defintion 2.
    - c and d are defined in defintion 3 but shadow defintion 2.
    - e is defined in defintion 3.

At Point 3: 
    - a is defined at definiton 1.
    - b, c, and d are defined in defintion 2.
    
At Point 4:
    - a is defined in definition 1.
    - b is defined in definition 1.
    - c is defined in definition 1.

*/