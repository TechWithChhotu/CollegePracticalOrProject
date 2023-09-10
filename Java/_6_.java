// create a package named "student" containing classes Student and Teacher. Import and use these classes in another package.
class InsufficientFundsException extends Exception {
    public InsufficientFundsException(String message) {
        super(message);// called exception class constructor
    }
}

class BankAccount {
    private double balance;

    public BankAccount(double initialBalance) {
        balance = initialBalance;
    }

    public void withdraw(double amount) throws InsufficientFundsException {
        if (amount > balance) {
            throw new InsufficientFundsException("Insufficient funds. Current balance: " + balance);
        }
        balance -= amount;
        System.out.println("Withdrawal successful. Remaining balance: " + balance);
    }
}

public class _6_ {
    public static void main(String[] args) {
        BankAccount account = new BankAccount(1000.0);

        try {
            account.withdraw(500.0); // Valid withdrawal
            account.withdraw(700.0); // This will throw InsufficientFundsException
        } catch (InsufficientFundsException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}
