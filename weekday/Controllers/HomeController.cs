using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Weekday.Models;

namespace Weekday.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/weekday/results")]
    public ActionResult Results()
    {
      Weekdayer newWeekday = new Weekdayer (int.Parse(Request.Form["inputMonth"]),int.Parse(Request.Form["inputDay"]),int.Parse(Request.Form["inputYear"]));
      return View (newWeekday);
    }
  }
}
