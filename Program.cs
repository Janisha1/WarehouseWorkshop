using WarehouseWorkshop;

var apple = new Item("Apple", 0.15m);
var pear = new Item("Pear", 0.15m);
var orange = new Item("Orange", 0.20m);
var banana = new Item("Banana", 0.25m);

var warehouse = new Warehouse();

warehouse.AddItem(apple, 30);
warehouse.AddItem(pear, 20);
warehouse.AddItem(orange, 15);
warehouse.AddItem(banana, 25);



Console.WriteLine($"Items added: {apple.Name} is {apple.UnitPrice} each");
Console.WriteLine($"Items added: {pear.Name} is {pear.UnitPrice} each");
Console.WriteLine($"Items added: {orange.Name} is {orange.UnitPrice} each");
Console.WriteLine($"Items added: {banana.Name} is {banana.UnitPrice} each");

var appleStock = new Stock(apple, 25);

Console.WriteLine(appleStock.Item.Name);
