
import java.awt.*;
import java.awt.image.BufferedImage;
import javax.swing.*;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class _15_AwtImage {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Image Display");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(400, 400);
            // Load the image
            BufferedImage image = loadImage("C:\\Users\\C Kumar\\Pictures\\Birds.jpg"); // Replace with your image file
                                                                                        // // path
            // Create a custom JPanel to display the image
            JPanel imagePanel = new JPanel() {
                @Override
                protected void paintComponent(Graphics g) {
                    super.paintComponent(g);
                    if (image != null) {
                        g.drawImage(image, 0, 0, getWidth(), getHeight(), this);
                    }
                }
            };
            frame.add(imagePanel);
            frame.setVisible(true);
        });
    }

    // Load an image from a file
    private static BufferedImage loadImage(String filePath) {
        try {
            return ImageIO.read(new File(filePath));
        } catch (IOException e) {
            e.printStackTrace();
            return null;
        }
    }
}
