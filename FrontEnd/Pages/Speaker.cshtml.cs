using System.Threading.Tasks;
using ConferenceDTO;
using FrontEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class SpeakerModel : PageModel
{
    private readonly ILogger<SpeakerModel> _logger;
    private readonly IApiClient _apiClient;

    public SpeakerResponse Speaker { get; set; }

    public SpeakerModel(ILogger<SpeakerModel> logger, IApiClient apiClient)
    {
        _apiClient = apiClient;
        _logger = logger;
    }

    public async Task<IActionResult> OnGet(int id)
    {
        Speaker = await _apiClient.GetSpeakerAsync(id);

        if (Speaker == null)
        {
            return NotFound();
        }

        return Page();
    }
}