namespace BicycleApp.Common
{
    using BicycleApp.Common.Providers.Contracts;
    using BicycleApp.Common.Models;
    using System;

    public class DateTimeProvider : IDateTimeProvider
    {
        public virtual DateTime Now => DateTime.UtcNow;

        public virtual PreviousMonthData PreviousMonthObject
        {
            get
            {
                return GetPreviousMonthData();
            }
        }

        private PreviousMonthData GetPreviousMonthData()
        {
            var previousMonthObject = new PreviousMonthData();

            var previousMonth = DateTime.UtcNow.Month - 1;

            if (previousMonth < 1)
            {
                previousMonthObject.PreviousMonth = 12;
                previousMonthObject.PreviousYear = DateTime.UtcNow.Year - 1;
            }
            else
            {
                previousMonthObject.PreviousMonth = previousMonth;
                previousMonthObject.PreviousYear = DateTime.UtcNow.Year;
            }

            return previousMonthObject;
        }
    }
}
