using ExamApp.Data;
using ExamApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<QuestionAnswer> model = ExamData.Questions;
            return View(model);
        }

        public IActionResult Details(int id)
        {
            QuestionAnswer? item = ExamData.Questions.FirstOrDefault(q => q.Number == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}