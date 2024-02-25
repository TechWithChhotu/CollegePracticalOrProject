/*23. Create a Java program that demonstrates autoboxing and unboxing of primitive data types using classes from the java.lang package, such as Integer, Double, and Boolean. */
public class _23_AutoBoxingAndUnBoxing {
    public static void main(String[] args) {
        /* ===============AutoBoxing============== */
        int intValue = 42;
        Integer integerObject = intValue; // Autoboxing int to Integer class
        System.out.println("Autoboxing: int to Integer: " + integerObject);

        double doubleValue = 3.14;
        Double doubleObject = doubleValue; // Autoboxing double to Double class
        System.out.println("Autoboxing: double to Double: " + doubleObject);

        boolean booleanValue = true;
        Boolean booleanObject = booleanValue; // Autoboxing boolean to Boolean class
        System.out.println("Autoboxing: boolean to Boolean: " + booleanObject);

        /* ===============Unboxing============== */
        Integer intWrapper = 99;
        int unboxedInt = intWrapper; // Unboxing Integer to int type
        System.out.println("Unboxing: Integer to int: " + unboxedInt);

        Double doubleWrapper = 2.718;
        double unboxedDouble = doubleWrapper; // Unboxing Double to double type
        System.out.println("Unboxing: Double to double: " + unboxedDouble);

        Boolean booleanWrapper = Boolean.FALSE;
        boolean unboxedBoolean = booleanWrapper; // Unboxing Boolean to boolean type
        System.out.println("Unboxing: Boolean to boolean: " + unboxedBoolean);
    }
}
