/*8> Create a template function to find the maximum value from an array of different data types (int, double, etc.).*/
#include <iostream>
using namespace std;
template <typename T>
T findMax(const T arr[], int size)
{
    if (size <= 0)
        throw invalid_argument("Array size must be greater than 0.");
    T maxVal = arr[0];
    for (int i = 1; i < size; ++i)
    {
        if (arr[i] > maxVal)
            maxVal = arr[i];
    }
    return maxVal;
}
int main()
{
    int intArray[] = {1, 5, 3, 8, 2};
    double doubleArray[] = {2.5, 1.1, 5.7, 3.3};
    int intMax = findMax(intArray, sizeof(intArray) / sizeof(intArray[0]));
    double doubleMax = findMax(doubleArray, sizeof(doubleArray) / sizeof(doubleArray[0]));
    cout << "Maximum value in intArray: " << intMax << endl;
    cout << "Maximum value in doubleArray: " << doubleMax << endl;
    return 0;
}
