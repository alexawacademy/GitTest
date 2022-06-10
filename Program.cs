namespace GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Happy " + Environment.UserName;

            Console.WriteLine("Hello, World!");
            
            Cars myCar = new Cars("Honda","Civic");

            Person person = new Person("Ajax", 25);

            Person person2 = new Person("Emanuel", 29);

            Console.ReadKey();
        }
    }
}