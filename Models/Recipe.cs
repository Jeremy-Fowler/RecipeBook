using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Models
{
  public class Recipe
  {
    public int Id { get; set; }
    public int FamilyId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public Family Family { get; set; }
  }
}