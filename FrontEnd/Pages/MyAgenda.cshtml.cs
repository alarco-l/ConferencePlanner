using System.Collections.Generic;
using System.Threading.Tasks;
using ConferenceDTO;
using FrontEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace FrontEnd.Pages
{
    [Authorize]
    public class MyAgendaModel : IndexModel
    {
        public MyAgendaModel(ILoggerFactory loggerFactory, IApiClient client)
            : base(loggerFactory.CreateLogger<IndexModel>(), client)
        {

        }

        protected override async Task<List<SessionResponse>> GetSessionsAsync()
        {
            return await _apiClient.GetSessionsByAttendeeAsync(User.Identity.Name);
        }
    }
}