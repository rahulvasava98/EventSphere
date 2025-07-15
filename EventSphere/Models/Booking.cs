using System.ComponentModel.DataAnnotations;

namespace EventSphere.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser? User { get; set; }

        [Required]
        public int EventId {  get; set; }

        public Event? Event { get; set; }

        public int Seats { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}
