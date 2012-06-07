using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenPaisleyPhotography.Models;

namespace GreenPaisleyPhotography.Controllers
{
    public class GalleriesController : Controller
    {
        //
        // GET: /Galleries/

        public ActionResult Index()
        {
            return View();
        }

        public new ActionResult View(string category)
        {
            var gallery = new GalleryModel { Category = category };
            var appPath = Request.PhysicalApplicationPath;
            if (appPath != null)
            {
                var filePaths = Directory.GetFiles(appPath + "Content\\images\\" + category);
                foreach (var filePath in filePaths)
                {
                    gallery.Images.Add(new ImageModel { Path = filePath.Replace(appPath, "")});
                }
            }
            return View(gallery);
        }

    }
}
