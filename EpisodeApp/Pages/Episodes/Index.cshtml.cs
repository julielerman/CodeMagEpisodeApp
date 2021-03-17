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
    public class IndexModel : PageModel
    {
        private readonly EpisodeApp.Data.EpisodesContext _context;

        public IndexModel(EpisodeApp.Data.EpisodesContext context)
        {
            _context = context;
        }

        public IList<Episode> Episode { get;set; }

        public async Task OnGetAsync()
        {
            Episode = await _context.Episode.ToListAsync();
        }
    }
}
