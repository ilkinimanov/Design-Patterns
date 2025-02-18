namespace FactoryMethod.Entities;

public class SlackNotification : Notification, INotification
{
    public SlackNotification(string text) : base(text) { }

    public void Send() {
        Console.WriteLine($"Message body: {_text}");
    }

    public void Delete() {
        Console.WriteLine("Notification has been deleted");
    }
}
