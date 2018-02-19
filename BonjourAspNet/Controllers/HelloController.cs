using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                    "<option value='english'>English</option>" +
                    "<option value='spanish'>Spanish</option>" +
                    "<option value='bosnian'>Bosnian</option>" +
                    "<option value='german'>German</option>" +
                    "<option value='french'>French</option>" +
                "</select>" +
                "<input type='submit' value='Greet me' />" +
                "</form>";

            return Content(html, "text/html");
            //return Redirect("/Hello/Goodbye");
        }

        public static string CreateMessage(string name, string language)
        {
            switch (language)
            {
                case "spanish":
                    return string.Format("<h1>Hola {0}</h1>", name);
                case "bosnian":
                    return string.Format("<h1>Zdravo {0}</h1>", name);
                case "german":
                    return string.Format("<h1>Hallo {0}</h1>", name);
                case "french":
                    return string.Format("<h1>Bonjour {0}</h1>", name);
                default:
                    return string.Format("<h1>Hello {0}</h1>", name);
            }
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name, string language)
        {
            return Content(CreateMessage(name, language), "text/html");
        }

        [Route("/Hello/{name}")]
        public IActionResult Index2(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}