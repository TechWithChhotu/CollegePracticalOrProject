/*3> Implement a class to represent a Bank Account with private
member variables and public methods for deposit and withdrawal.*/
#include <iostream>
using namespace std;
class PNB
{
	float amount;
	string accountHolderName;
	string acNumber;

public:
	PNB(string name, string mob, float amount = 0)
	{
		this->amount = amount;
		acNumber = mob;
		accountHolderName = name;
		cout << "Account open success!" << endl;
	}
	string deposit(float a, string number)
	{
		if (number == acNumber)
		{
			amount += a;
			return "deposit successfully";
		}
		else
			return "deposit failed";
	}
	string withdrawal(float a, string holder, string number)
	{
		if (accountHolderName == holder && number == acNumber)
		{
			amount -= a;
			return "withdrawal successfully";
		}
		else
			return "withdrawal failed! try again";
	}
	float getbalance(string accountNumber, string holder)
	{
		if (accountNumber == acNumber && accountHolderName == holder)
			return amount;
		else
			return 0;
	}
};
int main()
{
	PNB obj("chhotu", "8920785456");
	cout << obj.deposit(10000, "8920785456") << endl;
	cout << obj.withdrawal(5000, "chhotu", "8920785456") << endl;
	cout << obj.getbalance("8920785456", "chhotu") << endl;
}
