namespace GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Happy " + Environment.UserName;

            Console.WriteLine("Hello, World!");
            
            Cars myCar = new Cars("Honda","Civic");

            Console.ReadKey();
        }
    }
}