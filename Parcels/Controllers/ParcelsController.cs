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
      //Prevent a 'Parcel' object from being created if any of the form fields is blank.
      if (((typeof(len) == int) && (typeof(width) == int) && (typeof(depth) == int) && (typeof(weight) == int)) && ((len != null) && (width != null) && (depth != null) && (weight != null)))
      {
        Parcel myParcel = new Parcel(len, width, depth, weight);
        
        //return View("Index", myParcel);
        return RedirectToAction("Index", myParcel);
      } 
      else 
      {
        return "Error creating new Parcel: One or more inputs are invalid.";
      }
    }

  }
}