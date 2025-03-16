using System.ComponentModel.DataAnnotations;

namespace TheirDayBlazorApp.Data
{
    public class EventModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please name the event")]
        public string EventName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please specify an age group")]
        public string AgeGroup { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a price range")]
        public string PriceRange { get; set; } = string.Empty;
        public bool IsIndoor { get; set; }
    }
}

