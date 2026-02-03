using SolidOrderApp.Domain.Entities;
namespace SolidOrderApp.Infrastructure.Repositories;

public class InMemoryOrderRepository : IOrderRepository
{
    private readonly List<Order> _storage = new();

    public void Save(Order order)
    {
        _storage.Add(order);
        Console.WriteLine($"Order with ID {order.Id} saved in memory repository.");
    }
}
