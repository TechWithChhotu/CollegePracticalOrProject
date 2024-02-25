
//12> write a java program to generate random number between 0 to 100
import java.util.Random;

public class _12_Random {
    public static void main(String[] args) {
        Random random = new Random();

        // Generate a random integer between 0 and 100
        int randomNumber = random.nextInt(100);
        System.out.println("Random Number: " + randomNumber);
    }
}
