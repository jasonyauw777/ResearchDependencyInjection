using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class ExportProcessor
    {
        private readonly IExportFileService _exportFileService;
        
        public ExportProcessor(IExportFileService exportFileService)
        {
            _exportFileService = exportFileService;
        }
        public void Export(string filename) 
        {
            _exportFileService.ExportFile(filename);
        }
    }
}
