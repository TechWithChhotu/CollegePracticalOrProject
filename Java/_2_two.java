/* 2> Implement inheritance by creating a subclass of Car, such as 
 * ElectricCar, with additional attributes and methods.*/
class Car {
    String name;
    String manufactured;
    int YearOfmanufactured;
}

class ElectricCar extends Car {
    boolean isElectric = true;
    boolean Driver;
    int numberOfBattries;
    int chargingType;

    void printAboutElectricCar() {
        System.out.println("This car is electric" + " Non-Driver/Driver ");
    }
}

public class _2_two {
    public static void main(String[] args) {
        // Create an instance of the ElectricCar Class:
        ElectricCar eCar = new ElectricCar();
        /*
         * Set values for all variables in the ElectricCar object
         */
        eCar.name = "Tesla";
        eCar.YearOfmanufactured = 1986;
        eCar.chargingType = 30;
        if (eCar instanceof ElectricCar) {
            ((ElectricCar) (eCar)).printAboutElectricCar();
        } else {
            System.out.println("Not an electric car");
        }
        ;
        // Print out each variable value stored inside the ElectricCar Object:
        System.out.printf("%s %d",
                eCar.name,
                eCar.YearOfmanufactured);
        System.out.println("\n\n");
    }

}
