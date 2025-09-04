using System.ComponentModel.DataAnnotations;

namespace BlazorWASMDemoApp.Models;

public class OrderUpdateModel
{
    public int Id { get; set; }
    [Required]
    [MaxLength(20, ErrorMessage = "The order by should be less than 20 characters")]
    [MinLength(3, ErrorMessage = "The order by should have at least 3 characters")]
    public string NewName { get; set; }
}