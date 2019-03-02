using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PageFilter.Pages
{
    public class ModelWithAuthFilter
    {
        [Authorize]
        public class ModelWithAuthFilterModel : PageModel
        {
            public IActionResult OnGet() => Page();
        }
    }
}
