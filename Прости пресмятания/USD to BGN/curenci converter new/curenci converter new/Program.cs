using System;

namespace curenci_converter_new
{
    class Program
    {
        static void Main(string[] args)
        {
                        decimal sumForConcert = decimal.Parse(Console.ReadLine());

                        string valuta = Console.ReadLine().ToUpper();

                        string valutaTo = Console.ReadLine().ToUpper();

                        decimal sum = 0;

                        decimal bgn = 1.00m;
                        decimal usd = 1.79549m;

                        decimal eur = 1.95583m;
                        decimal gbp = 2.53405m;


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
                            default: break;

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
                            default: break;
                        }

                        Console.WriteLine(Math.Round(sum, 2));

                    }
                }
            }

