using System;

namespace DPM235505_NLThanhDat_TH4_P15_IntroduceParameterObject.After
{
    public class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public DateRange(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }
    }
}