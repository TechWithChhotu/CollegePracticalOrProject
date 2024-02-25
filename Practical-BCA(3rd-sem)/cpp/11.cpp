/*11> Implement a file handling program that reads numeric data from a file and handles exceptions for incorrect data.*/
#include <iostream>
#include <fstream>
using namespace std;
class Files
{
public:
    void Write(string Data)
    {
        ofstream fw("temp.txt");
        if (fw.is_open())
        {
            fw << Data;
            cout << "Data write successfully" << endl;
            fw.close();
        }
    }
    string Read()
    {
        string temp;
        ifstream fr("temp.txt");
        if (fr.is_open())
        {
            try
            {
                getline(fr, temp);
                for (int i = 0; temp[i]; i++)
                {
                    if (temp[i] >= '9' or temp[i] <= '0')
                    {
                        throw "ERROR: this file never contain valid numberical data";
                        break;
                    }
                }
                return "file contain a valid numerical data";
            }
            catch (char const *e)
            {
                return e;
            }
            fr.close();
        }
    }
};
int main()
{
    Files file;
    file.Write("12345678");
    cout << file.Read() << endl
         << endl;
    file.Write("chhotu kumar");
    cout << file.Read() << endl;
    return 0;
}
