/*19. Create a custom exception class that extends java.lang.Exception. Then, write a program that demonstrates how to throw and catch instances of this custom exception. */
class CustomException extends Exception {
    // Constructor with a custom error message
    public CustomException(String message) {
        super(message);
    }
}

public class _19_CustomException {
    public static void main(String[] args) {
        try {
            int age = -5; // Assuming age cannot be negative
            if (age < 0) {
                throw new CustomException("Age cannot be negative.");
            }
            System.out.println("Age is valid: " + age);
        } catch (CustomException e) {
            System.out.println("Custom Exception Caught: " + e.getMessage());
        } catch (Exception e) {
            System.out.println("An unexpected error occurred: " + e.getMessage());
        }
    }
}
