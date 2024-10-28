#include <iostream>
using namespace std;

int main()
{
    for (int i = 0; i < 10; i++)
    {
        cout << "Value of i in for Loop: " << i <<endl;
    }

    // Attempt to access a local var of i outside the for loops instance.
    cout << "Value of i outside for Loop:" << i << endl; // This will produce an i is undefined or out of scope error.

    return 0;
}