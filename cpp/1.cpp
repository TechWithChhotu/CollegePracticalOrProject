/*1> Create a class representing a Rectangle with attributes for
length and width. Implement methods to calculate area and perimeter.*/
#include <iostream>
using namespace std;
class Rectangle
{
private:
	float length;
	float width;

public:
	void setter(float x, float y)
	{
		length = x, width = y;
	}
	float calculateArea()
	{
		return width * length;
	}
	float calculatePerimeter()
	{
		return 2 * (width + length);
	}
};
int main()
{
	Rectangle firstObj;
	firstObj.setter(5.6, 8.8);
	cout << "area of rectangle: " << firstObj.calculateArea() << endl;
	cout << "perimeter of rectangles: " << firstObj.calculatePerimeter() << endl;
	return 0;
}
