/*A file 'Employee.txt' contains empno and empname. Write a C++ program to add and
read contents of this file and search for an employee whose name is 'XYZ'.*/
#include <iostream>
#include <fstream>
using namespace std;
class Employee
{
    int EmpNo;
    string EmpName;
    void Display()
    {
        cout << EmpNo << "  " << EmpName << endl;
    }

public:
    void InputRecord()
    {
        cout << "Enter Employament number:  ";
        cin >> EmpNo;
        fflush(stdin);
        cout << "Enter Employee Name     : ";
        getline(cin, EmpName);
        ofstream fout("Employee.txt", ios::app);
        if (!fout)
            cout << "Record are not saved successfully....";
        else
            fout << endl
                 << EmpNo << " " << EmpName;
    }
    void DisplayRecord()
    {
        ifstream fin("Employee.txt");
        if (!fin)
            cout << "File not able to open or read contant from this file location" << endl;
        else
        {
            do
            {
                fin >> EmpNo;
                fin >> EmpName;
                Display();
            } while (!fin.eof());
        }
    }
    void SearchRecord()
    {
        cout << "Enter your Name to search record:    ";
        string Name;
        getline(cin, Name);
        ifstream fin("Employee.txt");
        if (!fin)
            cout << "File not able to open or read contant from this file location" << endl;
        else
        {
            do
            {
                fin >> EmpNo;
                fin >> EmpName;
                if (EmpName.compare(Name) == 0)
                {
                    Display();
                    return;
                }
            } while (!fin.eof());
            cout << "Record does not exist with " << Name;
        }
    }
};
int main()
{
    Employee e1, e2, e3;
    e1.InputRecord();
    e2.InputRecord();
    e3.InputRecord();
    e1.DisplayRecord();
    e1.SearchRecord();
    return 0;
}
