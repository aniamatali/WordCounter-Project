using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace Find.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/project/results")]
    public ActionResult Results()
    {
      RepeatCounter newCount = new RepeatCounter (Request.Form["inputWord"], Request.Form["inputSentence"]);
      return View (newCount);
    }
  }
}
