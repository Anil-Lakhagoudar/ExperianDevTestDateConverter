using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConverter
{
    public class DateConvert
    {
        public static string Convert(string inputDate, int addDays)
        {
            string outputDate = string.Empty;

            DateTime date;
            if (DateTime.TryParseExact(inputDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                date = DateTime.ParseExact(inputDate, "dd/MM/yyyy", null);
                date = date.AddDays(addDays);
                outputDate = date.ToString("dd'/'MM'/'yyyy");
            }

            return outputDate;
        }
    }
}
