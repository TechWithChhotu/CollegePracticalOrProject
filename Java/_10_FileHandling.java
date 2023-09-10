
// Wap to create a file in java
import java.io.File;
import java.io.IOException;

public class _10_FileHandling {
    public static void main(String[] args) {
        String filePath = "temp.txt"; // Specify the file path and name

        try {
            File file = new File(filePath);

            if (file.createNewFile()) {
                System.out.println("File created successfully.");
            } else {
                System.out.println("File already exists.");
            }
        } catch (IOException e) {
            System.err.println("Error creating the file: " + e.getMessage());
        }
    }
}