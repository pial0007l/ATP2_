using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Passenger
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Mobile No.")]
        public int Mobile { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Gender")]
        public String Gender { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Address")]
        public String Address { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Boarding")]
        public String Boarding { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Droping")]
        public String Droping { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Display(Name = "Departure Date")]
        public DateTime DepartureDate { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Payment Method")]
        public String Payment { get; set; }

        [Required]
        [Display(Name = "NID/PASS")]
        public int Nid { get; set; }

        [Required]
        [Display(Name = "BusID")]
        public int BusID { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Total Paid")]
        public String Ammount { get; set; }

        public List<Seat> SeatsOfPassengers { get; set; }
    }
}
