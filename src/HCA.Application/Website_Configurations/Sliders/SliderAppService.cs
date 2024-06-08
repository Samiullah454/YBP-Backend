using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using HCA.WebSite_Configuration.Slider;
using HCA.Website_Configurations.Sliders.Dto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

public class SliderAppService : AsyncCrudAppService<Slider, SliderDto, int, PagedAndSortedResultRequestDto, SliderDto>
{
    private readonly IWebHostEnvironment _hostingEnvironment;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SliderAppService(IRepository<Slider, int> repository, IWebHostEnvironment hostingEnvironment, IHttpContextAccessor httpContextAccessor)
        : base(repository)
    {
        _hostingEnvironment = hostingEnvironment;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<string> UploadImageAsync(IFormFile file)
    {
        if (file == null || file.Length == 0)
            throw new ArgumentException("File is empty");

        var uploadsFolderPath = Path.Combine(_hostingEnvironment.WebRootPath, "websitesData");
        if (!Directory.Exists(uploadsFolderPath))
        {
            Directory.CreateDirectory(uploadsFolderPath); // Create the folder if it doesn't exist
        }

        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        var filePath = Path.Combine(uploadsFolderPath, fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        // Get the base URL of the application
        var request = _httpContextAccessor.HttpContext.Request;
        var baseUrl = $"{request.Scheme}://{request.Host}";

        // Construct the complete image URL with the domain or localhost
        var imageUrl = $"{baseUrl}/websitesData/{fileName}";

        return imageUrl;
    }
}