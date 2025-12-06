using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Azure_App_VSMain.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IConfiguration _configuration;

        public PrivacyModel(ILogger<PrivacyModel> logger, IConfiguration configuration )
        {
            _logger = logger;            
            _configuration = configuration;

        }

        public void OnGet()
        {
            //ViewData["Greethings"] = _configuration.GetValue<string>("Greethings");
            ViewData["Greethings"] = _configuration["Greethings"];
            //throw new Exception("This is a test exception for demonstration purposes for Azure");
        }
    }

}
