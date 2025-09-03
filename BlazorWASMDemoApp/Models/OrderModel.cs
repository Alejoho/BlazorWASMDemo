using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorWASMDemoApp.Models;

public class OrderModel
{
    public int Id { get; set; }
    [Required]
    [MaxLength(20, ErrorMessage = "The order by should be less than 20 characters")]
    [MinLength(3, ErrorMessage = "The order by should have at least 3 characters")]
    [DisplayName("Ordered By")]
    public string OrderedBy { get; set; }

    [DisplayName("Ordered On")]
    public DateTime Date { get; set; } = DateTime.UtcNow;

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "You need to select a meal from the list")]
    [DisplayName("Meal")]
    public int FoodId { get; set; }

    [Required]
    [Range(1, 10, ErrorMessage = "You only can take up to 10 meals")]
    public int Quantity { get; set; }

    public decimal Total { get; set; }
}