using FactoryMethod.Entities;

namespace FactoryMethod.Factories;

public class SlackNotificationFactory: NotificationFactory {
    public override INotification GenerateNotification (string text) {
        return new SlackNotification(text);
    }
}
