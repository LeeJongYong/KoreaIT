using DotNetNote.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DotNetNote.Controllers
{
    public class StronglyTypedConfigurationController : Controller
    {
        private DotNetNoteSettings _dnnSettings;
        public StronglyTypedConfigurationController(IOptions<DotNetNoteSettings> options)
        {
            _dnnSettings = options.Value;
        }

        public IActionResult Index()
        {
            ViewData["SiteName"] = _dnnSettings.SiteName;
            ViewBag.SiteUrl = _dnnSettings.SiteUrl;

            return View();
        }
    }
}
