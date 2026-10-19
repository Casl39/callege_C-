using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetBoomTrips
{
    public class trips
    {
        public int id {  get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string destination { get; set; }
        public int duration { get; set; }
        public string image_filename { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }

        public trips() { }

        public trips(int id, string title, string description, decimal price, string destination, int duration, string image_filename, DateTime start_date, DateTime end_date)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.destination = destination;
            this.duration = duration;
            this.image_filename = image_filename;
            this.start_date = start_date;
            this.end_date = end_date;
        }
    }
}
