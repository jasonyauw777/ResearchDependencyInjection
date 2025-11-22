using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class ExportWordService : IExportFileService
    {
        public void ExportFile(string message)
        {
            Console.WriteLine($"Exporting Word Document : {message}");
        }
    }
}
