using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sumForConvert = decimal.Parse(Console.ReadLine());

            string valutaVhod = Console.ReadLine().ToLower();

            string valutaIzhod = Console.ReadLine().ToLower();

            decimal finlaSum = 0;

            //BGN, USD- 1.79549; EUR- 1.95583; GBP-2.53405;

            if (valutaVhod == "bgn")
            {
                if (valutaIzhod == "bgn")
                {
                    finlaSum = sumForConvert;
                }

                else if (valutaIzhod == "usd")
                {
                    finlaSum = sumForConvert / 1.79549m;
                }
                else if (valutaIzhod == "eur")
                {
                    finlaSum = sumForConvert / 1.95583m;
                }
                else if (valutaIzhod == "gbp")
                {
                    finlaSum = sumForConvert / 2.53405m;
                }

            }
            if (valutaVhod == "usd")
            {
                if (valutaIzhod == "bgn")
                {
                    finlaSum = sumForConvert *1.79549m;
                }

                else if (valutaIzhod == "usd")
                {
                    finlaSum = sumForConvert;
                }
                else if (valutaIzhod == "eur")
                {
                    finlaSum = (sumForConvert * 1.79549m) / 1.95583m;
                }
                else if (valutaIzhod == "gbp")
                {
                    finlaSum = (sumForConvert * 1.79549m) / 2.53405m;
                }

            }

            if (valutaVhod == "eur")
            {
                if (valutaIzhod == "bgn")
                {
                    finlaSum = sumForConvert / 1.95583m;
                }
                else if (valutaIzhod == "usd")
                {
                    finlaSum = (sumForConvert * 1.95583m) / 1.79549m;

                }
                else if (valutaIzhod == "eur")
                {
                    finlaSum = sumForConvert;
                }

                else if (valutaIzhod == "gbp")
                {
                    finlaSum = (sumForConvert * 1.95583m) / 2.53405m;
                }
            }

            if (valutaVhod == "gbp")
            {
                if (valutaIzhod == "bgn")
                {
                    finlaSum = sumForConvert * 2.53405m;
                }

                else if (valutaIzhod == "usd")
                {
                    finlaSum = (sumForConvert * 2.53405m ) / 1.79549m ;
                }
                else if (valutaIzhod == "eur")
                {
                    finlaSum = (sumForConvert * 2.53405m ) / 1.95583m;
                }
                else if (valutaIzhod == "gbp")
                {
                    finlaSum = sumForConvert;
                }
            }
            finlaSum= Math.Round(finlaSum,2);

            Console.WriteLine(finlaSum +" "+ valutaIzhod.ToUpper());
        }

        }
        }
       
    



