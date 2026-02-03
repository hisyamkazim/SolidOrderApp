using SolidOrderApp.Application.Interfaces;
using SolidOrderApp.Domain.Entities;

namespace SolidOrderApp.Application.UseCases.Services;

public class DefaultOrderCalculatorService : IOrderCalculator
{
    public decimal CalculateTotal(Order order)
    {
        return order.Items.Sum(item => item.Price * item.Quantity);
    }
}
