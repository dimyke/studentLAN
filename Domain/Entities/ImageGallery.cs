using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ImageGallery
    {

        public ImageGallery()
        {
            ImageList = new List<string>();
        }

        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public List<string> ImageList { get; set; }
    }
}
