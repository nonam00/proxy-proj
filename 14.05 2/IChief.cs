namespace _14._05_2;
public interface IChief
{
    IDictionary<int, string> GetStatuses();
    IEnumerable<Order> GetOrders();
}