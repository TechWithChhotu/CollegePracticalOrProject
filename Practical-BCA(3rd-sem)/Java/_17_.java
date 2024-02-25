
// in this, use Scanner class with input types like int, char, string with in also intoduce & fix buffore problem
import java.util.Scanner;

public class _17_ {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        /* ================nextInt=============== */
        System.out.print("Enter a number: ");
        int num = input.nextInt();
        System.out.println("Enter number is " + num);

        /* ================next.charAt=============== */
        System.out.print("Enter a character: ");
        char ch = input.next().charAt(0);
        System.out.println("Entered character is " + ch);

        /* ================nextLine=============== */
        input.nextLine();
        System.out.print("What is your name: ");
        String str = input.nextLine();
        System.out.println("You entered name is :" + str);

        /* ================next=============== */
        System.out.print("Enter hobbies: ");
        String hobies = input.next();
        System.out.println("Entered hobbies is " + hobies);

        /* ================ReadMultipleLines=============== */
        input.nextLine();
        System.out.println("Enter multiple lines string: ");
        String multLines = "";
        while (true) {

            String temp = input.nextLine();
            if (temp == "") {
                break;
            }
            multLines += temp;
        }
        System.out.println("Enter strings are " + multLines);
        input.close();
    }
}
