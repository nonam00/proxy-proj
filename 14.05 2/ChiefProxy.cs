namespace _14._05_2;
public class ChiefProxy : IChief
{
    private readonly Chief _chief;
    private IDictionary<int, string?> _statuses;

    public ChiefProxy(Chief chief)
    {
        _chief = chief;
    }

    public IEnumerable<Order> GetOrders()
    {
        Console.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm:ss} GetOrders()\n"); //логирование 

        return _chief.GetOrders();
    }

    public IDictionary<int, string> GetStatuses()
    {
        if (_statuses is null)
        {
            _statuses = _chief.GetStatuses(); //кэширование
        }
        return _statuses;
    }
}