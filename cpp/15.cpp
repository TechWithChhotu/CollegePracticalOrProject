// Define a class Greatest and define instance member function to find Largest among 3 numbers using classes.
#include <iostream>
using namespace std;
class LargestNumber
{
    int a, b, c;

public:
    void input_number()
    {
        cout << "Enter three number: ";
        cin >> a >> b >> c;
    }
    void gestes_display()
    {
        if (a > b && a > c)
            cout << a << " is grater";
        else if (b > c)
            cout << b << " is grater";
        else
            cout << c << " is grater";
    }
};
int main()
{
    LargestNumber a;
    a.input_number();
    a.gestes_display();
    return 0;
}