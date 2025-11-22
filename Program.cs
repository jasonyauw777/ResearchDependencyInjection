using DependencyInjection;
using DependencyInjection.Controllers;
using DependencyInjection.Enums;
using DependencyInjection.Interfaces;
using DependencyInjection.Services;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("DependencyInjection Research !");
            // Console App Implementation
            Console.WriteLine("Export PDF = 1");
            Console.WriteLine("Export Word = 2");
            Console.WriteLine("Input Number : ");

            int numberInput = int.Parse(Console.ReadLine());

            ExportProcessor exportProcessor = null;

            if (numberInput == (int) ExportType.PDF)
            {
                IExportFileService exportService = new ExportPDFService();
                exportProcessor = new ExportProcessor(exportService);
            }
            else if (numberInput == (int) ExportType.WORD) 
            {
                IExportFileService exportService = new ExportWordService();
                exportProcessor = new ExportProcessor(exportService);
            }

            exportProcessor.Export("Example Filename");

            Console.ReadKey();
        }
    }
}