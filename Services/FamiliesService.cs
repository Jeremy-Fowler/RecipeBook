using System;
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

    public Family GetById(int familyId)
    {
      Family foundFamily = _familiesRepository.GetById(familyId);
      if(foundFamily == null)
      {
        throw new Exception("Hey! no family!");
      }
      return foundFamily;
    }

    public Family Create(Family familyData)
    {
      return _familiesRepository.Create(familyData);
    }
  }
}