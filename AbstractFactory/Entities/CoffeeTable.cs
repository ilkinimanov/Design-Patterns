using System.ComponentModel;
using AbstractFactory.Entities;

public class CoffeeTable: Furniture {
    public CoffeeTable(decimal price): base(price) { }   
}

public class VictorianCoffeeTable: CoffeeTable {
    public VictorianCoffeeTable(decimal price): base(price) { }
}

public class ArtDecoCoffeeTable: CoffeeTable {
    public ArtDecoCoffeeTable(decimal price): base(price) {}
}
