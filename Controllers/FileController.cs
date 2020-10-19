using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab02_MVC.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace lab02_MVC.Controllers
{
    public class FileController : Controller
    {
        private readonly ILogger<FileController> _logger;

        private readonly IWebHostEnvironment _webHostEnvironment;


    // public IActionResult Index()
    // {
    //     return Content(_webHostEnvironment.WebRootPath + "\n" + _webHostEnvironment.ContentRootPath);
    // }
 
        public FileController(ILogger<FileController> logger,IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
             _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        { 
            ViewBag.Files = Directory.GetFiles( _webHostEnvironment.ContentRootPath+"/Textfile");
            return View();
        }



        public IActionResult Content(int id)
        //I wanted to get the string as the file path, and pass it to StreamReader, however, I cannot get that from the view. 
        //I already tried with int, and it does not work either.... 
        {

            try{
                using( var sr = new StreamReader("./TextFiles/File"+id+".txt"))
                {
                    string content = sr.ReadToEnd();
                    ViewBag.Content = content;
                    Console.WriteLine(content);
                    Console.WriteLine(id);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
