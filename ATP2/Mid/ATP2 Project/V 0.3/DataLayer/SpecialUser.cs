using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SpecialUser
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public String Password { get; set; }
    }
}
