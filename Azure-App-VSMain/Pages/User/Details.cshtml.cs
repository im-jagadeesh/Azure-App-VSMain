using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Azure_App_VSMain.Data;

namespace Azure_App_VSMain.Pages.User
{
    public class DetailsModel : PageModel
    {
        private readonly Azure_App_VSMain.Data.AppDBContext _context;

        public DetailsModel(Azure_App_VSMain.Data.AppDBContext context)
        {
            _context = context;
        }

        public Azure_App_VSMain.Data.User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (user is not null)
            {
                User = user;

                return Page();
            }

            return NotFound();
        }
    }
}
