// Define a class Complex with appropriate instance variables and member functions.
// Define following operators in the class: a. + b. - c. * d. ==
#include <iostream>
using namespace std;
class Complex
{
    int r, i;

public:
    Complex(int, int);
    Complex() {}
    void showData()
    {
        cout << " " << r << "+" << i << "i" << endl;
    }
    Complex operator+(Complex x)
    {
        Complex temp;
        temp.r = r + x.r;
        temp.i = i + x.i;
        return temp;
    }
    Complex operator-(Complex x)
    {
        Complex temp;
        temp.r = r - x.r;
        temp.i = i - x.i;
        return temp;
    }
    Complex operator*(Complex x)
    {
        Complex temp;
        temp.r = r * x.r;
        temp.i = i * x.i;
        return temp;
    }
    int operator==(Complex x)
    {
        if (r == x.r && i == x.i)
            return 1;
    }
};
Complex::Complex(int x, int y)
{
    r = x, i = y;
}
int main()
{
    Complex c1(2, 4), c2(2, 4);
    c1.showData();
    c2.showData();
    cout << "sum of two complex: ";
    Complex c3 = c2 + c1;
    c3.showData();
    cout << "Subs. of two complex: ";
    Complex c4 = c3 - c2;
    c4.showData();
    cout << "Multi. of two complex: ";
    Complex c5 = c2 * c1;
    c5.showData();
    cout << "equality op.:  ";
    int x = c1 == c2;
    if (x == 1)
        cout << "equal";
    else
        cout << "not equal";
}