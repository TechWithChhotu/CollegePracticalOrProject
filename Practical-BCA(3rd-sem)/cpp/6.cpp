/*6> Create a base class "Animal" and derived classes "Cat" and "Dog" that override a virtual method to produce different sounds.*/
#include <iostream>
using namespace std;
class Animal
{
public:
    void virtual Sound() = 0;
};
class Cat : public Animal
{
public:
    void Sound() { cout << "Meow" << endl; }
};
class Dog : public Animal
{
public:
    void Sound() { cout << "Woof" << endl; }
};
int main()
{
    Dog d;
    d.Sound();
    Cat c;
    c.Sound();
    return 0;
}
