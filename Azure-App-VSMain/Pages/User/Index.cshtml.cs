using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Azure_App_VSMain.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly Azure_App_VSMain.Data.AppDBContext _context;

        public IndexModel(Azure_App_VSMain.Data.AppDBContext context)
        {
            _context = context;
        }

        public IList<Azure_App_VSMain.Data.User> Users { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
