using Microsoft.AspNetCore.Mvc;

namespace AspNetFeatureFolders.Areas.Members.Features.Search
{
    public partial class SearchController : Controller
    {
        public virtual IActionResult Index()
        {
            return View();
        }
    }
}
