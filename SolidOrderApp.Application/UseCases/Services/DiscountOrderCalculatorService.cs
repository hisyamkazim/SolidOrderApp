using SolidOrderApp.Application.Interfaces;
using SolidOrderApp.Domain.Entities;
namespace SolidOrderApp.Application.UseCases.Services;

public class DiscountOrderCalculatorService : IOrderCalculator
{

    public decimal CalculateTotal(Order order)
    {
        var total = order.Items.Sum(item => item.Price * item.Quantity);
        return total * 0.9m; // Apply a 10% discount
    }
}