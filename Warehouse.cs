namespace WarehouseWorkshop;

public class Warehouse
{
    public List<Stock> Stock { get; }

    public Warehouse()
    {
        Stock = new List<Stock>();
    }

    public void AddItem(Item item, int amount)
    {
        foreach (var stock in Stock)
        {
            if (stock.Item == item)
            {
                stock.Quantity += amount;
                return;
            }
        }
        Stock.Add(new Stock(item, amount));
    }
}