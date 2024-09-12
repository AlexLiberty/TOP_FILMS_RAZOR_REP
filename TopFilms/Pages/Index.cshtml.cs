using Microsoft.AspNetCore.Mvc.RazorPages;
using TopFilms.Models;
using TopFilms.Repositories.Interfaces;

namespace TopFilms.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;

        public IndexModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IList<Movie> Movie { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _movieRepository.GetAllMoviesAsync();
        }
    }
}
