namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a hard subject!");
                    break;
                case "Science":
                    Console.WriteLine("Science is an intriguing subject!");
                    break;
                case "History":
                    Console.WriteLine("History is an important subject!");
                    break;
                case "English":
                    Console.WriteLine("English is a fun subject!");
                    break;
                case "Art":
                    Console.WriteLine("Art is a creative subject!");
                    break;
                default:
                    Console.WriteLine("That's a great subject!");
                    break;
            }
        }
    }
}