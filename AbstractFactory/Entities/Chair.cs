using AbstractFactory.Entities;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities;

public class Chair: Furniture, IFurniture {
    public Chair (decimal price): base(price) { }
}

public class ArtDecoChair: Chair {
    public ArtDecoChair(decimal price): base(price) {}
}

public class VictorianChair: Chair {
    public VictorianChair(decimal price): base(price) { }
}
