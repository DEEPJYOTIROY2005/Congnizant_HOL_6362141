package Week1_Design_and_Priciples.FactoryMethodPattern;

public class PdfDocumentFactory extends DocumentFactory {
    public Document createDocument() {
        return new PdfDocument();
    }
}