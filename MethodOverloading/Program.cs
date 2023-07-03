namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(8, 10));
            var answer = Add(-9, 10, true);
            Console.WriteLine(answer);
            Add(8.5, 10.5);

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        public static void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static string Add(int num1, int num2, bool withDollars)
        {
            if (withDollars && (num1 + num2) != 1)
            {
                return ($"{num1 + num2} dollars");
            }
            else if (withDollars && (num1 + num2) == 1)
            {
                return ($"{num1 + num2} dollar");
            }
            else
            {
                return ($"{num1 + num2}");
            }

        }






    }


}
