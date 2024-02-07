using BV212_EF.NET_ADO.DataBase.Tables;

namespace BV212_EF.NET_ADO.DataBase;

public class OrdersDB
{
    public List<OrderRow> Orders { get; set; }
    public List<PriceRow> Prices { get; set; } // добавил букву s для симметрии
    public List<TaskRow> Tasks { get; set; }
    //происходила попытка доступа к члену объекта, который ещё не был инициализирован,
    //вызывалось исключение при попытке добавления нового объекта 
    public OrdersDB()//Здесь исправление - конструктор, который инициализирует списки при создании экземпляра класса OrdersDB
    {
        Orders = new List<OrderRow>();
        Prices = new List<PriceRow>();
        Tasks = new List<TaskRow>();
    }
}