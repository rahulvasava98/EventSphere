using System.ComponentModel.DataAnnotations;

namespace EventSphere.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        public string Location { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int SeatsAvailable { get; set; }

        public string Category { get; set; }

        public string ImageUrl { get; set; }

        public bool IsFeatured
        {
            get; set;

        }

        //Navigation Property
        public ICollection<Booking>? Bookings { get; set; }

    }

}
