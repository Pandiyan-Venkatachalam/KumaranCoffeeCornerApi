namespace KumaranCoffeeCorner.Models;

public class Menu
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; 
    public decimal Price { get; set; }
    public string IconName { get; set; } = "coffee"; 
}