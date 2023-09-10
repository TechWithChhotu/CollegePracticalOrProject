/*14> Design a base class "Shape" and derived classes for specific shapes. Implement a virtual function to calculate their area.*/
#include <iostream>
#include <math.h>
using namespace std;
class Shape
{
public:
    virtual float caluculateArea() = 0;
};
class Circle : public Shape
{
    float radius;

public:
    Circle(float r) { radius = r; }
    float caluculateArea()
    {
        return M_PI * radius * radius;
    }
};
class Rectangle
{
protected:
    int length, breadth;

public:
    Rectangle(int l, int w)
    {
        length = l;
        breadth = w;
    }
    float calculateArea()
    {
        return length * breadth;
    }
};
int main()
{
    Circle c(5);
    cout << "Area of Circle is " << c.caluculateArea() << endl;
    Rectangle r(5, 8);
    cout << "Area of Rectangle is " << r.calculateArea() << endl;
    return 0;
}
