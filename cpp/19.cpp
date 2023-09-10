// Class Matrix {int a[3][3]; Public: //methods; };
// Let m1 and m2 are two matrices. Find out m3=m1+m2 (use operator overloading).
#include <iostream>
using namespace std;
class Matrix
{
    int a[3][3];

public:
    void Input_mat()
    {
        cout << "Enter elements of the matrix: \n";
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                cin >> a[i][j];
    }
    Matrix operator+(Matrix x)
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                x.a[i][j] = a[i][j] + x.a[i][j];
        return x;
    }
    void Show_mat()
    {
        cout << "\n-:Matrix:-\n";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                cout << a[i][j] << " ";
            cout << endl;
        }
    }
};
int main()
{
    Matrix m1, m2, m3;
    m1.Input_mat();
    m2.Input_mat();
    m3 = m2 + m1;
    m3.Show_mat();
    return 0;
}