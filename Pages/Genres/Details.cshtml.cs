using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNET_Visual_Studio.Models;

namespace ASPNET_Visual_Studio.Pages.Genres
{
    public class DetailsModel : PageModel
    {
        private readonly ASPNET_Visual_Studio.Models.ASPNET_Visual_StudioContext _context;

        public DetailsModel(ASPNET_Visual_Studio.Models.ASPNET_Visual_StudioContext context)
        {
            _context = context;
        }

        public Genre Genre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genre = await _context.Genre.FirstOrDefaultAsync(m => m.Id == id);

            if (Genre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
