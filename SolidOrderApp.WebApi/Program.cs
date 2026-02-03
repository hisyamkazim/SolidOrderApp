// See https://aka.ms/new-console-template for more information

var calculator = new SolidOrderApp.Application.UseCases.Services.DefaultOrderCalculatorService();
var orderRepository = new SolidOrderApp.Infrastructure.Repositories.InMemoryOrderRepository();
var notificationService = new SolidOrderApp.Application.UseCases.Services.EmailNotificationService();

var orderService = new SolidOrderApp.Application.UseCases.Services.OrderService(calculator, orderRepository, notificationService);

var order = new SolidOrderApp.Domain.Entities.Order
{
    Id = 1,
    Items = new List<SolidOrderApp.Domain.Entities.OrderItem>
    {
        new SolidOrderApp.Domain.Entities.OrderItem { Name = "Keyboard", Price = 350000, Quantity = 1 },
        new SolidOrderApp.Domain.Entities.OrderItem { Name = "Mouse", Price = 150000, Quantity = 2 }
    }
};

orderService.CreateOrder(order);
