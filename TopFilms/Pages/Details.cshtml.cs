using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TopFilms.Models;
using TopFilms.Repositories.Interfaces;

namespace TopFilms.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;

        public DetailsModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _movieRepository.GetMovieByIdAsync(id.Value);

            if (movie == null)
            {
                return NotFound();
            }

            Movie = movie;
            return Page();
        }
    }
}
