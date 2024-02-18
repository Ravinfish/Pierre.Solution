using System.Collections.Generic;
using System.Linq;
using Palace.Models;
using Palace.ViewModels;
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
      List<(int FlowerId, string Name, string Description)> flowerTypes = new List<(int, string, string)>
      {
        (1, "Rose", "A beautiful flower often associated with love and romance"),
        (2, "Tulip", "Colorful flowers symbolizing perfect love and springtime"),
        // Add more flower types with descriptions
      };


      FlowerViewModel viewModel = new FlowerViewModel
      {
        FlowerOptions = flowerTypes.Select(f => new SelectListItem
        {
          Value = f.FlowerId.ToString(),
          Text = f.Name + " - " + f.Description
        }).ToList()
      };

      return View(viewModel);
    }
    [HttpPost]
    public ActionResult Create(FlowerViewModel viewModel)
    {
      if (!ModelState.IsValid)
      {
        return View(viewModel);
      }

      if (viewModel.IsBouquet)
      {
        
        Flower selectedFlower = _db.Flowers.Find(viewModel.FlowerId);
        if (selectedFlower != null)
        {
          // Process adding flower to bouquet with specified name and size
          // You can access viewModel.BouquetName and viewModel.BouquetSize here
        }
      }
      else
      {
        
        Flower selectedFlower = _db.Flowers.Find(viewModel.FlowerId);
        if (selectedFlower != null)
        {
          // Process single flower purchase with specified quantity
          // You can access viewModel.Quantity here
        }
      }

      return RedirectToAction("Index");
    }
  }
}