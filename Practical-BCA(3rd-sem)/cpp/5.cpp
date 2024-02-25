/*5> Write a C++ program that uses the new and delete operators to manage memory for a student database.*/
#include <iostream>
using namespace std;
class Students
{
private:
    int roll;
    string name;

public:
    Students() {}
    Students(int roll, string name)
    {
        this->roll = roll;
        this->name = name;
    }
    void displayStudentDetails()
    {
        cout << "Roll: " << roll << " | "
             << "Name: " << name << endl;
    }
    void setStudentDetails(int roll, string name)
    {
        this->roll = roll;
        this->name = name;
    }
};
int main()
{
    Students *ckumar = new Students(106, "chhotuKumar");
    ckumar->displayStudentDetails();

    Students *BCA = new Students[5];
    BCA[0].setStudentDetails(107, "Pankaj");
    BCA[1].setStudentDetails(108, "Abhishek");
    BCA[2].setStudentDetails(109, "gulshan");
    BCA[3].setStudentDetails(110, "zaid");
    BCA[4].setStudentDetails(111, "Mohit");

    for (int i = 0; i < 5; i++)
    {
        BCA[i].displayStudentDetails();
    }

    return 0;
}
