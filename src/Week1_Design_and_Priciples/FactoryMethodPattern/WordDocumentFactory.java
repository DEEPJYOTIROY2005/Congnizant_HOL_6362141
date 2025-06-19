package Week1_Design_and_Priciples.FactoryMethodPattern;

public class WordDocumentFactory extends DocumentFactory {
    public Document createDocument() {
        return new WordDocument();
    }
}