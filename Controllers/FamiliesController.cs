using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.Models;
using RecipeBook.Services;

namespace RecipeBook.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class FamiliesController : ControllerBase
  {
    private readonly FamiliesService _familiesService;

    public FamiliesController(FamiliesService familiesService)
    {
      _familiesService = familiesService;
    }

    [HttpGet]
    public ActionResult<List<Family>> GetAll()
    {
      try
      {
          var families = _familiesService.GetAll();
          return Ok(families);   
      }
      catch (System.Exception e)
      {
          
          return BadRequest(e.Message);
      }
    }
  }
}