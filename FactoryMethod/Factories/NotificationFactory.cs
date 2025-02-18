namespace FactoryMethod.Factories;

public abstract class NotificationFactory {
    public abstract INotification GenerateNotification(string text);
}
