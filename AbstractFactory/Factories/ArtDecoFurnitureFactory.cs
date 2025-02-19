using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using AbstractFactory.Entities;

namespace AbstractFactory.Factories;

public class ArtDecoFurnitureFactory: FurnitureFactory, IFurnitureFactory {
    public Chair CreateChair(decimal price) {
        return new ArtDecoChair(price);
    }
    public CoffeeTable CreateCoffeeTable(decimal price) {
        return new ArtDecoCoffeeTable(price);
    }
}
