/*10> Build a program that handles exceptions when dividing two numbers and outputs a user-friendly error message.*/
#include <iostream>
#include <stdexcept>
using namespace std;
class Division
{
public:
    Division(int Nom, int Denom)
    {
        try
        {
            if (Denom == 0)
            {
                throw "Error: Division by zero is not allowed.";
            }
            else
            {
                cout << "Nom/Denom: " << Nom / Denom << endl;
            }
        }
        catch (char const *e)
        {
            cout << e;
        }
    }
};
int main()
{
    Division div1(8, 4);
    Division div2(8, 0);
    return 0;
}
