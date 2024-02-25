
//13> Write a java program to implement Dice Rolling Game
import java.util.Random;
import java.util.Scanner;

public class _13_DiceGame {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();

        int totalRolls = 0;
        int totalWins = 0;

        System.out.println("Welcome to the Dice Rolling Game!");
        System.out.println("Enter the number of times you want to roll the dice: ");
        int numRolls = scanner.nextInt();

        for (int i = 0; i < numRolls; i++) {
            // Generate a random number between 1 and 6
            int diceRoll = random.nextInt(6) + 1;

            System.out.println("Roll " + (i + 1) + ": You rolled a " + diceRoll);
            // Check if the roll is a win (e.g., rolling a 6)
            if (diceRoll == 6) {
                System.out.println("Congratulations! You win!");
                totalWins++;
            }
            totalRolls++;
        }
        double winPercentage = (double) totalWins / totalRolls * 100;
        System.out.println("Total rolls: " + totalRolls);
        System.out.println("Total wins: " + totalWins);
        System.out.println("Win percentage: " + winPercentage + "%");
        scanner.close();
    }
}
