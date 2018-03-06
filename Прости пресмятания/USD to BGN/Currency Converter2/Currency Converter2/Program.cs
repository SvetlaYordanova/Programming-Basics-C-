using System;




namespace Currency_Converter2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sumForConcert = decimal.Parse(Console.ReadLine());

            string valuta = Console.ReadLine().ToUpper();

            string valutaTo = Console.ReadLine().ToUpper();

            decimal sum = 0;

            decimal bgn = 1;
            decimal usd = 1.79549;

            decimal eur = 1.95583;
            decimal gbp = 2.53405;


            switch (valuta)
            {
                case "BGN":
                    sum = sumForConcert; break;
                case "USD":
                    sum = sumForConcert * usd; break;
                case "EUR":
                    sum = sumForConcert * eur; break;
                case "GBP":
                    sum = sumForConcert * gbp; break;
                    default:break;

            }
            switch (valutaTo)
            {
                case "BGN":
                    sum = sumForConcert / bgn; break;
                case "USD":
                    sum = sumForConcert / usd; break;
                case "EUR":

                    sum = sumForConcert / eur; break;
                case "GBP":
                    sum = sumForConcert / gbp; break;
                    default:break;
            }

            Console.WriteLine(Math.Round(sum, 2));

        }
    }
}
