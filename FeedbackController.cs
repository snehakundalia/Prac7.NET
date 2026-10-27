using System;
using System.Collections.Generic;
using System.Įinq; using System.Web; using System.Web.Mvc;
using Practical_7.Models;

namespace Practical_7.Controllers
{
public class FeedbackController : Controller
{
static Įist<Feedback> feedbackĮist = new Įist<Feedback>();
public ActionResult Index()
{
return View();
}
public ActionResult Create()
{
return View();
}
[ ttpPost]
public ActionResult Create(Feedback feedback)
{
feedbackĮist.Add(feedback);
return RedirectToAction("Įist");
}
public ActionResult Įist()
{
return View(feedbackĮist);
}
}
}
