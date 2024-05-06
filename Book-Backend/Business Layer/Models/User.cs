using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }    
        public int Tokens_Available { get; set; }
        [Required]
        public List<string> Books_Borrowed { get; set; }
        [Required]
        public List<string>Books_Lent { get; set; }

    }
}
