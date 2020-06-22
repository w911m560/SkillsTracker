using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                            "<h2>Coding skills to learn:</h2>" +
                            "<ol>" +
                                "<li>C#</li>" +
                                "<li>JavaScript</li>" +
                                "<li>Python</li>" +
                            "</ol>";
            return Content(html, "text/html");
        }


        //GET: /skills/form
        [HttpGet]
        [Route("form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/form'>" +

                          "<label for='codeDate'>Date: </label>" +
                          "<br>" +
                          "<input type='date' id='codeDate' name='codeDate' value='2020-01-01' min='2020-01-01'>" +

                          "<br>" +
                          "C#: " +
                          "<br>" +
                          "<select name='csharp' id='csharp'>" +
                              "<option value='basics'>Learning basics</option>" +
                              "<option value='makingApps'>Making apps</option>" +
                              "<option value='proficient'>Proficient</option>" +
                          "</select>" +

                          "<br>" +
                          "JavaScript: " +
                          "<br>" +
                          "<select name='javascript' id='javascript'>" +
                              "<option value='basics'>Learning basics</option>" +
                              "<option value='makingApps'>Making apps</option>" +
                              "<option value='proficient'>Proficient</option>" +
                          "</select>" +

                          "<br>" +
                          "Python: " +
                          "<br>" +
                          "<select name='python' id='python'>" +
                              "<option value='basics'>Learning basics</option>" +
                              "<option value='makingApps'>Making apps</option>" +
                              "<option value='proficient'>Proficient</option>" +
                          "</select>" +
                          "<br>" +

                          "<input type='submit' value='Submit' />" +
                          "</form>";

            return Content(html, "text/html");
        }

        //POST: /skills/form
        [HttpPost]
        [Route("form")]
        public IActionResult Skills(string codeDate, string csharp, string javascript, string python)
        {
            string html = $"<h1> {codeDate} </h1>" +
                            $"<ol>" +
                                $"<li> C#: {csharp} </li>" +
                                $"<li> JavaScript: {javascript} </li>" +
                                $"<li> Python: {python}</li>" +
                            "</ol>";
            return Content(html, "text/html");
        }

    }
}
