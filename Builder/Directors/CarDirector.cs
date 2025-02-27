using Builder.Builders;
using Builder.Models;

public class CarDirector {
    private CarBuilder _builder;
    public CarDirector(CarBuilder builder) {
        this._builder = builder;
    }

    public void BuildSUV() {
        this._builder.SetSeats(4);
        this._builder.SetGps(true);
        this._builder.SetEngine(new Engine(250, 6));
    }

    public void BuildSportCar() {
        this._builder.SetSeats(2);
        this._builder.SetEngine(new Engine(300, 8));
    }
}
