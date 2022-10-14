namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string showName = "Supernatural";

            int seasons = 16;

            char brothers = '2';

            bool isAlive = true;

            double rating = 6.7D;

            decimal deaths = 500.62M;

            Console.WriteLine($"{showName} is a good tv show, it has {seasons} seasons, {brothers} brothers, their alive status is {isAlive} I give their show rating a {rating} and they have a total for {deaths} deaths.");
        }
    }
}