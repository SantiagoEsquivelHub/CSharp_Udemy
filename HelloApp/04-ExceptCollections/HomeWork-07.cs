/*
=======================================
Sales Analysis with LINQ and Exceptions
==========================================
*/
// 🏆 Exercise:
// Develop a system to analyze a company's sales using collections and LINQ.
// You will have a "Sale" class with the following properties:
// - Product (public)
// - Category (public)
// - Amount (public)
//
// Also a list with 6 fictitious sales.
// What you will have to develop is:
// 1. Filter and display sales with an amount greater than 1000.
// 2. Group the sales by category and calculate the total sales per category.
// 3. Handle exceptions in case of errors when processing data.

partial class Program
{
    static void SalesAnalysis()
    {
        List<Sale> sales = new List<Sale> {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };


        try
        {
            // Filter and display sales with an amount greater than 1000.

            var amountGreater1000 = sales.Where(sale => sale.Amount > 1000);
            foreach (var sale in amountGreater1000)
            {
                WriteLine($"Product: {sale.Product}, Category: {sale.Category}, Amount: {sale.Amount:C}");
            }

            // Group the sales by category and calculate the total sales per category.

            var salesByCategory = sales
            .GroupBy(sale => sale.Category)
            .Select(groupCategories => new { Category = groupCategories.Key, TotalAmount = groupCategories.Sum(sale => sale.Amount) });

            foreach (var group in salesByCategory)
            {
                WriteLine($"Category: {group.Category}, Sales Total: {group.TotalAmount:C}");
            }
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}