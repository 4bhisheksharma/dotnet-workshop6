using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace task2
{
    internal class Program
    {
        //first question
        //***************************************
        public delegate int Calculate(int num1, int num2);

        public static int Add(int num1, int num2) => num1 + num2;

        public static int Subtract(int num1, int num2) => num1 - num2;

        //second question
        //***************************************
        public delegate double DiscountDelegate(double price);

        //festival discount of 20% off
        public static double FestivalDiscount(double price) => price * 0.20;

        //seasonal discount of 10% off
        public static double SeasonalDiscount(double price) => price * 0.10;

        //no discount season bina k ko discont?
        public static double NoDiscount(double price) => price;


        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task2\n");

            Calculate calculateAdd = Add;
            Calculate calculateSubtract = Subtract;

            Console.WriteLine($"Addition: {calculateAdd(10, 5)}");
            Console.WriteLine($"Subtraction: {calculateSubtract(10, 5)}\n");

            Console.WriteLine("Question 2");
            DiscountDelegate festivalDiscount = FestivalDiscount;
            DiscountDelegate seasonalDiscount = SeasonalDiscount;
            DiscountDelegate noDiscount = NoDiscount;

            double price = 1000.0;

            Console.WriteLine($"Original Amount: {price}");
            Console.WriteLine($"Festival Discounted Price: {festivalDiscount(price)}");
            Console.WriteLine($"Seasonal Discounted Price: {seasonalDiscount(price)}");
            Console.WriteLine($"No Discount(original price): {noDiscount(price)}");



        }
    }
}
