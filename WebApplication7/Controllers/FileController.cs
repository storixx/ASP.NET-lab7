using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebApplication7.Controllers
{
    public class FileController : Controller
    {
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            var content = $"Name: {firstName}\nSurname: {lastName}";
            var bytes = Encoding.UTF8.GetBytes(content);
            return File(bytes, "text/plain", $"{fileName}.txt");
        }
    }
}