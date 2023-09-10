// Implement a try-catch block to handle an ArrayIndexOutOfBoundsException when accessing an out-of-bounds index in an array.
public class _7_seven {
    public static void main(String[] args) {
        int[] numbers = { 1, 2, 3 };

        try {
            int element = numbers[5]; // Attempt to access an out-of-bounds index
            System.out.println("Element: " + element);
        } catch (ArrayIndexOutOfBoundsException e) {
            // Handle the exception
            System.err.println("Error: " + e.getMessage());
        }

        System.out.println("The program continues after the exception handling.");
    }
}
