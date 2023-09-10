//Create two threads that print even and odd numbers alternately using synchronized methods.
class NumberPrinter {
    private int count = 1;
    private int maxCount;

    public NumberPrinter(int maxCount) {
        this.maxCount = maxCount;
    }

    public synchronized void printEven() {
        while (count <= maxCount) {
            if (count % 2 == 0) {
                System.out.println("Even: " + count);
                count++;
                notify(); // Notify the other thread to run
            } else {
                try {
                    wait(); // Wait for the other thread to notify
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
            }
        }
    }

    public synchronized void printOdd() {
        while (count <= maxCount) {
            if (count % 2 != 0) {
                System.out.println("Odd: " + count);
                count++;
                notify(); // Notify the other thread to run
            } else {
                try {
                    wait(); // Wait for the other thread to notify
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
            }
        }
    }
}

public class _8_Threads {
    public static void main(String[] args) {
        NumberPrinter numberPrinter = new NumberPrinter(5);
        Thread evenThread = new Thread(() -> {
            numberPrinter.printEven();
        });
        Thread oddThread = new Thread(() -> {
            numberPrinter.printOdd();
        });
        evenThread.start();
        oddThread.start();
    }
}
