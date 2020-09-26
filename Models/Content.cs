using System;
using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class Content
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        // Text = ImageURL oder Text, je nach TypeOfContent
        [Required]
        public string Text { get; set; }

        public string Author { get; set; }
    }
}