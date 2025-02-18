using System;
using FactoryMethod.Entities;
using FactoryMethod.Factories;

NotificationFactory slacknotificationfactory = new SlackNotificationFactory();

INotification slackNotification = slacknotificationfactory.GenerateNotification("Hello I'm Slack notification");

slackNotification.Send();
