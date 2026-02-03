using SolidOrderApp.Domain.Entities;
namespace SolidOrderApp.Application.Interfaces;

public interface IOrderCalculator
{
    decimal CalculateTotal(Order order);
}
