/*22. Develop a program that performs various string manipulation tasks using the StringBuilder class from the java.lang package. Tasks may include concatenation, insertion, deletion, and reversing.*/
public class _22_StringManupulation {
    public static void main(String[] args) {
        // Create a StringBuilder object
        StringBuilder stringBuilder = new StringBuilder("Hello, ");

        // Concatenation: Append a string to the StringBuilder
        stringBuilder.append("World!");
        System.out.println("Concatenation Result: " + stringBuilder.toString());

        // Insertion: Insert a string at a specific position
        stringBuilder.insert(6, "Java ");
        System.out.println("Insertion Result: " + stringBuilder.toString());

        // Deletion: Delete a portion of the string
        stringBuilder.delete(0, 6);
        System.out.println("Deletion Result: " + stringBuilder.toString());

        // Reversing: Reverse the string
        stringBuilder.reverse();
        System.out.println("Reversed Result: " + stringBuilder.toString());
    }
}
