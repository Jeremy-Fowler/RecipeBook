using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Models
{
  public class Family
  {
    public int Id { get; set; }
    public string CreatorId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required] 
    public int Members { get; set; }
    public Profile Owner { get; set; }
  }
}