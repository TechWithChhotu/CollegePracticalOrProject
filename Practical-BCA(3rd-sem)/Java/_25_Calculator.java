import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class _25_Calculator extends Frame implements ActionListener {
    private TextField displayField;
    private String operator;
    private double operand1, operand2, result;

    public _25_Calculator() {
        operator = "";
        operand1 = operand2 = result = 0.0;

        setTitle("Simple Calculator");
        setSize(300, 400);
        setLayout(new BorderLayout());

        displayField = new TextField();
        displayField.setEditable(false);
        add(displayField, BorderLayout.NORTH);

        Panel buttonPanel = new Panel();
        buttonPanel.setLayout(new GridLayout(4, 4));

        String[] buttonLabels = {
                "7", "8", "9", "/",
                "4", "5", "6", "*",
                "1", "2", "3", "-",
                "0", ".", "=", "+"
        };

        for (String label : buttonLabels) {
            Button button = new Button(label);
            button.addActionListener(this);
            buttonPanel.add(button);
        }

        add(buttonPanel, BorderLayout.CENTER);

        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosing(java.awt.event.WindowEvent windowEvent) {
                System.exit(0);
            }
        });

        setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        String command = e.getActionCommand();

        if (Character.isDigit(command.charAt(0)) || command.equals(".")) {
            displayField.setText(displayField.getText() + command);
        } else if (command.equals("C")) {
            displayField.setText("");
            operator = "";
            operand1 = operand2 = result = 0.0;
        } else if (command.equals("=")) {
            operand2 = Double.parseDouble(displayField.getText());
            calculateResult();
            displayField.setText(Double.toString(result));
            operand1 = result;
            operator = "";
        } else {
            operator = command;
            operand1 = Double.parseDouble(displayField.getText());
            displayField.setText("");
        }
    }

    private void calculateResult() {
        switch (operator) {
            case "+":
                result = operand1 + operand2;
                break;
            case "-":
                result = operand1 - operand2;
                break;
            case "*":
                result = operand1 * operand2;
                break;
            case "/":
                if (operand2 != 0) {
                    result = operand1 / operand2;
                } else {
                    displayField.setText("Error: Division by zero");
                    operator = "";
                    operand1 = operand2 = result = 0.0;
                }
                break;
        }
    }

    public static void main(String[] args) {
        new _25_Calculator();
    }
}
