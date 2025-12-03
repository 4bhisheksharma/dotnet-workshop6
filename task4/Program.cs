namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello form task4\n");

            //selection and projection
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var squaredNumbers = numbers.Select(numbers => numbers * numbers).ToList();

            Console.WriteLine("Squared Numbers:");
            foreach (var num in squaredNumbers)
            {
                Console.WriteLine(num);
            }

            //filtering book price above 1000
            List<Book> books = new List<Book>
            {
                new Book { Title = "C# Programming", Price = 1200 },
                new Book { Title = "Java Programming", Price = 900 },
                new Book { Title = "Python Programming", Price = 1500 },
                new Book { Title = "Dart Programming", Price = 800 }
            };

            var mahangoBooks = books.Where(book => book.Price > 1000).ToList();
            Console.WriteLine("\nBooks with Price above 1000:");
            foreach (var book in mahangoBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }



            //shorting alphabetically student names
            List<Student> students = new List<Student>
            {
                new Student { Name = "Ram Bhai" },
                new Student { Name = "Shayam Dai" },
                new Student { Name = "Hari Bahadur" },
                new Student { Name = "Harka sampang" }
            };
            var sortedStudents = students.OrderBy(student => student.Name).ToList();
            Console.WriteLine("\nStudents sorted alphabetically:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Name);
            }

        }
    }
}
