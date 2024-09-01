using System.Globalization;

namespace Core.Common
{
    public class LocalizedEntityNames
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public string getActiveNameByLanguage()
        {

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            if (cultureInfo.TwoLetterISOLanguageName.ToLower().Equals("ar"))
                return NameAr;
            return NameEn;
        }
    }
}
