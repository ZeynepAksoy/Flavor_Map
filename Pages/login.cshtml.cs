using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flavor_Map.Pages;

public class login : PageModel
{
    private readonly ILogger<login> _logger;

    public login(ILogger<login> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}