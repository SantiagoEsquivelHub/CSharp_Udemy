partial class Program
{
    static void InventoryManager()
    {
        Console.WriteLine("1. Buy product");
        Console.WriteLine("2. Exit");
        Console.WriteLine("");
        Console.WriteLine("Enter an option: ");
        int? option = int.Parse(Console.ReadLine()!);

        if (option == 1)
        {
            string[] products = ["Monitor", "Mouse", "Keyboard"];
            int[] stock = [10, 20, 30];
            double[] prices = [250.50, 20.50, 45.00];

            Console.WriteLine("Products Inventory");
            Console.WriteLine("------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product: {products[i]}, Stock: {stock[i]}, Price: {prices[i]:C}");
            }

            Console.WriteLine("Enter the product that you wish to buy: ");
            string? searchedProduct = Console.ReadLine();

            Console.WriteLine("Enter the quantity that you wish to buy: ");
            int? quantity = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i])
                    {
                        double total = (double)(quantity * prices[i]);
                        int? remainingStock = stock[i] - quantity;
                        Console.WriteLine($"Successful purchase: {total}");
                        Console.WriteLine($"Stock for product {products[i]} is {remainingStock}");
                    }
                    else
                    {
                        Console.WriteLine("There is not enought stock available");

                    }
                }
            }
        }
        else if (option == 2)
        {
            Console.WriteLine("Thank you for your visit");
        }
        else
        {
            Console.WriteLine("Invalid option");
        }

    }
}