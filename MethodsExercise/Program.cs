namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string userBand = Console.ReadLine();
            
            Console.WriteLine($"Yesterday, {userName} went on a date and was wearing a {userColor} shirt with a {userAnimal} on it. On the way to the date he was listening to {userBand} to hype himself up)");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        static void Main(string[] args)
        {
            MadLib();
            
        }
    }
}
