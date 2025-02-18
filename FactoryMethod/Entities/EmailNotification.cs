using System;

namespace FactoryMethod.Entities;

public class EmailNotification: Notification, INotification {
    public EmailNotification(string text) : base(text) { }

    public void Send() {
        Console.WriteLine($"Message body: {_text}\nNotification has been sent");
    }

    public void Delete() {
        Console.WriteLine("Notification has been deleted");
    }
}