using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcel")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcel/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(int len, int width, int depth, int weight)
    {

      Parcel myParcel = new Parcel(len, width, depth, weight); 
      return RedirectToAction("Index", myParcel); 
    }

  }
}
