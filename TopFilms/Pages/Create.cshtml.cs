using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopFilms.Models;
using TopFilms.Repositories.Interfaces;

namespace TopFilms.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IWebHostEnvironment _appEnvironment;
        public CreateModel(IMovieRepository movieRepository, IWebHostEnvironment appEnvironment)
        {
            _movieRepository = movieRepository;
            _appEnvironment = appEnvironment;
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(IFormFile? imageFile)
        {
            ModelState.Remove("Movie.ImagePath");
            if (ModelState.IsValid)
            {
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
                    Movie.ImagePath = "https://ikinogo.biz/uploads/mini/short/21/3b7daac61aa607060ec1a212750594.webp";
                }

                await _movieRepository.AddMovieAsync(Movie);

                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
