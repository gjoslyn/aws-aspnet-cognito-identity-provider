using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;

namespace Samples.Pages
{
    public class IndexModel : PageModel
    {
        public string claimsHtml { get; private set; } = "None";

        public void OnGet()
        {
            if (!User.Identity.IsAuthenticated) return;

            var claims = new StringBuilder("<ul>");

            foreach (var claim in User.Claims)
            {
                claims.Append($"<li>{claim.Type} = {claim.Value}</li>");
            }

            claims.Append("</ul>");
            claimsHtml = claims.ToString();
        }
    }
}
