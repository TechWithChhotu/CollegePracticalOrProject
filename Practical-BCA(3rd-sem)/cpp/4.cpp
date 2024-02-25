/*4> Develop a program that dynamically allocates memory for an array of integers and calculates their sum and average.*/
#include <iostream>
using namespace std;
int main()
{
    int *ptrArr = new int[5];
    int sum = 0, average = 0, numberOfItem = 5;
    ptrArr[0] = 5;
    ptrArr[1] = 9;
    ptrArr[2] = 8;
    ptrArr[3] = 7;
    ptrArr[4] = 11;
    for (int i = 0; i < numberOfItem; i++)
    {
        cout << ptrArr[i];
        sum += ptrArr[i];
    }
    average = sum / numberOfItem;
    cout << "sum = " << sum << " | Average = " << average << endl;
    return 0;
}
