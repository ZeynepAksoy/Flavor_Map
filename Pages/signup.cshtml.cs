using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flavor_Map.Pages;

public class signup : PageModel
{
    private readonly ILogger<signup > _logger;

    public signup (ILogger<signup > logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}