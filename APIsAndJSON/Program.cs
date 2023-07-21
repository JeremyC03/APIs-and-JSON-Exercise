using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}.");
                RonVSKanyeAPI.RonQuote();
                RonVSKanyeAPI.KanyeQuote();
            }
            

            
        }
    }
}
