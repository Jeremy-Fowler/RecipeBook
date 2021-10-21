using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using RecipeBook.Models;

namespace RecipeBook.Repositories
{
  public class FamiliesRepository
  {
    private readonly IDbConnection _db;

    public FamiliesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Family> GetAll()
    {
      var sql = "SELECT * FROM families;";
      return _db.Query<Family>(sql).ToList();
    }
  }
}