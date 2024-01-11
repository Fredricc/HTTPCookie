namespace HTTPCookie
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Fred";
            Console.WriteLine(cookie["name"]);
        }
    }
}