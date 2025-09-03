using System.ComponentModel;

namespace BlazorWASMDemoApp.Models;

public class FoodModel
{
    public int Id { get; set; }
    [DisplayName("Meal")]
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
