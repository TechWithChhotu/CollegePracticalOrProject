/*Create a Dollar class and add necessary functions to support int to Dollar type conversion.
Example:-int main(){ int x = 50;Dollar d;d = x;d.display(); return 0;}*/
#include <iostream>
using namespace std;
class Dollar
{
    int D;

public:
    void Display()
    {
        cout << "Dollor = " << D << endl;
    }
    Dollar(int x)
    {
        D = x;
    }
    Dollar() {}
};
int main()
{
    int x = 50;
    Dollar d;
    d = x;
    d.Display();
    return 0;
}