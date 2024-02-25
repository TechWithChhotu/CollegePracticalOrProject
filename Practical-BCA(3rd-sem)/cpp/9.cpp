/*Write a C++ program to read a text file and count the number of characters in it.*/
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    ifstream fin("temp.txt");
    char temp;
    int count = 0;
    if (!fin)
        cout << "File not able to open or file is not exist...!" << endl;
    else
    {
        while (!fin.eof())
        {
            count++;
            fin >> temp;
        }
        cout << "\ntotal number of character in a file is " << count << endl;
    }
    return 0;
}
