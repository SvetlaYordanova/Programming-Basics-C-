
using global::System;
using global::System.Globalization;


namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStr = System.Console.ReadLine();
            string format = "dd-MM-yyyy";

            System.DateTime datetime = System.DateTime.ParseExact(dateStr,format, System.Globalization.CultureInfo.InvariantCulture);

            System.DateTime after = datetime.AddDays(999);

            System.Console.WriteLine(after.ToString("dd-MM-yyyy"));
        }
    }
}
