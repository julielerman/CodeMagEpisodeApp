using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EpisodeApp.Data;
using WebApplication1;

namespace EpisodeApp.Pages.Episodes
{
    public class DetailsModel : PageModel
    {
        private readonly EpisodeApp.Data.EpisodesContext _context;

        public DetailsModel(EpisodeApp.Data.EpisodesContext context)
        {
            _context = context;
        }

        public Episode Episode { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Episode = await _context.Episode.FirstOrDefaultAsync(m => m.EpisodeId == id);

            if (Episode == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
