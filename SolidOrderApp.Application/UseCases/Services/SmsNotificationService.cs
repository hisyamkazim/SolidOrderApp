namespace SolidOrderApp.Application.UseCases.Services;

public class SmsNotificationService
{
    public void Notify(string message)
    {
        // Implementation for sending SMS
        Console.WriteLine($"Sending SMS: '{message}'");
    }
}
