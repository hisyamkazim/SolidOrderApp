using SolidOrderApp.Domain.Entities;
namespace SolidOrderApp.Infrastructure.Repositories;

public interface IOrderRepository
{
    void Save(Order order);
}
