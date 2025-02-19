using AbstractFactory.Entities;

namespace AbstractFactory.Interfaces;

public interface IFurnitureFactory {
    public Chair CreateChair(decimal price);

    public CoffeeTable CreateCoffeeTable(decimal price);
}
