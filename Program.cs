
using FactoryMethodDesignPattern;

Console.WriteLine("Factory Method Design Pattern");

IWriterFactoryMethod writerFactoryMethod = new WriterFactoryMethod();
IWriter pdfwriter = writerFactoryMethod.GetWriterInstance("PDF");
pdfwriter.Write("Write to pdf");

IWriter csvwriter = writerFactoryMethod.GetWriterInstance("CSV");
csvwriter.Write("Write to csv");