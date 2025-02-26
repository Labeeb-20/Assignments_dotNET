using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace MVCAssignment2.Models
{
    public class RentCalculator
    { 
        [Required]
        public String Name {  get; set; }

        [Required]
        public string HallOwner {  get; set; }

        [Required]
        public int costPerDay { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }
        

    }
}
