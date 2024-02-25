/*Write a C++ program to open an output file 'a.txt' and append data to it.*/
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    ofstream fout("TestAppend.txt", ios::app);
    if (fout.is_open())
    {
        string temp;
        cout << "Enter your Data: ";
        getline(cin, temp);
        fout << temp;
        cout << "Data appended successfully" << endl;
    }
    fout.close();
    return 0;
}
