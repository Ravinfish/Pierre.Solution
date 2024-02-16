using System.Collections.Generic;
using System.Linq;
using Palace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Palace.Controllers
{
  public class BouquetsController : Controller
  {
    private readonly PalaceContext _db;
    public BouquetsController(PalaceContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Bouquet> model = _db.Bouquets.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Bouquet bouquet)
    {
      if (!ModelState.IsValid)
      {
        return View("Create");
      }
      else
      {
        bouquet.Price = CalculatePrice(bouquet.Size);
        _db.Bouquets.Add(bouquet);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    private decimal CalculatePrice(string size)
    {
      switch (size)
      {
        case "Small":
          return 15.99m;
        case "Medium":
          return 20.99m;
        case "Large":
          return 30.99m;
        case "X-Large":
          return 40.99m;
        default:
          return 0m;

      }
    }
    public ActionResult Details(int id)
    {
      Bouquet thisBouquet = _db.Bouquets.FirstOrDefault(bouquet => bouquet.BouquetId == id);
      // .Include(bouquet => bouquet.BouquetFlowers)
      // .ThenInclude(join => join.Flower)
      // .FirstOrDefault(bouquet => bouquet.BouquetId == id);
      return View(thisBouquet);
    }

  }
}