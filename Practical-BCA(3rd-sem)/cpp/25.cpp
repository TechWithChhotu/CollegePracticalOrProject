/*In a bank, different customers have savings account. Some customers may
have taken a loan from the bank. So bank always maintain information about
bank depositors and borrowers.
Design a Base class Customer (name, phone-number). Derive a class
Depositor(accno, balance) from Customer.
Again, derive a class Borrower (loan-no, loan-amt) from Depositor.
Write necessary member functions to read and display the details of ‘n’
customers.*/
#include <iostream>
using namespace std;
class Custome
{
protected:
    string Name, PhoneNumber;
};
class Depositor : protected Custome
{
protected:
    string AccountNumber;
    int balance;
};
class Borrower : protected Depositor
{
    int LoanNumber, LoanAmount;

public:
    void InputCustomerDetails()
    {
        fflush(stdin);
        cout << "-:Enter Customer Details:- " << endl;
        cout << "Name      :  ";
        getline(cin, Name);
        cout << "Phone Num.:  ";
        getline(cin, PhoneNumber);
        cout << "A/c Number:  ";
        getline(cin, AccountNumber);
        cout << "Balance   :  ";
        cin >> balance;
        cout << "Loan Number: ";
        cin >> LoanNumber;
        cout << "Loan Amount: ";
        cin >> LoanAmount;
        cout << "---------------------------" << endl;
    }
    void DisplayDetails()
    {
        cout << "\n-: Details of Customer:- \n"
             << endl;
        cout << "Name      :  " << Name << endl;
        cout << "Phone Num.:  " << PhoneNumber << endl;
        cout << "A/c Number:  " << AccountNumber << endl;
        cout << "Balance   :  " << balance << endl;
        cout << "\nLoan Number: " << LoanNumber << endl;
        cout << "Loan Amount: " << LoanAmount << endl;
        cout << "---------------------------" << endl;
    }
};
int main()
{
    int N, i;
    cout << "How many customer details you want to enter: ";
    cin >> N;
    Borrower B[N];
    for (i = 0; i < N; i++)
        B[i].InputCustomerDetails();
    for (i = 0; i < N; i++)
        B[i].DisplayDetails();
    return 0;
}
