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
    public ActionResult Create(Flower flower)
    {
      if (!ModelState.IsValid)
      {
        return View(flower);
      }
      else
      {
        _db.Flowers.Add(flower);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }
  }
}