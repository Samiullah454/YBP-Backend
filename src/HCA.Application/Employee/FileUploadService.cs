using Abp.Dependency;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCA.Employee
{
    public interface IFileUploadService
    {
        Task<string> SaveFileAsync(string fileName, byte[] content, int technicianId);
    }

    public class FileUploadService : IFileUploadService, ITransientDependency
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public FileUploadService(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<string> SaveFileAsync(string fileName, byte[] content, int technicianId)
        {
            // Create a folder based on TechnicianId if it does not exist
            var rootPath = _hostingEnvironment.WebRootPath; // Get the root path of the hosted application
            var technicianFolder = Path.Combine(rootPath, "uploads", "TechnicianEmployee", technicianId.ToString());

            if (!Directory.Exists(technicianFolder))
            {
                Directory.CreateDirectory(technicianFolder);
            }

            // Save the file within the technician's folder
            var filePath = Path.Combine(technicianFolder, fileName);

            await File.WriteAllBytesAsync(filePath, content);

            return filePath;
        }
    }

}
