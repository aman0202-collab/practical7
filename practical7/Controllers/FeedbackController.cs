
using Microsoft.AspNetCore.Mvc;
using practical7.Models;
using System.Collections.Generic;

namespace practical7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>();

        // Display Feedback Page
        public IActionResult Index()
        {
            return View(feedbackList);
        }

        // Submit Feedback
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);

                TempData["Message"] =
                    "Feedback submitted successfully!";

                return RedirectToAction("Index");
            }

            return View(feedbackList);
        }
    }
}
