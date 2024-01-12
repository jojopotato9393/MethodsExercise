using System.Transactions;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // used data
            string hey = "Hey there";
            string question = "whats yours?";
            double tiem = (11.58);
            double lunchTime = (12.00);
         
            Console.WriteLine($"{hey} My name is jake, {question}");
            Console.WriteLine("(enter name)");
            string userName = Console.ReadLine();

            Console.WriteLine($" oh thats a cool name!");
            Console.WriteLine();
            Console.WriteLine($"where do you live {userName}?");
            Console.WriteLine("(enter city name)");
            string location = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"hey I live pretty close to {location}.");
            Console.WriteLine();
            Console.WriteLine($"{hey} {userName} its {tiem} so that means it time for lunch! \n" +
                $"are you at {location}? because we should go get some food if you are, tacos are my favorite {question}");
            Console.WriteLine("(enter favorite food)");
            string foodType = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"OK sounds good  {userName} see you at {lunchTime} for {foodType}!");


            //I trying to make it more of a conversation let me know if you want my (ReadLines) to be more like (information based)
            // and i put way to much thought into this ...dw I see that now

        }
    }
}
