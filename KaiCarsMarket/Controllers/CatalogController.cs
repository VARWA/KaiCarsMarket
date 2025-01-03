using KaiCarsMarket.Data;
using KaiCarsMarket.Models;
using Microsoft.AspNetCore.Mvc;

namespace KaiCarsMarket.Controllers
{
    public class CatalogController : Controller
    {
        public CatalogController(UsersContext context)
        {
            _context = context;
        }

        private readonly UsersContext _context;

        public IActionResult Index()
        {
            if (!_context.Cars.Any())
            {
                var cars = new List<Cars>
{
    new Cars { Brand = "Toyota", Model = "Camry", Year = 2022, Price = 30000, Description = "Reliable mid-size sedan.", ImagePath = "toyota_camry.jpg", Availability = true },
    new Cars { Brand = "Honda", Model = "Civic", Year = 2021, Price = 22000, Description = "Compact and fuel-efficient sedan.", ImagePath = "honda_civic.jpg", Availability = true },
    new Cars { Brand = "BMW", Model = "X5", Year = 2020, Price = 50000, Description = "Luxury SUV with advanced features.", ImagePath = "bmw_x5.jpg", Availability = true },
    new Cars { Brand = "Audi", Model = "A4", Year = 2021, Price = 35000, Description = "Sporty sedan with premium design.", ImagePath = "audi_a4.jpg", Availability = true },
    new Cars { Brand = "Mercedes", Model = "C-Class", Year = 2021, Price = 38000, Description = "Compact luxury sedan with smooth handling.", ImagePath = "mercedes_c_class.jpg", Availability = true },
    new Cars { Brand = "Ford", Model = "Mustang", Year = 2023, Price = 45000, Description = "Iconic muscle car with impressive performance.", ImagePath = "ford_mustang.jpg", Availability = true },
    new Cars { Brand = "Chevrolet", Model = "Tahoe", Year = 2022, Price = 65000, Description = "Spacious full-size SUV with advanced safety features.", ImagePath = "chevrolet_tahoe.jpg", Availability = true },
    new Cars { Brand = "Tesla", Model = "Model 3", Year = 2022, Price = 47000, Description = "Electric sedan with cutting-edge technology.", ImagePath = "tesla_model3.jpg", Availability = true },
    new Cars { Brand = "Nissan", Model = "Altima", Year = 2021, Price = 25000, Description = "Affordable midsize sedan with good performance.", ImagePath = "nissan_altima.jpg", Availability = true },
    new Cars { Brand = "Hyundai", Model = "Elantra", Year = 2021, Price = 22000, Description = "Stylish compact sedan with great value.", ImagePath = "hyundai_elantra.jpg", Availability = true },
    new Cars { Brand = "Kia", Model = "Sportage", Year = 2022, Price = 28000, Description = "Compact SUV with modern features and comfort.", ImagePath = "kia_sportage.jpg", Availability = true },
    new Cars { Brand = "Mazda", Model = "CX-5", Year = 2022, Price = 35000, Description = "Sleek crossover SUV with sporty handling.", ImagePath = "mazda_cx5.jpg", Availability = true },
    new Cars { Brand = "Subaru", Model = "Outback", Year = 2021, Price = 32000, Description = "All-wheel-drive crossover for outdoor adventures.", ImagePath = "subaru_outback.jpg", Availability = true },
    new Cars { Brand = "Volkswagen", Model = "Tiguan", Year = 2021, Price = 33000, Description = "Compact SUV with a premium feel.", ImagePath = "volkswagen_tiguan.jpg", Availability = true },
    new Cars { Brand = "Jeep", Model = "Wrangler", Year = 2023, Price = 48000, Description = "Off-road ready SUV with rugged design.", ImagePath = "jeep_wrangler.jpg", Availability = true },
    new Cars { Brand = "Land Rover", Model = "Defender", Year = 2023, Price = 70000, Description = "Luxury SUV with exceptional off-road capability.", ImagePath = "land_rover_defender.jpg", Availability = true },
    new Cars { Brand = "Porsche", Model = "911", Year = 2022, Price = 95000, Description = "High-performance sports car with iconic design.", ImagePath = "porsche_911.jpg", Availability = true },
    new Cars { Brand = "Lexus", Model = "RX", Year = 2022, Price = 60000, Description = "Luxury SUV with excellent comfort and safety.", ImagePath = "lexus_rx.jpg", Availability = true },
    new Cars { Brand = "Chrysler", Model = "Pacifica", Year = 2022, Price = 42000, Description = "Family-friendly minivan with plenty of space.", ImagePath = "chrysler_pacifica.jpg", Availability = true },
    new Cars { Brand = "Dodge", Model = "Charger", Year = 2021, Price = 40000, Description = "Muscle car with powerful engine options.", ImagePath = "dodge_charger.jpg", Availability = true },
    new Cars { Brand = "Ram", Model = "1500", Year = 2022, Price = 45000, Description = "Full-size pickup truck with strong towing capacity.", ImagePath = "ram_1500.jpg", Availability = true },
    new Cars { Brand = "Toyota", Model = "Highlander", Year = 2022, Price = 52000, Description = "Spacious SUV with three-row seating.", ImagePath = "toyota_highlander.jpg", Availability = true },
    new Cars { Brand = "Honda", Model = "Pilot", Year = 2021, Price = 48000, Description = "Family-friendly three-row SUV with great value.", ImagePath = "honda_pilot.jpg", Availability = true },
    new Cars { Brand = "BMW", Model = "328i", Year = 2022, Price = 39000, Description = "Sporty sedan with elegant design and driving dynamics.", ImagePath = "bmw_328i.jpg", Availability = true },
    new Cars { Brand = "Audi", Model = "Q5", Year = 2022, Price = 55000, Description = "Luxury crossover with refined features.", ImagePath = "audi_q5.jpg", Availability = true },
    new Cars { Brand = "Ford", Model = "Explorer", Year = 2022, Price = 57000, Description = "Spacious SUV with modern technology.", ImagePath = "ford_explorer.jpg", Availability = true },
    new Cars { Brand = "Chevrolet", Model = "Silverado", Year = 2021, Price = 53000, Description = "Full-size pickup with great towing capabilities.", ImagePath = "chevrolet_silverado.jpg", Availability = true },
    new Cars { Brand = "Tesla", Model = "Model S", Year = 2022, Price = 95000, Description = "Luxury electric sedan with extreme performance.", ImagePath = "tesla_model_s.jpg", Availability = true },
    new Cars { Brand = "Nissan", Model = "Murano", Year = 2021, Price = 43000, Description = "Mid-size SUV with luxurious interior.", ImagePath = "nissan_murano.jpg", Availability = true },
    new Cars { Brand = "Hyundai", Model = "Santa Fe", Year = 2022, Price = 37000, Description = "Comfortable and stylish SUV for everyday use.", ImagePath = "hyundai_santa_fe.jpg", Availability = true },
    new Cars { Brand = "Kia", Model = "Telluride", Year = 2022, Price = 59000, Description = "Family-sized SUV with top-tier amenities.", ImagePath = "kia_telluride.jpg", Availability = true },
    new Cars { Brand = "Mazda", Model = "CX-9", Year = 2022, Price = 55000, Description = "Three-row SUV with elegant design.", ImagePath = "mazda_cx9.jpg", Availability = true },
    new Cars { Brand = "Subaru", Model = "Forester", Year = 2022, Price = 35000, Description = "Compact SUV with great off-road capabilities.", ImagePath = "subaru_forester.jpg", Availability = true },
    new Cars { Brand = "Volkswagen", Model = "ID.4", Year = 2022, Price = 40000, Description = "Electric SUV with futuristic design.", ImagePath = "volkswagen_id4.jpg", Availability = true },
    new Cars { Brand = "Jeep", Model = "Cherokee", Year = 2021, Price = 37000, Description = "Compact SUV with rugged styling.", ImagePath = "jeep_cherokee.jpg", Availability = true },
    new Cars { Brand = "Land Rover", Model = "Range Rover", Year = 2022, Price = 100000, Description = "Luxury SUV with unparalleled off-road prowess.", ImagePath = "land_rover_range_rover.jpg", Availability = true },
    new Cars { Brand = "Porsche", Model = "Macan", Year = 2021, Price = 68000, Description = "Luxury compact SUV with sporty performance.", ImagePath = "porsche_macan.jpg", Availability = true },
    new Cars { Brand = "Lexus", Model = "ES", Year = 2021, Price = 47000, Description = "Mid-size luxury sedan with exceptional comfort.", ImagePath = "lexus_es.jpg", Availability = true },
    new Cars { Brand = "Chrysler", Model = "Voyager", Year = 2022, Price = 44000, Description = "Minivan with plenty of room for families.", ImagePath = "chrysler_voyager.jpg", Availability = true }
};
                _context.Cars.AddRange(cars);
                _context.SaveChangesAsync();
            }
            {
                return View(_context.Cars);
            }
            return View();
        }
    }
}
