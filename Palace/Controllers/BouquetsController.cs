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
      List<Bouquet>  model = _db.Bouquets.ToList();
      return View(model);
    }
    
  }
}