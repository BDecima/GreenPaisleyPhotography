using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenPaisleyPhotography.Models
{
    public class GalleryModel
    {
        public string Category { get; set; }
        public List<ImageModel> Images { get; set; } 

        public GalleryModel()
        {
            this.Images = new List<ImageModel>();
        }
    }
}