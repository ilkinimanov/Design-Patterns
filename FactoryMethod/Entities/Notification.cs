namespace FactoryMethod.Entities;

public class Notification {
    protected string _text;

    public Notification(string text) {
        this._text = text;
    }
}
