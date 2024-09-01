using System.Globalization;

namespace Data.Common
{
    public class GeneralLocalizer
    {
        public string getActiveNameByLanguage(string propertyAR, string propertyEN)
        {

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            if (cultureInfo.TwoLetterISOLanguageName.ToLower().Equals("ar"))
                return propertyAR;
            return propertyEN;
        }
    }
}
