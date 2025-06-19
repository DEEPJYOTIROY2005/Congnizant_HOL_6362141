package Week1_Design_and_Priciples.FactoryMethodPattern;

public class WordDocument implements Document{
    @Override
    public void open() {
        System.out.println("Opening  Word document");
    }
}
