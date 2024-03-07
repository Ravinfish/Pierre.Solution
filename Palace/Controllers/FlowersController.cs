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
  public class FlowersController : Controller
  {
    private readonly PalaceContext _db;
    public FlowersController(PalaceContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Flower> model = _db.Flowers.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    
    [HttpPost]
    public ActionResult Create(Flower Flower)
    {
      List<(int FlowerId, string Type, string Description, decimal Price)> flowerTypes = new List<(int, string, string, decimal)>
      {
        (1, "Rose", "A beautiful flower often associated with love and romance", 3.99m),
        (2, "Tulip", "Colorful flowers symbolizing perfect love and springtime", 2.99m),
        (3, "Sunflower", "Large, bright flowers that resemble the sun and symbolize adoration and loyalty", 4.99m),
        (4, "Lily", "Elegant flowers with a sweet fragrance often used in weddings and funerals", 5.99m),
        (5, "Daisy", "Simple yet cheerful flowers with a yellow center and white petals", 2.99m),
        (6, "Carnation", "Popular flowers available in a variety of colors, symbolizing love and fascination", 1.99m),
        (7, "Orchid", "Exotic flowers known for their stunning beauty and elegance", 7.99m),
        (8, "Hydrangea", "Clusters of small flowers in various colors, symbolizing gratitude and heartfelt emotions", 3.99m),
        (9, "Peony", "Fragrant flowers with large, delicate petals, often used in bridal bouquets", 3.99m),
        (10, "Chrysanthemum", "Long-lasting flowers available in a wide range of colors, symbolizing joy and longevity", 5.99m)
        // Add more flower types with descriptions as needed
      };

      ViewBag.FlowerOptions = flowerTypes.Select(f => new SelectListItem
      {
        Value = f.FlowerId.ToString(),
        Text = $"{f.Type} - ${f.Price}",
      }).ToList();
      
      return View();
     
    }



  
  }
}