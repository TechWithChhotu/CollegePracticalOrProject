/*21> Write a Java program that creates and starts multiple threads. You can use the Thread class from the java.lang package to achieve this. Ensure that the threads perform some concurrent tasks. */
public class _21_MultipleThreads {
    public static void main(String[] args) {
        // Create and start multiple threads
        for (int i = 1; i <= 3; i++) {
            Thread thread = new NumberPrintingThread("Thread " + i);
            thread.start();
        }
    }
}

class NumberPrintingThread extends Thread {
    public NumberPrintingThread(String name) {
        super(name);
    }

    public void run() {
        for (int i = 1; i <= 3; i++) {
            System.out.println(getName() + ": " + i);
            // Introduce a slight delay to simulate concurrent execution
            try {
                Thread.sleep(100);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}
