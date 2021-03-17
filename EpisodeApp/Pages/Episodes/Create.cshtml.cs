using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EpisodeApp.Data;
using WebApplication1;

namespace EpisodeApp.Pages.Episodes
{
    public class CreateModel : PageModel
    {
        private readonly EpisodeApp.Data.EpisodesContext _context;

        public CreateModel(EpisodeApp.Data.EpisodesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Episode Episode { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Episode.Add(Episode);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
