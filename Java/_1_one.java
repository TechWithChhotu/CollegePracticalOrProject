/*1> Create a class representing a Car with attributes like make, model, and year. Implement methods to set and get these attributes. */

class Cars {
    private String carMake; // car's make?
    private String carModel;// car's model

    private int carYear;// year of manufacture

    public void setCar(String newMake, String newModel, int year) {
        this.carMake = newMake;
        this.carModel = newModel;
        this.carYear = year;
    }

    public String getCarMake() {
        return (this.carMake);
    }

    public String getCarModel() {
        return (this.carModel);
    }

    public int getCarYear() {
        return (this.carYear);
    }
}

public class _1_one {
    public static void main(String[] args) {
        Cars obj = new Cars();
        // setter
        obj.setCar("BMW", "BMW2023O.2", 2023);
        System.out.println("The Make is: " + obj.getCarMake());
        System.out.println("The model is: " + obj.getCarModel());
        System.out.println("The yaer is: " + obj.getCarYear());
    }
}
