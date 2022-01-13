namespace SoftsBOT
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new BOT();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}