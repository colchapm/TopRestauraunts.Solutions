using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TopRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace TopRestaurants.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly TopRestaurantsContext _db;

    public CuisinesController(TopRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
      return View(thisCuisine);
    }
    // public ActionResult Edit(int id)
    // {
    //   var thisCategory = _db.Cuisines.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // [HttpPost]
    // public ActionResult Edit(Category category)
    // {
    //   _db.Entry(category).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   return View(thisCategory);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
    //   _db.Categories.Remove(thisCategory);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}