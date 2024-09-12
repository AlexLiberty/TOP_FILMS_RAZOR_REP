using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TopFilms.Models;
using TopFilms.Repositories.Interfaces;

namespace TopFilms.Pages
{
    public class EditModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IWebHostEnvironment _appEnvironment;

        public EditModel(IMovieRepository movieRepository, IWebHostEnvironment appEnvironment)
        {
            _movieRepository = movieRepository;
            _appEnvironment = appEnvironment;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(IFormFile? imageFile)
        {
            ModelState.Remove(nameof(Movie.ImagePath));

            if (ModelState.IsValid)
            {
                var existingMovie = await _movieRepository.GetMovieByIdAsync(Movie.Id);

                if (existingMovie == null)
                {
                    return NotFound();
                }

                if (imageFile != null && imageFile.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_appEnvironment.WebRootPath, "Files");
                    var uniqueFileName = $"{Guid.NewGuid().ToString()}_{imageFile.FileName}";
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }
                    Movie.ImagePath = $"/Files/{uniqueFileName}";
                }
                else
                {
                    Movie.ImagePath = existingMovie.ImagePath;
                }

                await _movieRepository.UpdateMovieAsync(Movie);

                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
