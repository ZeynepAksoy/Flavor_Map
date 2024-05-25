using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flavor_Map.Pages;

public class hakkimda : PageModel
{
    private readonly ILogger<hakkimda> _logger;

    public hakkimda(ILogger<hakkimda> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}