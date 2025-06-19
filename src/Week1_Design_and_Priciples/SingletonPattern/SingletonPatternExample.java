package Week1_Design_and_Priciples.SingletonPattern;

public class SingletonPatternExample {
    public static void main(String[] args) {
        Logger logger1 = Logger.getInstance();
        logger1.log("This is the first log message");

        Logger logger2 = Logger.getInstance();
        logger2.log("This is the second log message");

        if (logger1 == logger2) {
            System.out.println("Same logger instance is used");
        } else {
            System.out.println("Different logger instances are used");
        }
    }
}
