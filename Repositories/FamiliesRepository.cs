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

    internal Family GetById(int familyId)
    {
      string sql = @"
      SELECT
      f.*,
      a.*
      FROM families f
      JOIN accounts a ON f.creatorId = a.Id 
      WHERE f.id = @familyId
      ";
      return _db.Query<Family, Account, Family>(sql, (f, a) =>
      {
        f.Owner = a;
        return f; 
      }, new {familyId}).FirstOrDefault();
    }

    internal Family Create(Family familyData)
    {
      string sql = @"
      INSERT INTO families(name, members, creatorId)
      VALUES(@Name, @Members, @CreatorId);";
      int id = _db.ExecuteScalar<int>(sql, familyData);
      familyData.Id = id;
      return familyData;
    }
  }
}