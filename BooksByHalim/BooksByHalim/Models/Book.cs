using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksByHalim.Models
{
    public class Book
    {
        [Key]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string Actors { get; set; }

        [Range(1,5,ErrorMessage ="Rating is between 1 and 5")]
        public double Rating { get; set; }

        public string Type { get; set; }

        public Book()
        {
            
        }

        public Book(string name,string desc,DateTime rd,string act)
        {
            Name = name;
            Description = desc;
            ReleaseDate = rd;
            Actors = act;

        }
    }
}
