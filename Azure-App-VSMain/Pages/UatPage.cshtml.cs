using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Azure_App_VSMain.Pages
{
    public class UatPageModel : PageModel
    {
        private readonly ILogger<UatPageModel> _logger;
        private readonly IConfiguration _configuration;
        public UatPageModel(ILogger<UatPageModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        public void OnGet()
        {
            ViewData["Greethings"] = _configuration["Greethings"];
        }
    }
}
