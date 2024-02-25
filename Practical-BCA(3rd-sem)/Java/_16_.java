// in this , i will show uses of this operator and Math.PI, where Math is predefine obj and PI is a data arrtributes of that Math class.

class Circle {
    int radius;

    public Circle(int radius) {
        this.radius = radius;
    }

    public void DisplayArea() {
        System.out.println("The area is " + (3.14 * radius * radius));
    }

    public void parimeter() {
        System.out.println("The paremeter is " + (2 * Math.PI * radius));

    }
}

public class _16_ {
    public static void main(String[] args) {
        Circle c = new Circle(8);
        c.DisplayArea();
        c.parimeter();
    }
}
