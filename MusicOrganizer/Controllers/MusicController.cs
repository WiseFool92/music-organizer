using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class MusicController : Controller
  {
    [HttpGet("/categories/{categoryId}/music/{musicId}")] // The path now includes Category information, which ensures our routes are now RESTfully named.
    public ActionResult Show(int categoryId, int musicId) // Because the path includes both Item and Category IDs, we can locate the correct parent and child objects and pass them to our view in a Dictionary.
    {
      Music music = Music.Find(musicId);
      Category category = Category.Find(categoryId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("music", music);
      model.Add("category", category);
      return View(model);
    }


    [HttpGet("/categories/{categoryId}/music/new")] // The path now includes the ID of the Category we're adding a new Item to. Because it's in curly braces, we can grab this in our route's parameter to locate the Category object and pass it into the corresponding view
    public ActionResult New(int categoryId)
    {
      Category category = Category.Find(categoryId);
      return View(category);
    }

    [HttpPost("/music/delete")]
    public ActionResult DeleteAll()
    {
      Music.ClearAll();
      return View();
    }
  }
}