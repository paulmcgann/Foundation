using System.Globalization;

namespace Foundation.Infrastructure.Commerce.Extensions
{
    public static class MarketExtensions
    {
        public static string MarketCodeAdapter(this string countryCode)
        {
            switch (countryCode)
            {
                case "USA":
                    return "US";
                case "GBR":
                    return "UK";
                case "ESP":
                    return "ESP";
                case "AFG":
                    return "AF";
                case "ALB":
                    return "AL";
                case "AUS":
                    return "AUS";
                case "BRA":
                    return "BRA";
                case "CAN":
                    return "CAN";
                case "CHL":
                    return "CHL";
                case "DEU":
                    return "DEU";
                case "JPN":
                    return "JPN";
                case "NLD":
                    return "NLD";
                case "NOR":
                    return "NOR";
                case "SAU":
                    return "SAU";
                case "SWE":
                    return "SWE";
                default:
                    return "US";
            }
        }

        public static string ConvertThreeLetterNameToTwoLetterName(this string countryCode)
        {
            if (countryCode.Length != 3)
            {
                if (countryCode.Length != 2)
                {
                    throw new ArgumentException("name must be three letters.");
                }
            }

            countryCode = countryCode.ToUpper();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);
                if (region.ThreeLetterISORegionName.ToUpper() == countryCode)
                {
                    return region.TwoLetterISORegionName;
                }
            }

            return countryCode;
        }

        public static string ConvertTwoLetterNameToThreeLetterName(this string countryCode)
        {
            if (countryCode.Length != 2)
            {
                if (countryCode.Length != 3)
                {
                    throw new ArgumentException("name must be three letters.");
                }
            }

            countryCode = countryCode.ToUpper();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);
                if (region.TwoLetterISORegionName.ToUpper() == countryCode)
                {
                    return region.ThreeLetterISORegionName;
                }
            }

            return countryCode;
        }
    }
}
