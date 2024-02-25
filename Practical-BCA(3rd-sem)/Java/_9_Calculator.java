// Build a simple console-based calculator application that takes user input for two numbers and an operator, then performs the operation.
class calculator {

    public int add(int n, int m) {
        return n + m;
    }

    public int sub(int n, int m) {
        return n - m;
    }

    public int mult(int n, int m) {
        return n * m;
    }

    public double div(double n, double m) {
        return n / m;
    }
}

public class _9_Calculator {
    public static void main(String[] args) {
        calculator calculate = new calculator();
        System.out.println("add: " + calculate.add(8, 9));
        System.out.println("sub: " + calculate.sub(15, 9));
        System.out.println("div: " + calculate.div(15, 2));
        System.out.println("mult: " + calculate.mult(7, 5));
    }

}
