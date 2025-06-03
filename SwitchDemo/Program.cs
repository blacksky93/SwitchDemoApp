namespace SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 75;

            //switch (firstName.ToLower())
            //{
            //    case "tim" or "sue":
            //        Console.WriteLine("Hello Professor!");
            //        break;
            //    case "tom":
            //        Console.WriteLine("Hello Tom!");
            //        break;
            //    default:
            //        Console.WriteLine("Hello person!");
            //        break;
            //}

            switch (age)
            {
                case >= 0 and < 18:
                    Console.WriteLine("You are a child!");
                    break;
                case >= 18 and < 66:
                    Console.WriteLine("You should have a job.");
                    break;
                case >= 66:
                    Console.WriteLine("Hopefully you are retired or retiring soon.");
                    break;
                default:
                    Console.WriteLine("Age was not in expected range.");
                    break;
            }
        }
    }
}
