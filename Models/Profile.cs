using System.ComponentModel.DataAnnotations;

namespace RecipeBook.Models
{
  public class Profile
  {
    public string Name { get; set; }
    [Url]
    public string Picture { get; set; }
  }
}