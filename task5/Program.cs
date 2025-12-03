namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task5");

            //aggregration operation
            List<CashierSales> salesList = new List<CashierSales>
            {
                new CashierSales { CashierName = "RamBahadur", SalesAmount = 1500.0 },
                new CashierSales { CashierName = "Shyam", SalesAmount = 2500.0 },
                new CashierSales { CashierName = "Hari", SalesAmount = 3000.0 },
                new CashierSales { CashierName = "LalBahadur", SalesAmount = 2000.0 }
            };

            int totalCashiers = salesList.Count;
            double totalSales = salesList.Sum(sale => sale.SalesAmount);
            double averageSales = salesList.Average(sale => sale.SalesAmount);
            double maxSales = salesList.Max(sale => sale.SalesAmount);
            double minSales = salesList.Min(sale => sale.SalesAmount);

            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Average Sales: {averageSales}");
            Console.WriteLine($"Max Sales: {maxSales}");
            Console.WriteLine($"Min Sales: {minSales}\n");

            //Quantifier operation
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant { Name = "Ram", Age = 25 },
                new Applicant { Name = "Shyam", Age = 17 },
                new Applicant { Name = "Hari", Age = 30 },
                new Applicant { Name = "Lal", Age = 15 }
            };

            bool anyUnder18 = applicants.Any(applicant => applicant.Age < 18);
            bool allAbove16 = applicants.All(applicant => applicant.Age >= 16);

            Console.WriteLine($"Any applicant under 18: {anyUnder18}");
            Console.WriteLine($"All applicants above 16: {allAbove16}\n");


            //element operation
            List<Music> songs = new List<Music>
            {
                new Music { Title = "kahe ki tu hi how, tu hi how", DurationSeconds = 210 },
                new Music { Title = "Tohore khatir jiyali ham", DurationSeconds = 250 },
                new Music { Title = "Aaisan kaboo pahile bahil na rahi tamanna", DurationSeconds = 300 }
            };

            var firstSong = songs.First();
            var lastSong = songs.Last();

            var firstAbove4Min = songs.First(songs => songs.DurationSeconds > 240);

            var safeLongSong = songs.FirstOrDefault(songs => songs.DurationSeconds > 600);

            Console.WriteLine($"First Song: {firstSong.Title}, Duration: {firstSong.DurationSeconds} seconds");
            Console.WriteLine($"Last Song: {lastSong.Title}, Duration: {lastSong.DurationSeconds} seconds");
            Console.WriteLine($"First Song above 4 min: {firstAbove4Min.Title}, Duration: {firstAbove4Min.DurationSeconds} seconds");
            Console.WriteLine($"Safe Long Song: {(safeLongSong == null ? "No song found" : safeLongSong.Title)}");

        }
    }
}
