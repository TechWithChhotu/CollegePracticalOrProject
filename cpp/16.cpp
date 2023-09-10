/*Write a C++ program to accept a password and throw an exception if the password has
less than 6 characters or does not contain a digit or does not contain any special
character or does not contain any capital letter.*/
#include <iostream>
using namespace std;
int main()
{
    string password;
    int i;
    cout << "Enter your password: ";
    cin >> password;
    for (i = 0; password[i]; i++)
    {
        if (!(password[i] >= 'a' and password[i] <= 'z'))
        {
            i = -1;
            break;
        }
    }
    try
    {
        if (password.length() < 6 or i != -1)
            throw "password is not strong";
        cout << "Login successfully" << endl;
    }
    catch (const char *msg)
    {
        cout << msg << endl;
    }
    return 0;
}