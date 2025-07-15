using Microsoft.AspNetCore.Identity;

namespace EventSphere.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }    
        public string ProfileImage {  get; set; }

        //Navigation Property
        public ICollection<Booking>? Bookings { get; set; }
    }
}
