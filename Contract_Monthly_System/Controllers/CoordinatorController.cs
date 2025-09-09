using Contract_Monthly_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_System.Controllers
{
    public class CoordinatorController : Controller
    {
        public IActionResult Review()
        {
            List<CordinatorViewer> queue = new List<CordinatorViewer>()
            {
                new() {Lecturer = "Ronald Moyo",Month= "5" ,Total = 600 , State = ClaimState.Approved},
                new() {Lecturer = "Junior Rapi",Month= "6" ,Total = 800 , State = ClaimState.Submitted}


            }; 
            return View(queue);

        }
    }
}
