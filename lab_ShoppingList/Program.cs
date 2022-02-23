// collection for menu of 8 or more items with prices
Console.WriteLine("Welcome to the Corner Store!");
Console.WriteLine("Listing of available items for quick delivery: ");
Console.WriteLine();
Dictionary<string, double> menuItems = new Dictionary<string, double>()
{
    {"eggs", 2.99},
    {"milk", 2.79},
    {"apples", 5.79},
    {"bread", 2.99},
    {"juice", 2.49},
    {"sugar", 3.99},
    {"flour", 2.99},
    {"butter", 4.99},
};

// Display available menu items
foreach (KeyValuePair<string, double> item in menuItems)
{
    Console.WriteLine($"{item.Key} -  {item.Value}");  // how to enter a tab
}

// collection for shopping list
List<string> shoppingList = new List<string>();
var addItem = "y";
var tryAgain = "y";
double orderTotal = 0.00;


while (addItem == "y" || tryAgain == "y")
{
    Console.WriteLine();
    Console.Write("Please enter an item by name: ");
    var itemInput = Console.ReadLine().ToLower();

    if (!menuItems.ContainsKey(itemInput))
    {
        Console.WriteLine($"Sorry, that item is not on the menu.  Would you like to try again (y/n)? ");
        tryAgain = Console.ReadLine().ToLower();
        Console.WriteLine();

        addItem = "n";
    }
    else
    {
        shoppingList.Add(itemInput);
        Console.WriteLine($"Added to cart: {itemInput} - ${menuItems[itemInput]} ");
        orderTotal = orderTotal + menuItems[itemInput];

        Console.WriteLine();
        Console.WriteLine("Would you like to add another item(y/n)?");
        addItem = Console.ReadLine().ToLower();

        tryAgain = "n";
    } 
}

Console.WriteLine();
Console.WriteLine("ShoppingList:");
Console.WriteLine("*************");

foreach (var i in shoppingList)
{
    Console.WriteLine($"{i} \t${menuItems[i]}");
    
}
Console.WriteLine("---------------");
Console.WriteLine($"Order total = {orderTotal}");

Console.ReadLine();