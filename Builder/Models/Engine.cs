namespace Builder.Models;

public class Engine {
    public Engine(int hp, int cylinder) {
        this._hp = hp;
        this._cylinder = cylinder;
    }

    private int _hp;
    public int Hp {
        get => _hp;
        set => _hp = value;
    }

    private int _cylinder;
    public int Cylinder {
        get => _cylinder;
        set => _cylinder = value;
    }
}
