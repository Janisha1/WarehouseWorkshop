namespace WarehouseWorkshop;

public class Item 
{
    public string Name { get; set; }
    public decimal UnitPrice {get; set; }

    public Item(string name, decimal unitPrice)
    {
        Name = name;
        UnitPrice = unitPrice;
    }
}