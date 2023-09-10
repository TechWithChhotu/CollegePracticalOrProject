// Create a class Time which contains: - Hours - Minutes - Seconds
// Write a C++ program using operator overloading for the following:
// 1. = = : To check whether two Times are the same or not.
// 2. >> : To accept the time.
// 3. << : To display the time.
#include <iostream>
using namespace std;
class Time
{
    int HH, MM, SS;

public:
    Time()
    {
        cout << "Enter Hours: ";
        cin >> HH;
        cout << "Enter Minutes: ";
        cin >> MM;
        cout << "Enter Seconds: ";
        cin >> SS;
        cout << "\n\n";
    }
    int operator==(Time t)
    {
        if (HH == t.HH && MM == t.MM && SS == t.SS)
            return 1;
        else
            return 0;
    }
    int operator>(Time t)
    {
        if ((HH > t.HH) || (HH == t.HH && MM > t.MM) || (HH == t.HH && MM == t.MM && SS > t.SS))
            return 1;
        else
            return 0;
    }
    int operator<(Time t)
    {
        if ((HH > t.HH) || (HH == t.HH && MM > t.MM) || (HH == t.HH && MM == t.MM && SS > t.SS))
            return 0;
        else
            return 1;
    }
};
int main()
{
    cout << "Enter the first time(t1): " << endl;
    Time t1;
    cout << "Enter the Second time(t2): " << endl;
    Time t2;
    if (t1 == t2)
        cout << "Time are equal";
    else if (t1 > t2)
        cout << "t1 is grater";
    else if (t1 < t2)
        cout << "t2 is grater";
    return 0;
}