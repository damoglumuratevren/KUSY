using KUSY.Services.Abstract;
using KUSY.Shared.Utilities.Results.ComplexType;
using Microsoft.AspNetCore.Mvc;

namespace KUSY.MVCV2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ISudentService _sudentService;

        public StudentController(ISudentService sudentService)
        {
            _sudentService = sudentService; 
        }

        public async Task<IActionResult> Index()
        {
            var rst=await _sudentService.GetAll();  
            if(rst.ResultStatus== ResultStatus.Success)
            {
                return View(rst.Data);
            }
            return View();
        }
    }
}
