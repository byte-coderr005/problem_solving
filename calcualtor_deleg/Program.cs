namespace calcualtor_deleg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator which using delegates..");
            Calculate addition = new Calculate(Plus);
            Calculate substraction = new Calculate(subtraction);
            Calculate multiply = new Calculate(Multiply);
            Calculate divide = new Calculate(Divide);
            Console.WriteLine("Please enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Select symbol ( +,-,*,/): ");
            string operation = Console.ReadLine();
            Calculate selectedOperation = operation switch
            {
                "+" => addition,
                "-" => substraction,
                "*" => multiply,
                "/" => divide,
                _ => null
            };
            if(selectedOperation != null)
            {
                Console.WriteLine($"Sonuç: {selectedOperation(num1,num2)}");
            }

            
        }
        public delegate int Calculate(int num1, int num2);
        public static int Plus(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int Divide(int num1,int num2)
        {
            if(num2 == 0)
            {
                Console.WriteLine($"{num1} is zero. We can not run." );
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }
        public static int Multiply(int num1,int num2)
        {
            return num1 * num2;
        }
        public static int subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
