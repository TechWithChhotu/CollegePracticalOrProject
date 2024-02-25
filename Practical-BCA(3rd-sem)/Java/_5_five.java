// Define an interface Calculator with methods for addition, subtraction, multiplication, and division. Implement this interface in a CalculatorImpl class.
// Define the Calculator interface
interface Calculator {
    double add(double num1, double num2);

    double subtract(double num1, double num2);

    double multiply(double num1, double num2);

    double divide(double num1, double num2);
}

class CalculatorImpl implements Calculator {
    @Override // this is not be must
    public double add(double num1, double num2) {
        return num1 + num2;
    }

    public double subtract(double num1, double num2) {
        return num1 - num2;
    }

    @Override
    public double multiply(double num1, double num2) {
        return num1 * num2;
    }

    @Override
    public double divide(double num1, double num2) {
        if (num2 == 0) {
            throw new IllegalArgumentException("Division by zero is not allowed.");
        }
        return num1 / num2;
    }
}

public class _5_five {
    public static void main(String[] args) {
        Calculator calculator = new CalculatorImpl();
        double num1 = 10.0;
        double num2 = 5.0;
        System.out.println("Addition: " + calculator.add(num1, num2));
        System.out.println("Subtraction: " + calculator.subtract(num1, num2));
        System.out.println("Multiplication: " + calculator.multiply(num1, num2));
        try {
            System.out.println("Division: " + calculator.divide(num1, num2));
        } catch (IllegalArgumentException e) {
            System.err.println(e.getMessage());
        }
    }
}
