package Week1_Design_and_Priciples.FactoryMethodPattern;

public class ExcelDocumentFactory extends DocumentFactory {
    public Document createDocument() {
        return new ExcelDocument();
    }
}