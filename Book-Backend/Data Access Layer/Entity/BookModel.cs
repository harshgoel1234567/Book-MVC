using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Entity
{
    public class BookModel
    {
        [Key]
        public Guid Book_Id { get; set; }
        [Required]
        public string Book_Name { get; set; }

        [Required]  
        public int Rating { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Genre { get; set; }


        [Required]
        public bool Aavailability_status { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public string Lent_Id { get; set;}
        [Required]
        public string Borrowed_Id { get; set; }


    }
}
