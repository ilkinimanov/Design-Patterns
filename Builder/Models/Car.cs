namespace Builder.Models;

public class Car {
    private int _seats;
    public int Seats {
        get => _seats;
        set => _seats = value;
    }

    private bool _gps;
    public bool Gps {
        get => _gps;
        set => _gps = value;
    }

    private Engine _engine;
    public Engine Engine {
        get => _engine;
        set => _engine = value;
    }
}
