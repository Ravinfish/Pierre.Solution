using Microsoft.AspNetCore.Mvc;
using Palace.Models;
using System.Collections.Generic;
using System.Linq;

namespace Palace.Controllers;

public class HomeController : Controller
{
  private readonly PalaceContext _db;
  public HomeController(PalaceContext db)
  {
    _db = db;
  }
  [HttpGet("/")]
  public ActionResult Index()
  {
    // Bouquet[] bouquets = _db.Bouquets.ToArray();
    // Flower[] flowers = _db.Flowers.ToArray();
    // Dictionary<string, object[]> model = new Dictionary<string, object[]>();
    // model.Add("bouquets", bouquets);
    // model.Add("flowers", flowers);
    return View();
  }
}