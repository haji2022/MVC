namespace MVC.Models
{
    public class GuessModel
    {
        public static int GuessGamenummer { get; set; }
        public static int Count { get; private set; }

        public static string GuessGame(int nr)
        {
            Count++;
            if (nr > GuessGamenummer)
                return "Less";

            if (nr < GuessGamenummer)
                return "More";
            else
                return "Correct";
        }

        internal static int GNR()
        {
            Random r = new Random();
            return r.Next(1, 100);
        }
    }
}