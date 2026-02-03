using SolidOrderApp.Application.Interfaces;

namespace SolidOrderApp.Application.UseCases.Services;

public class EmailNotificationService : INotificationService
{
    public void Notify(string message)
    {
        // Implementation for sending email
        Console.WriteLine($"Sending Email: '{message}'");
    }
}
