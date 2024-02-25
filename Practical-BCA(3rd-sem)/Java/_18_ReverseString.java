/*18. Write a Java program that reverses a given string without using any library functions or additional data structures. Utilize the String class from the java.lang package. */
public class _18_ReverseString {
    public static void main(String[] args) {
        String inputString = "Ramadhin College Sheikhpura";

        // Convert the string to a character array
        char[] charArray = inputString.toCharArray();

        // Reverse the character array in-place
        int left = 0;
        int right = charArray.length - 1;

        while (left < right) {
            // Swap characters at the left and right indices
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;

            // Move the indices towards the center
            left++;
            right--;
        }

        // Convert the character array back to a string
        String reversedString = new String(charArray);

        System.out.println("Original String: " + inputString);
        System.out.println("Reversed String: " + reversedString);
    }
}