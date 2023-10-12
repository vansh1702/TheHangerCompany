using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TheHangerCompany.Controllers
{
    public class TheHangerCompanyController : Controller
    {
        // 
        // GET: /TheHangerCompany/

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        // 
        // GET: /TheHangerCompany/Welcome/ 

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";    //commented out the previous code
        //}

        // GET: /TheHangerCompany/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");   //changing so as for a new output
        //}

        /*public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");     //made the changes in the code
        }*/
    }
}
