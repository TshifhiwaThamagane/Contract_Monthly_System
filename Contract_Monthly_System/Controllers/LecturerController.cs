using Contract_Monthly_System.Models;


using Microsoft.AspNetCore.Mvc;


namespace Contract_Monthly_System.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult SubmitClaim()
        {
            LectureViewer modelviewer_ = new LectureViewer
            {
                
                LecturerName = "Tshifhiwa Thamagane",
               
                HourlyRate = 700.00,
                Claims = new List<ClaimListViewer>

                {
                    new ClaimListViewer {Month = "8" , Module="PROG2A" ,Hours=40, Total= 1000, State=ClaimState.Approved},
                    new ClaimListViewer {Month = "9" , Module="PROG2B" ,Hours=20, Total= 1000, State=ClaimState.Verified}
                }
            };
            return View(modelviewer_);
        }
    }
}
