package Week1_Design_and_Priciples.FactoryMethodPattern;


    public class PdfDocument implements Document {
        public void open() {
            System.out.println("Opening PDF Document...");
        }
    }

