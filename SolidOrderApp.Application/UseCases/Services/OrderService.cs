using SolidOrderApp.Application.Interfaces;
using SolidOrderApp.Infrastructure.Repositories;
using SolidOrderApp.Domain.Entities;

namespace SolidOrderApp.Application.UseCases.Services;

public class OrderService
{
    private readonly IOrderCalculator _calculator;
    private readonly IOrderRepository _orderRepository;

    private readonly INotificationService _notificationService;

    public OrderService(IOrderCalculator calculator, IOrderRepository orderRepository, INotificationService notificationService)
    {
        _calculator = calculator;
        _orderRepository = orderRepository;
        _notificationService = notificationService;
    }

    public void CreateOrder(Order order)
    {
        var total = _calculator.CalculateTotal(order);
        _orderRepository.Save(order);
        _notificationService.Notify($"Order with ID {order.Id} has been created with total amount {total}.");

        // Notification logic can be added here using _notificationService
    }
}
