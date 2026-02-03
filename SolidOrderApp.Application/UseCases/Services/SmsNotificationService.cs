using SolidOrderApp.Application.Interfaces;

namespace SolidOrderApp.Application.UseCases.Services;

public class SmsNotificationService : INotificationService
{
    public void Notify(string message)
    {
        // Implementation for sending SMS
        Console.WriteLine($"Sending SMS: '{message}'");
    }
}
