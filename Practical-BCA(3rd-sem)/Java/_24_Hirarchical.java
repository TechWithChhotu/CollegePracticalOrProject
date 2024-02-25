/*24. demonstrating hierarchical inheritance, we have a base class Vehicle and two derived classes, Car and Bike. Each class has its own methods, and the program creates objects of both Car and Bike */

// Base class
class Vehicle {
    String type;

    Vehicle(String type) {
        this.type = type;
    }

    void start() {
        System.out.println(type + " is starting.");
    }

    void stop() {
        System.out.println(type + " is stopping.");
    }
}

// Derived class 1
class Car extends Vehicle {
    Car() {
        super("Car");
    }

    void drive() {
        System.out.println("Car is driving.");
    }
}

// Derived class 2
class Bike extends Vehicle {
    Bike() {
        super("Bike");
    }

    void ride() {
        System.out.println("Bike is riding.");
    }
}

public class _24_Hirarchical {
    public static void main(String[] args) {
        // Create objects of the derived classes
        Car myCar = new Car();
        Bike myBike = new Bike();

        // Demonstrate methods from the base and derived classes
        myCar.start();
        myCar.drive();
        myCar.stop();

        myBike.start();
        myBike.ride();
        myBike.stop();
    }
}
