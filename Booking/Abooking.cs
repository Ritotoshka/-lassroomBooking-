using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class Abooking
    {
        public int Id { get; set; }
        public int Id_teacher { get; set; }
        public string Teacher { get; set; }
        public int Id_audience { get; set; }
        public string Audience { get; set; }
        public string Date_booking { get; set; }
        public string Time_start { get; set; }
        public string Time_end { get; set; }
    }
}
