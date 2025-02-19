using AbstractFactory.Entities;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories;

public class VictorianFurnitureFactory: FurnitureFactory, IFurnitureFactory {
    public Chair CreateChair(decimal price) {
        return new VictorianChair(price);
    }

    public CoffeeTable CreateCoffeeTable(decimal price) {
        return new VictorianCoffeeTable(price);
    }
}
