namespace MyApi.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string CountyCode { get; set; } = string.Empty;
        public string CountyName { get; set; } = string.Empty;

        public string CityCode { get; set; } = string.Empty;
        public string CityName { get; set; } = string.Empty;

        public string HotelCode { get; set; } = string.Empty;
        public string HotelName { get; set; } = string.Empty;

        public string HotelRating { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string? Attractions { get; set; }

        public string? Description { get; set; }

        public string? FaxNumber { get; set; }

        public string? HotelFacilities { get; set; }

        public string? Map { get; set; }  

        public string? PhoneNumber { get; set; }

        public string? PinCode { get; set; }

        public string? HotelWebsiteUrl { get; set; }
    }
}
