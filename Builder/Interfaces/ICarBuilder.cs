using Builder.Models;

namespace Builder.Interfaces;

public interface ICarBuilder {
    void SetGps(bool gps);
    void SetSeats(int seatCount);
    void SetEngine(Engine engine);
}
