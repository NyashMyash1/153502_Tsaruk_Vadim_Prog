using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task3
{
    public class DateService
    {
        public string GetDay(string date)
        {
            var cultureInfo = new CultureInfo("ru-RU");
            var date1 = DateTime.Parse(date, cultureInfo,
                DateTimeStyles.NoCurrentDateDefault);
            string day = date1.ToString("dddd");
            if (day == "Monday")
                day = "Понедельник";
            if (day == "Tuesday")
                day = "Вторник";
            if (day == "Wednesday")
                day = "Среда";
            if (day == "Thursday")
                day = "Четверг";
            if (day == "Friday")
                day = "Пятница";
            if (day == "Saturday")
                day = "Суббота";
            if (day == "Sunday")
                day = "Воскресенье";

            return day;
        }

        public string GetDaysSpan(int day, int month, int year)
        {
            DateTime date = new DateTime(year, month, day);
            DateTime dateNow = DateTime.Now;
            TimeSpan span = dateNow.Subtract(date);
            string a = span.ToString("dd");
            return a;
        }
    }
}
