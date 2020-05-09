using System.Collections.Generic;
using System.Threading.Tasks;
using ConferenceDTO;
using FrontEnd.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

public class SearchModel : PageModel
{
    private readonly ILogger<SearchModel> _logger;
    private readonly IApiClient _apiClient;

    public string Term { get; set; }
    public List<SearchResult> SearchResults { get; set; }

    public SearchModel(ILogger<SearchModel> logger, IApiClient apiClient)
    {
        _logger = logger;
        _apiClient = apiClient;
    }

    public async Task OnGetAsync(string term)
    {
        Term = term;
        SearchResults = await _apiClient.SearchAsync(term);
    }
}