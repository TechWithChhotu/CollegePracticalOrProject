/*12> Write a C++ program to read data from a text file, sort it, and write the sorted data back to the file.*/
#include <iostream>
#include <fstream>
#include <algorithm>
using namespace std;
int main()
{
    string Data = "";
    ifstream fr("temp.txt");
    if (fr.is_open())
    {
        string temp;
        cout << "File opened successfully" << endl;
        do
        {
            getline(fr, temp);
            Data += " " + temp;
        } while (!fr.eof());
        fr.clear();
        // if data is read successfully then sort and write data in the same file.
        sort(Data.begin(), Data.end());
        ofstream fw("temp.txt");
        if (fw.is_open())
        {
            fw << Data;
            cout << "Sorted data write successfully" << endl;
        }
    }
    return 0;
}
