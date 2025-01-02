namespace KaiCarsMarket.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public bool? Availability { get; set; }

    }
}
