using System.Collections.Generic;
using Builder.Interfaces;
using Builder.Models;


namespace Builder.Builders;

public class CarBuilder: ICarBuilder {
    private Car _car;

    public CarBuilder() {
        this.Reset();
    }

    public void Reset() {
        this._car = new Car();
    }

    public void SetGps(bool gps) {
        this._car.Gps = gps;
    }

    public void SetSeats(int seatCount) {
        this._car.Seats = seatCount;
    }

    public void SetEngine(Engine engine) {
        this._car.Engine = engine;
    }

    public Car GetProduct() {
        Car car = this._car;

        this.Reset();

        return car;
    }
}
