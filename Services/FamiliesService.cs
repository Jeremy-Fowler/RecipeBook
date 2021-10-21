using System.Collections.Generic;
using RecipeBook.Models;
using RecipeBook.Repositories;

namespace RecipeBook.Services
{
  public class FamiliesService
  {
    private readonly FamiliesRepository _familiesRepository;

    public FamiliesService(FamiliesRepository familiesRepository)
    {
      _familiesRepository = familiesRepository;
    }

    public List<Family> GetAll()
    {
      return _familiesRepository.GetAll();
    }
  }
}