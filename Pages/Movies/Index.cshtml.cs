using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNET_Visual_Studio.Models;

namespace ASPNET_Visual_Studio.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ASPNET_Visual_Studio.Models.ASPNET_Visual_StudioContext _context;

        public IndexModel(ASPNET_Visual_Studio.Models.ASPNET_Visual_StudioContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
