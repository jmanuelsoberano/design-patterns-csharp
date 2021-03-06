using DesignPatterns.Bridge.Example01.Version01.Business;

namespace DesignPatterns.Bridge.Example01.Version01
{
    public class Example
    {
        public void Execute()
        {
            var now = DateTime.Now;

            var license1 = new TwoDaysLicense("Secret Life of Pets", now);
            var license2 = new LifeLongLicense("Matrix", now);

            PrintLicenseDetails(license1);
            PrintLicenseDetails(license2);
        }

        private static void PrintLicenseDetails(MovieLicense license)
        {
            Console.WriteLine($"Movie: {license.Movie}");
            Console.WriteLine($"Price: {GetPrice(license)}");
            Console.WriteLine($"Valid for: {GetValidFor(license)}");

            Console.WriteLine();
        }

        private static string GetPrice(MovieLicense license)
        {
            return $"${license.GetPrice():0.00}";
        }

        private static string GetValidFor(MovieLicense license)
        {
            var expirationDate = license.GetExpirationDate();

            if (expirationDate == null)
                return "Forever";

            var timeSpan = expirationDate.Value - DateTime.Now;

            return $"{timeSpan.Days}d {timeSpan.Hours}h {timeSpan.Minutes}m";
        }
    }
}
