using System;
using Builder.Models;
using Builder.Builders;

public class Program {
    public static void Main() {
        CarBuilder carBuilder = new CarBuilder();

        CarDirector carDirector = new CarDirector(carBuilder);

        carDirector.BuildSUV();

        Car car = carBuilder.GetProduct();
    }
}
