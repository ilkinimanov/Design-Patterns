using FactoryMethod.Entities;
using FactoryMethod.Factories;

namespace FactoryMethod.Factories;

public class EmailNotificationFactory: NotificationFactory {
    public override INotification GenerateNotification(string text) {
        return new EmailNotification(text);
    }
}
