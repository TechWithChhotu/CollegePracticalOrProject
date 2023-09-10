
//14> write a java program to print current time, year & month using Date & calendar.
import java.util.Date;
import java.util.Calendar;

public class _14_DateAndTime {
    public static void main(String[] args) {
        Date currentDate = new Date();

        System.out.println("Current Date and Time (using java.util.Date): " + currentDate);

        Calendar calendar = Calendar.getInstance();

        int year = calendar.get(Calendar.YEAR);
        int month = calendar.get(Calendar.MONTH); // Note: Months start from 0 (January)
        int dayOfMonth = calendar.get(Calendar.DAY_OF_MONTH);
        int hourOfDay = calendar.get(Calendar.HOUR_OF_DAY);
        int minute = calendar.get(Calendar.MINUTE);
        int second = calendar.get(Calendar.SECOND);

        System.out.println("\nUsing Calendar:");
        System.out.println("Year: " + year);
        System.out.println("Month: " + (month + 1)); // Adding 1 to get the correct month
        System.out.println("Day of Month: " + dayOfMonth);
        System.out.println("Hour of Day: " + hourOfDay);
        System.out.println("Minute: " + minute);
        System.out.println("Second: " + second);

        // Adding 10 days to the current date using Calendar
        calendar.add(Calendar.DAY_OF_MONTH, 10);
        Date futureDate = calendar.getTime();

        System.out.println("\nFuture Date (after adding 10 days): " + futureDate + "\n");
    }
}
