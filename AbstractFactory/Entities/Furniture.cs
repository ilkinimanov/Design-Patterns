namespace AbstractFactory.Entities;

public abstract class Furniture {
    protected decimal _price;

    public Furniture(decimal price) {
        _price = price;
    }
}
