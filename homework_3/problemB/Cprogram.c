#include <stdio.h>

int main()
{
    for (int i = 0; i < 10; i++)
    {
        printf("For loop value of i: %d\n", i);
    }

    //Attempt to access a local var i outside of the loops instance
    printf("For loop value of i: %d\n", i); //This line will produce an out of scope or a undefined error.

    return 0;
}