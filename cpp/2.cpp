/*2> Demonstrate function overloading by creating functions that calculate
	 the area of different shapes (circle, triangle, rectangle).*/
#include <iostream>
using namespace std;
class shapes
{
public:
	float areaOfCircle(float r)
	{
		return 3.14 * r * r;
	}

	float areaOfTriangle(float w, float h)
	{
		return (float)(1 / 2) * w * h;
	}

	float areaOfRectangle(float w, float h)
	{
		return w * h;
	}
};
int main()
{
	shapes obj1;
	cout << "area of circle is " << obj1.areaOfCircle(8) << endl;
	cout << "area of rectangle is " << obj1.areaOfRectangle(45, 67) << endl;
	cout << "area of Triangle is " << obj1.areaOfTriangle(46, 29.5) << endl;
	return 0;
}
