/*7> Implement a program using multiple inheritance to model a "Student" class inheriting from both "Person" and "Course" classes.*/
#include <iostream>
using namespace std;
class Person
{
protected:
    string name;
    int age;

public:
    Person(string name, int age)
    {
        this->age = age;
        this->name = name;
    }
};
class Courses
{
protected:
    string courseName;
    int courseId;

public:
    Courses(string courseName, int courseId)
    {
        this->courseName = courseName;
        this->courseId = courseId;
    }
};
class Students : public Person, public Courses
{
public:
    Students(string name, int age, string courseName, int courseId) : Person(name, age), Courses(courseName, courseId) {}
    void DisplayStudentRecord()
    {
        cout << "Name: " << name << " age: " << age << " | course: " << courseName << " couseId: " << courseId << endl;
    }
};
int main()
{
    Students s1("chhotu", 18, "WEBDEV", 5485);
    Students s2("ravi", 28, "AI/ML", 5486);
    s1.DisplayStudentRecord();
    s2.DisplayStudentRecord();
    return 0;
}
