using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Flavor_Map.Pages;

public class iletisim : PageModel
{
    private readonly ILogger<iletisim> _logger;

    public iletisim(ILogger<iletisim> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}