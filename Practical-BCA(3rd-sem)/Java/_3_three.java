
// Demonstrate the concept of method overriding using a base class and a derived class.

class Shapes {
    public double calculateArea() {
        return 0.0;
    }
}

class Circle extends Shapes {
    private double radius;

    Circle(double r) {
        radius = r;
    }

    public double calculateArea() {
        return (3.14 * Math.pow((radius), 2));
    }
}

class Reactangle extends Shapes {
    private double length, width;

    Reactangle(double length, double width) {
        this.length = length;
        this.width = width;
    }

    public double calculateArea() {
        return length * width;
    }
}

public class _3_three {
    public static void main(String[] args) {
        Reactangle rectObj = new Reactangle(8.9, 8.6);
        Circle circObj = new Circle(5.57);
        System.out.println("Area of Reactangle is " + rectObj.calculateArea());

        System.out.println("Area of Circle is " + circObj.calculateArea());
    }
}
