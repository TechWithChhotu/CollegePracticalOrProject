/*Write a C++ program to add two numbers using single inheritance. Accept these two
numbers from the user in base class and display the sum of these two numbers in
derived class.
*/
#include <iostream>
using namespace std;
class BaseClass
{
protected:
    int x, y;

public:
    void InputData()
    {
        cout << "Enter two number:    ";
        cin >> x >> y;
    }
};
class DerivedClass : public BaseClass
{
public:
    int GetSumOfTwoNumbers()
    {
        return x + y;
    }
};
int main()
{

    DerivedClass d1;
    d1.InputData();
    cout << "Sum of two number is " << d1.GetSumOfTwoNumbers();
    return 0;
}
