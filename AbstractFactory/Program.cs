using AbstractFactory.Entities;
using AbstractFactory.Factories;

public class Program {
    public static void Main() {
        ArtDecoFurnitureFactory factory = new ArtDecoFurnitureFactory();
        Chair chairart = factory.CreateChair(1000);
    }
}
