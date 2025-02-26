using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssignment3.Models
{
    [Table("hall")]
    public class Hall
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [Required]
        [Column("hall_name")]
        public string HallName { get; set; }

        [Required]
        [Column("owner_name")]
        public string OwnerName {  get; set; }

        [Required]
        [Column("cost_per_day")]
        public int CostPerDay {  get; set; }

        [Required]
        [Column("mobile")]
        public string Moblie {  get; set; }

        [Required]
        [Column("address")]
        public string Address { get; set; }
    }
}
