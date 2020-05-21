using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class CategoriesController : Controller
  {
    
    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> allCategories = Category.GetAll();
      return View(allCategories);
    }

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/categories")] // Creates categories
    public ActionResult Create(string categoryName)
    {
      Category newCategory = new Category(categoryName);
      return RedirectToAction("Index");
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>(); // Create a new Dictionary called model because a Dictionary can hold multiple key-value pairs.
      Category selectedCategory = Category.Find(id);
      List<Music> categoryMusic = selectedCategory.Music; // Add both the Category and its associated Music to this Dictionary.
      model.Add("category", selectedCategory); // These will be stored with the keys "category" and "Music".
      model.Add("music", categoryMusic);
      return View(model); // The Dictionary, which is named model, will be passed into View().
    }
    // This one creates new Music within a given Category, not new Categories:
    [HttpPost("/categories/{categoryId}/music")]
    public ActionResult Create(int categoryId, string musicDescription) // The method now takes two arguments: the categoryId we passed into a hidden form field and an musicDescription that contains the user's form input.
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId); // Using the categoryId provided as an argument, we locate the Category object our new Music should belong to and call it foundCategory.
      Music newMusic = new Music(musicDescription); // We then create a new Music object with the user's form input.
      foundCategory.AddMusic(newMusic); // We add the newMusic to the foundCategory with our existing AddMusic() method.
      List<Music> categoryMusic = foundCategory.Music; // We retrieve all other Music that correspond to this category and add it to our model. We do this because the view we'll render at the end of this route requires this information.
      model.Add("music", categoryMusic);
      model.Add("category", foundCategory); // We also add the foundCategory to our model.
      return View("Show", model); // Finally, we pass in our model data to View(), instructing it to render the Category detail page, which is the Show.cshtml view.
    }

    [HttpPost("/categories/delete")]
    public ActionResult DeleteAll()
    {
      Category.ClearAll();
      return View();
    }
  }
}