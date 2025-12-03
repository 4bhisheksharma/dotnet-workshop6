namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. List of Tour Bookings

            List<TourBooking> bookings = new List<TourBooking>
            {
                new TourBooking { CustomerName = "Ram", Destination = "Dubai",     Price = 45000, DurationInDays = 5, IsInternational = true  },
                new TourBooking { CustomerName = "Sita", Destination = "Pokhara",   Price = 8000,  DurationInDays = 3, IsInternational = false },
                new TourBooking { CustomerName = "Rohan", Destination = "Bangkok",   Price = 32000, DurationInDays = 6, IsInternational = true  },
                new TourBooking { CustomerName = "Kamal", Destination = "Chitwan",   Price = 12000, DurationInDays = 5, IsInternational = false },
                new TourBooking { CustomerName = "Shayam", Destination = "Singapore", Price = 55000, DurationInDays = 4, IsInternational = true  },
                new TourBooking { CustomerName = "Hari", Destination = "Lumbini",   Price = 15000, DurationInDays = 2, IsInternational = false }
            };


            // 2. FILTERING USING 

            var filteredTours = bookings.Where(t => t.Price > 10000 && t.DurationInDays > 4).ToList();

 
            // 3. PROJECTING INTO A NEW SHAPED LIST
            var projectedTours = filteredTours.Select(t => new TravelSummary{CustomerName = t.CustomerName, Destination = t.Destination, Category = t.IsInternational ? "International" : "Domestic", Price = t.Price}).ToList();


            // 4. SORTING
            //  Domestic first
            //  International next
            //  Then sort by price

            var sortedTours = projectedTours.OrderBy(t => t.Category == "International").ThenBy(t => t.Price).ToList();


            //results in clean format

            Console.WriteLine("Travel Summary Report\n");

            foreach (var tour in sortedTours)
            {
                Console.WriteLine($"Customer   : {tour.CustomerName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Category   : {tour.Category}");
                Console.WriteLine($"Price      : Rs. {tour.Price}");
            }
        }
    }
}
