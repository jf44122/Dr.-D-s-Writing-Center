using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthorSampleWebPage.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string Author { get; set; }
        public string Illustrator { get; set; }
        public string Publisher { get; set; }
        public string Synopsis { get; set; }

        //public int Price { get; set; }

        public bool IfSeries { get; set; }
        public int NumberInSeries { get; set; }
        public string SeriesName { get; set; }


    }
}