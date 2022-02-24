using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
    public class FileDemoController : Controller
    {
        private IHostingEnvironment _environment;
        private ILogger<FileDemoController> _logger;

        public FileDemoController(IHostingEnvironment environment, ILogger<FileDemoController> logger)
        {
            _environment = environment;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult FileUploadDemo()
        {
            _logger.LogInformation("여기<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FileUploadDemo(ICollection<IFormFile> files)
        {
            var uploadFolder = Path.Combine(_environment.WebRootPath, "files");

            foreach (var file in files)
            {
                var fileName = Path.GetFileName(ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.ToString().Trim('"'));

                using(var fileStream = new FileStream(Path.Combine(uploadFolder, fileName), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }

            return View();
        }

        public FileResult FileDownloadDemo(string fileName)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(_environment.WebRootPath, "files") + "\\" + fileName);

            return File(fileBytes, "application/octer-stream", fileName);
        }
    }
}
