using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotheque.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Country { get; set; }
        public bool Disponible { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateRelase { get; set; }
        public float Price { get; set; }
        public string Description {get;set;}
    }
}
