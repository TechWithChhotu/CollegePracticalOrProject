/*20. Define an enumeration in Java using the enum keyword. Write a program that utilizes this enumeration to represent days of the week and perform operations like finding the next day or checking if a given day is a weekday or weekend. */
// Define the DaysOfWeek enumeration
enum DaysOfWeek {
    // List the days of the week as enum constants
    SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY;

    // Method to find the next day
    public DaysOfWeek getNextDay() {
        // Use the values() method to get an array of all enum constants
        DaysOfWeek[] days = DaysOfWeek.values();
        int nextIndex = (this.ordinal() + 1) % days.length;
        return days[nextIndex];
    }

    // Method to check if a given day is a weekday
    public boolean isWeekday() {
        return this != SATURDAY && this != SUNDAY;
    }

    // Method to check if a given day is a weekend day
    public boolean isWeekend() {
        return this == SATURDAY || this == SUNDAY;
    }
}

public class _20_Enum {
    public static void main(String[] args) {
        // Use the DaysOfWeek enumeration
        DaysOfWeek today = DaysOfWeek.WEDNESDAY;

        // Find the next day
        DaysOfWeek nextDay = today.getNextDay();
        System.out.println("Next day after " + today + " is " + nextDay);

        // Check if a given day is a weekday or weekend day
        System.out.println(today + " is a weekday: " + today.isWeekday());
        System.out.println(today + " is a weekend day: " + today.isWeekend());
    }
}
