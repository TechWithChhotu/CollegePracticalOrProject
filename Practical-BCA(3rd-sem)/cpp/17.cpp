/*Write a C++ program that counts the total number of characters, words and lines inthe file.*/
#include <iostream>
#include <fstream>
using namespace std;
int main()
{
    string Str;
    int Characters = 0, Words = 0, Lines = 0, i;
    ifstream fin("temp.txt");
    do
    {
        getline(fin, Str);
        for (i = 0; Str[i]; i++)
            if (Str[i] == ' ')
                Words++;
        Characters += i;
        Words++;
        Lines++;
    } while (!fin.eof());
    cout << "Total number of characters are " << Characters << endl;
    cout << "Total number of lines are " << Lines << endl;
    cout << "Total number of words are " << Words << endl;
    return 0;
}
