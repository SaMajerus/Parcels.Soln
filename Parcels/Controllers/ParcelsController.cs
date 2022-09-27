using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
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

    [HttpPost("/items")]
    public ActionResult Create(int len, int w)
    {
      Parcel myParcel = new Parcel(description);
      return RedirectToAction("Index");
    }

  }
}