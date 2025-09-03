namespace BlazorWASMDemoApp.Models;

public class OrderResponseModel
{
    public List<OrderModel> Orders { get; set; }
    public List<FoodModel> Foods { get; set; }
}